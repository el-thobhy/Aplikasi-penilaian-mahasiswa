import React from "react";
import { ECommand } from "../../enums/eCommand";
import { ModelMahasiswa } from "../../models/modelMahasiswa";
import { ModelAgama } from "../../models/modelAgama";
import { AgamaService } from "../../services/agamaService";
import { ModelJurusan } from "../../models/modelJurusan";
import { Jurusan } from "../jurusan";
import { JurusanService } from "../../services/jurusanService";

interface IProps {
  mahasiswa: ModelMahasiswa;
  command: ECommand;
  changeHandler: any;
}

interface IState {
  agamas: ModelAgama[];
  jurusans: ModelJurusan[];
}

export default class Form extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      agamas: [],
      jurusans: [],
    };
  }

  componentDidMount(): void {
    this.loadAgamas();
    this.loadJurusan();
  }

  loadAgamas = async () => {
    const result = await AgamaService.getAllAgama();
    if (result.success) {
      this.setState({
        agamas: result.result,
      });
    } else {
      alert("Error: " + result.result);
    }
  };
  loadJurusan = async () => {
    const result = await JurusanService.getAllJurusan();
    if (result.success) {
      this.setState({
        jurusans: result.result,
      });
    } else {
      alert("Error: " + result.result);
    }
  };

  render() {
    const { mahasiswa, command, changeHandler } = this.props;
    const { agamas, jurusans } = this.state;
    return (
      <>
        <form>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Kode Mahasiswa
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="initial"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={mahasiswa.kode_Mahasiswa}
              onChange={changeHandler("kode_Mahasiswa")}
            />
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Nama Mahasiswa
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={mahasiswa.nama_Mahasiswa}
              onChange={changeHandler("nama_Mahasiswa")}
            />
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Alamat Mahasiswa
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={mahasiswa.alamat}
              onChange={changeHandler("alamat")}
            />
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Select Agama
            </label>
            <select
              id="countries"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              value={mahasiswa.kode_Agama}
              onChange={changeHandler("kode_Agama")}
            >
              {/* <option selected value="0">Choose a category</option> */}
              {agamas?.map((o: ModelAgama) => {
                return <option value={o.kode_Agama}>{o.deskripsi}</option>;
              })}
            </select>
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Select Jurusa
            </label>
            <select
              id="countries"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              value={mahasiswa.kode_Jurusan}
              onChange={changeHandler("kode_Jurusan")}
            >
              {/* <option selected value="0">Choose a category</option> */}
              {jurusans?.map((o: ModelJurusan) => {
                return <option value={o.kode_Jurusan}>{o.nama_Jurusan}</option>;
              })}
            </select>
          </div>
        </form>
      </>
    );
  }
}
