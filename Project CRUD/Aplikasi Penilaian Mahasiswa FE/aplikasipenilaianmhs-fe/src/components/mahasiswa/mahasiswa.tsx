import React from "react";
import { ModelMahasiswa } from "../../models/modelMahasiswa";
import { ECommand } from "../../enums/eCommand";
import { ModelPagination } from "../../models/modelPagination";
import { config } from "../../configurations/config";
import { MahasiswaService } from "../../services/mahasiswaService";
import Form from "./form";

interface IProps {}
interface IState {
  mahasiswa: ModelMahasiswa[];
  student: ModelMahasiswa;
  pagination: ModelPagination;
  showModal: boolean;
  showModalDelete: boolean;
  command: ECommand;
}

export default class Mahasiswa extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      mahasiswa: [],
      student: new ModelMahasiswa(),
      showModal: false,
      showModalDelete: false,
      command: ECommand.create,
      pagination: new ModelPagination(),
    };
  }
  componentDidMount(): void {
    this.loadMahasiswa();
  }

  loadMahasiswa = async () => {
    const { pagination } = this.state;
    const result = await MahasiswaService.getAll(pagination);
    if (result.success) {
      this.setState({
        mahasiswa: result.result,
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
      student: new ModelMahasiswa(),
      command: ECommand.create,
    });
    // this.setShowModal(true);
  };
  deleteCommand = async (id: number) => {
    await MahasiswaService.getById(id)
      .then((result) => {
        if (result.success) {
          this.setState({
            showModalDelete: true,
            student: result.result,
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
        this.loadMahasiswa();
      }, 500);
    });
  };

  updateCommand = async (id: number) => {
    await MahasiswaService.getById(id)
      .then((result) => {
        if (result.success) {
          this.setState({
            showModal: true,
            student: result.result,
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
    });
  };

  changeHandler = (name: any) => (event: any) => {
    this.setState({
      student: {
        ...this.state.student,
        [name]: event.target.value,
      },
    });
  };

  submitHandler = async () => {
    const { command, student } = this.state;
    if (command == ECommand.create) {
      await MahasiswaService.post(this.state.student)
        .then((result) => {
          if (result.success) {
            this.setState({
              showModal: false,
              student: new ModelMahasiswa(),
            });
            this.loadMahasiswa();
          } else {
            alert("Error result " + result.result);
          }
        })
        .catch((error) => {
          alert("Error error" + error);
        });
    } else if (command == ECommand.edit) {
      await MahasiswaService.update(student.id, student)
        .then((result) => {
          if (result.success) {
            this.setState({
              showModal: false,
              student: new ModelMahasiswa(),
            });
            this.loadMahasiswa();
          } else {
            alert("Error result " + result.result);
          }
        })
        .catch((error) => {
          alert("Error error" + error);
        });
    } else if (command == ECommand.changeStatus) {
      await MahasiswaService.changeStatus(student.id, true)
        .then((result) => {
          if (result.success) {
            this.setState({
              showModalDelete: false,
              student: new ModelMahasiswa(),
            });
            this.loadMahasiswa();
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
      mahasiswa,
      pagination,
      student,
      showModal,
      command,
      showModalDelete,
    } = this.state;
    const loopPages = () => {
      let content: any = [];
      for (let page = 1; page <= pagination.pages; page++) {
        content.push(<option value={page}>{page}</option>);
      }
      return content;
    };
    return (
      <div className="overflow-auto h-screen">
        <div className="text-left text-3xl pt-5">Mahasiswa</div>
        <div className="flex" aria-label="Button">
          <button
            className="my-8 justify-start h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded focus:shadow-outline hover:bg-green-800"
            onClick={() => this.createCommand()}
          >
            Create New
          </button>
        </div>
        <table className="w-full text-sm text-left text-gray-500 dark:text-gray-400">
          <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
            <tr className="border-b dark:bg-gray-900 dark:border-gray-700">
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Search:
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                <input
                  type="text"
                  id="search"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  required
                  value={pagination.search}
                  onChange={this.changeSearch("search")}
                />
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                <button
                  className="my-8 justify-start h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded focus:shadow-outline hover:bg-green-800"
                  onClick={() => this.loadMahasiswa()}
                >
                  Filter
                </button>
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                <select
                  id="countries"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  onChange={this.changeRowsPerPage("sort")}
                >
                  <option value="0">Asc</option>
                  <option value="1">Desc</option>
                </select>
              </th>
              <th></th>
              <th></th>
            </tr>
            <tr className="border-b dark:bg-gray-900 dark:border-gray-700">
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Kode Mahasiswa
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Nama Mahasiswa
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Alamat Mahasiswa
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Agama
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Jurusan
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Action
              </th>
            </tr>
          </thead>
          <tbody>
            {mahasiswa?.map((cat: ModelMahasiswa) => {
              return (
                <tr
                  key={cat.id}
                  className="border-b dark:bg-gray-800 dark:border-gray-700"
                >
                  <td className="px-6 py-4">{cat.kode_Mahasiswa}</td>
                  <td className="px-6 py-4">{cat.nama_Mahasiswa}</td>
                  <td className="px-6 py-4">{cat.alamat}</td>
                  <td className="px-6 py-4">{cat.agama.deskripsi}</td>
                  <td className="px-6 py-4">{cat.jurusan.nama_Jurusan}</td>
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
              <th scope="col" className="px-6 py-3 w-14 h-14">
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
              <th scope="col" className="px-6 py-3 w-14 h-14">
                <select
                  id="countries"
                  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  onChange={this.changeRowsPerPage("pageNum")}
                >
                  {loopPages()}
                </select>
              </th>
              <th></th>
              <th></th>
            </tr>
          </tfoot>
        </table>
        {showModal ? (
          <div className="flex justify-center items-center overflow-x-hidden overflow-y-auto fixed inset-0 z-50 outline-none focus:outline-none ">
            <div className="relative w-auto my-6 mx-auto max-w-3xl ">
              <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none dark:bg-gray-900">
                <div className="flex items-start justify-between p-5 border-b border-solid border-gray-300 rounded-t ">
                  <h3 className="text-3xl text-gray-900 dark:text-white">
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
                <div className="relative p-6 flex-auto">
                  <Form
                    mahasiswa={student}
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
                    onClick={() => this.submitHandler()}
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
              <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none dark:bg-gray-900">
                <div className="flex items-start justify-between p-5 border-b border-solid border-gray-300 rounded-t ">
                  <h3 className="text-3xl text-gray-900 dark:text-white">
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
                <span className="text-white m-7">
                  Anda Ingin menghapus {student.nama_Mahasiswa}
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
                    onClick={() => this.submitHandler()}
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
