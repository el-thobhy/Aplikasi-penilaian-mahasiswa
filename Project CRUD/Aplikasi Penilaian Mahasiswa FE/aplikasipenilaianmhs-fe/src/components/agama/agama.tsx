import React from "react";
import { config } from "../../configurations/config";
import { ECommand } from "../../enums/eCommand";
import { ModelAgama } from "../../models/modelAgama";
import { ModelPagination } from "../../models/modelPagination";
import { AgamaService } from "../../services/agamaService";

interface IProps {}
interface IState {
  agama: ModelAgama[];
  pagination: ModelPagination;
  showModal: boolean;
  command: ECommand;
}

export default class Agama extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      agama: [],
      showModal: false,
      command: ECommand.create,
      pagination: new ModelPagination(),
    };
  }
  componentDidMount(): void {
    this.loadAgama();
  }

  loadAgama = async () => {
    const { pagination } = this.state;
    const result = await AgamaService.getAll(pagination);
    if (result.success) {
      this.setState({
        agama: result.result,
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
      agama: [],
      command: ECommand.create,
    });
    // this.setShowModal(true);
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
        this.loadAgama();
      }, 500);
    });
  };

  render() {
    const { agama, pagination } = this.state;
    const loopPages = () => {
      let content: any = [];
      for (let page = 1; page <= pagination.pages; page++) {
        content.push(<option value={page}>{page}</option>);
      }
      return content;
    };
    return (
      <div>
        <div className="text-left text-3xl pt-5">Agama</div>
        <span>{JSON.stringify(pagination)}</span>
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
                  onClick={() => this.loadAgama()}
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
            </tr>
            <tr className="border-b dark:bg-gray-900 dark:border-gray-700">
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Kode Agama
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Deskripsi
              </th>
              <th scope="col" className="px-6 py-3 w-14 h-14">
                Action
              </th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {agama?.map((cat: ModelAgama) => {
              return (
                <tr
                  key={cat.kode_Agama}
                  className="border-b dark:bg-gray-800 dark:border-gray-700"
                >
                  <td className="px-6 py-4">{cat.kode_Agama}</td>
                  <td className="px-6 py-4">{cat.deskripsi}</td>
                  <td className="px-4 py-4">
                    <div
                      className="inline-flex"
                      role="group"
                      aria-label="Button group"
                    >
                      <button
                        className="h-8 px-4 text-green-100 transition-colors duration-150 bg-green-700 rounded-l-lg focus:shadow-outline hover:bg-green-800"
                        // onClick={() => this.updateCommand(cat.id)}
                      >
                        Edit
                      </button>
                      <button
                        className="h-8 px-4 text-blue-100 transition-colors duration-150 bg-blue-700 rounded-r-lg focus:shadow-outline hover:bg-blue-800"
                        // onClick={() => this.changeStatusCommand(cat.id)}
                      >
                        Status
                      </button>
                    </div>
                  </td>
                  <td></td>
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
            </tr>
          </tfoot>
        </table>
      </div>
    );
  }
}
