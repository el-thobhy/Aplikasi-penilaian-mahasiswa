import React from "react";
import { config } from "../../configurations/config";
import { ECommand } from "../../enums/eCommand";
import { ModelDosen } from "../../models/modelDosen";
import { ModelPagination } from "../../models/modelPagination";
import { DosenService } from "../../services/dosenService";
import Form from "./form";
import { ValidationResult } from "../../validations/validationResult";

interface IProps {}
interface IState {
  dosen: ModelDosen[];
  lecturer: ModelDosen;
  pagination: ModelPagination;
  showModal: boolean;
  errorAlerts: any;
  showModalDelete: boolean;
  command: ECommand;
}

export default class Dosen extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      dosen: [],
      lecturer: new ModelDosen(),
      showModal: false,
      showModalDelete: false,
      errorAlerts: { name: false },
      command: ECommand.create,
      pagination: new ModelPagination(),
    };
  }
  componentDidMount(): void {
    this.loadDosen();
  }

  loadDosen = async () => {
    const { pagination } = this.state;
    const result = await DosenService.getAll(pagination);
    if (result.success) {
      this.setState({
        dosen: result.result,
        pagination: {
          ...this.state.pagination,
          pages: result.pages,
        },
      });
    } else {
      alert("Error: " + result.result);
    }
  };

  createCommand = () => {
    this.setState({
      showModal: true,
      lecturer: new ModelDosen(),
      command: ECommand.create,
    });
    // this.setShowModal(true);
  };

  deleteCommand = async (id: number) => {
    await DosenService.getById(id)
      .then((result) => {
        if (result.success) {
          this.setState({
            showModalDelete: true,
            lecturer: result.result,
            command: ECommand.changeStatus,
          });
        } else {
          alert("Error result " + result.result);
        }
      })
      .catch((error) => {
        alert("Error error" + error);
      });
  };
  setShowModalDelete = (val: boolean) => {
    this.setState({
      showModalDelete: val,
    });
  };

  changeSearch = (name: any) => (event: any) => {
    this.setState({
      pagination: {
        ...this.state.pagination,
        [name]: event.target.value,
      },
    });
  };

  changeRowsPerPage = (name: any) => (event: any) => {
    this.setState({
      pagination: {
        ...this.state.pagination,
        [name]: event.target.value,
      },
    });
    new Promise(() => {
      setTimeout(() => {
        this.loadDosen();
      }, 500);
    });
  };

  updateCommand = async (id: number) => {
    await DosenService.getById(id)
      .then((result) => {
        if (result.success) {
          this.setState({
            showModal: true,
            lecturer: result.result,
            command: ECommand.edit,
          });
        } else {
          alert("Error result " + result.result);
        }
      })
      .catch((error) => {
        alert("Error error" + error);
      });
  };

  setShowModal = (val: boolean) => {
    this.setState({
      showModal: val,
      errorAlerts: { name: false },
    });
  };

  changeHandler = (name: any) => (event: any) => {
    this.setState({
      lecturer: {
        ...this.state.lecturer,
        [name]: event.target.value,
      },
    });
    this.setState({
      errorAlerts: {
        ...this.state.errorAlerts,
        [name]: !event.target.value,
      },
    });
  };

  submitHandler = async (event: any) => {
    const { command, lecturer } = this.state;
    if (command == ECommand.create) {
      event.preventDefault();
      this.setState({
        errorAlerts: {
          nama_Dosen: {
            valid: this.state.lecturer.nama_Dosen.trim().length > 0,
            message: "Nama tidak boleh kosong",
          },
          id_Jurusan: {
            valid: this.state.lecturer.id_Jurusan > 0,
            message: "Jurusan tidak boleh kosong",
          },
          id_Type_Dosen: {
            valid: this.state.lecturer.id_Type_Dosen > 0,
            message: "Type Dosen tidak boleh kosong",
          },
        },
      });
      if (
        this.state.lecturer.nama_Dosen.trim().length === 0 ||
        this.state.lecturer.id_Jurusan === 0 ||
        this.state.lecturer.id_Type_Dosen === 0
      ) {
        return;
      }

      await DosenService.post(this.state.lecturer)
        .then((result) => {
          if (result.success) {
            this.setState({
              showModal: false,
              lecturer: new ModelDosen(),
            });
            this.loadDosen();
          } else {
            this.setState({
              errorAlerts: ValidationResult.Validate(result.result),
            });
          }
        })
        .catch((error) => {
          alert("Error error" + error);
        });
    } else if (command == ECommand.edit) {
      await DosenService.update(lecturer.id, lecturer)
        .then((result) => {
          if (result.success) {
            this.setState({
              showModal: false,
              lecturer: new ModelDosen(),
            });
            this.loadDosen();
          } else {
            alert("Error result " + result.result);
          }
        })
        .catch((error) => {
          alert("Error error" + error);
        });
    } else if (command == ECommand.changeStatus) {
      await DosenService.changeStatus(lecturer.id, true)
        .then((result) => {
          if (result.success) {
            this.setState({
              showModalDelete: false,
              lecturer: new ModelDosen(),
            });
            this.loadDosen();
          } else {
            alert("Error result " + result.result);
          }
        })
        .catch((error) => {
          alert("Error error" + error);
        });
    }
  };

  render() {
    const {
      dosen,
      pagination,
      showModal,
      lecturer,
      command,
      showModalDelete,
      errorAlerts,
    } = this.state;
    const loopPages = () => {
      let content: any = [];
      for (let page = 1; page <= pagination.pages; page++) {
        content.push(<option value={page}>{page}</option>);
      }
      return content;
    };
    return (
      <div className="h-full mb-3 me-3">
        <div className="text-left text-3xl p-5 font-bold text-black">Dosen</div>
        <table className="w-full text-sm text-left text-gray-500 dark:text-gray-400">
          <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
            <tr className="border-b dark:bg-gray-900 dark:border-gray-700">
              <div className="flex ms-6" aria-label="Button">
                <button
                  className="my-8 justify-start h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded focus:shadow-outline hover:bg-green-800"
                  onClick={() => this.createCommand()}
                >
                  Create New
                </button>
              </div>
              <th scope="col" className="px-6 w-14 h-12">
                Search:
              </th>
              <th colSpan={3} scope="col" className="px-6 w-14 h-12">
                <input
                  type="text"
                  id="search"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  required
                  value={pagination.search}
                  onChange={this.changeSearch("search")}
                />
              </th>
              <th scope="col" className="px-6 w-14 h-12">
                <button
                  className="my-8 justify-start h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded focus:shadow-outline hover:bg-green-800"
                  onClick={() => this.loadDosen()}
                >
                  Filter
                </button>
              </th>
              <th scope="col" className="px-6 w-14 h-12">
                <select
                  id="countries"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  onChange={this.changeRowsPerPage("sort")}
                >
                  <option value="0">Asc</option>
                  <option value="1">Desc</option>
                </select>
              </th>
            </tr>
            <tr className="border-b dark:bg-gray-900 dark:border-gray-700">
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Kode Dosen
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Nama Dosen
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Kode Jurusan
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Kode Tipe Dosen
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Jurusan
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Tipe Dosen
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Action
              </th>
            </tr>
          </thead>
          <tbody>
            {dosen?.map((cat: ModelDosen) => {
              return (
                <tr
                  key={cat.id}
                  className="border-b dark:bg-gray-800 dark:border-gray-700"
                >
                  <td className="px-6 py-4">{cat.kode_Dosen}</td>
                  <td className="px-6 py-4">{cat.nama_Dosen}</td>
                  <td className="px-6 py-4">{cat.id_Jurusan}</td>
                  <td className="px-6 py-4">{cat.id_Type_Dosen}</td>
                  <td className="px-6 py-4">{cat.jurusan.nama_Jurusan}</td>
                  <td className="px-6 py-4">{cat.typeDosen.deskripsi}</td>
                  <td className="px-4 py-4">
                    <div
                      className="inline-flex"
                      role="group"
                      aria-label="Button group"
                    >
                      <button
                        className="h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded-l-lg focus:shadow-outline hover:bg-green-800"
                        onClick={() => this.updateCommand(cat.id)}
                      >
                        Edit
                      </button>
                      <button
                        className="h-8 px-4 text-blue-100 transition-colors duration-150 bg-red-700 rounded-r-lg focus:shadow-outline hover:bg-red-800"
                        onClick={() => this.deleteCommand(cat.id)}
                      >
                        Hapus
                      </button>
                    </div>
                  </td>
                </tr>
              );
            })}
          </tbody>
          <tfoot className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
            <tr className="border-b dark:bg-gray-900 dark:border-gray-700">
              <th scope="col" className="px-6 py-3 w-14 h-14">
                <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
                  Rows per page:{" "}
                </label>
              </th>
              <th colSpan={2} scope="col" className="px-6 py-3 w-14 h-14">
                <select
                  id="countries"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  onChange={this.changeRowsPerPage("rows")}
                >
                  {config.rowsPerPage.map((o: number) => {
                    return <option value={o}>{o}</option>;
                  })}
                </select>
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Page:
              </th>
              <th colSpan={2} scope="col" className="px-6 py-3 w-14 h-14">
                <select
                  id="countries"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  onChange={this.changeRowsPerPage("pageNum")}
                >
                  {loopPages()}
                </select>
              </th>
              <th></th>
            </tr>
          </tfoot>
        </table>
        {showModal ? (
          <div className="flex justify-center items-center overflow-x-hidden overflow-y-auto fixed inset-0 z-50 outline-none focus:outline-none ">
            <div className="relative w-auto my-6 mx-auto max-w-3xl ">
              <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none bg-white">
                <div className="flex items-start justify-between p-5 border-b border-solid border-gray-300 rounded-t ">
                  <h3 className="text-3xl font-bold text-gray-900 text-black">
                    {command.valueOf()}
                  </h3>
                  <button
                    className="bg-transparent border-0 text-black float-right"
                    onClick={() => this.setShowModal(false)}
                  >
                    <span className="text-black opacity-7 h-6 w-6 text-xl block bg-gray-400 py-0 rounded-full">
                      x
                    </span>
                  </button>
                </div>
                <div className="relative p-6 w-[340px] flex-auto">
                  <Form
                    dosen={lecturer}
                    errorAlerts={errorAlerts}
                    command={command}
                    changeHandler={this.changeHandler}
                  />
                </div>
                <div
                  className="flex items-center justify-end p-6 border-t border-solid border-blueGray-200 rounded-b"
                  role="group"
                  aria-label="Button group"
                >
                  <button
                    className="my-8 justify-start h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded-l-lg focus:shadow-outline hover:bg-green-800"
                    onClick={() => this.setShowModal(false)}
                  >
                    Close
                  </button>
                  <button
                    className="my-8 justify-start h-8 px-4 text-blue-100 transition-colors duration-150 bg-blue-700 rounded-r-lg focus:shadow-outline hover:bg-blue-800"
                    onClick={(event: React.SyntheticEvent) =>
                      this.submitHandler(event)
                    }
                  >
                    Submit
                  </button>
                </div>
              </div>
            </div>
          </div>
        ) : null}
        {showModalDelete ? (
          <div className="flex justify-center items-center overflow-x-hidden overflow-y-auto fixed inset-0 z-50 outline-none focus:outline-none ">
            <div className="relative w-auto my-6 mx-auto max-w-3xl ">
              <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none">
                <div className="flex items-start justify-between p-5 border-b border-solid border-gray-300 rounded-t ">
                  <h3 className="text-3xl text-gray-900 text-black font-bold">
                    Hapus
                  </h3>
                  <button
                    className="bg-transparent border-0 text-black float-right"
                    onClick={() => this.setShowModalDelete(false)}
                  >
                    <span className="text-black opacity-7 h-6 w-6 text-xl block bg-gray-400 py-0 rounded-full">
                      x
                    </span>
                  </button>
                </div>
                <span className="text-black m-7">
                  Anda Ingin menghapus {lecturer.nama_Dosen}
                </span>
                <div
                  className="flex items-center justify-end p-6 border-t border-solid border-blueGray-200 rounded-b"
                  role="group"
                  aria-label="Button group"
                >
                  <button
                    className="my-8 justify-start h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded-l-lg focus:shadow-outline hover:bg-green-800"
                    onClick={() => this.setShowModalDelete(false)}
                  >
                    Tidak
                  </button>
                  <button
                    className="my-8 justify-start h-8 px-4 text-blue-100 transition-colors duration-150 bg-blue-700 rounded-r-lg focus:shadow-outline hover:bg-blue-800"
                    onClick={(event: React.SyntheticEvent) =>
                      this.submitHandler(event)
                    }
                  >
                    Ya
                  </button>
                </div>
              </div>
            </div>
          </div>
        ) : null}
      </div>
    );
  }
}
