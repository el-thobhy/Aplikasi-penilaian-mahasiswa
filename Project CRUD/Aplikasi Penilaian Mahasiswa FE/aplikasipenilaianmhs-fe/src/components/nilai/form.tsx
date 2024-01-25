import React from "react";
import { ECommand } from "../../enums/eCommand";
import { ModelNilai } from "../../models/modelNilai";
import { ModelMahasiswa } from "../../models/modelMahasiswa";
import { ModelUjian } from "../../models/modelUjian";
import { MahasiswaService } from "../../services/mahasiswaService";
import { UjianService } from "../../services/ujianService";

interface IProps {
  nilai: ModelNilai;
  command: ECommand;
  changeHandler: any;
}

interface IState {
  mahasiswa: ModelMahasiswa[];
  ujian: ModelUjian[];
}

export default class Form extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      mahasiswa: [],
      ujian: [],
    };
  }

  componentDidMount(): void {
    this.loadMahasiswa();
    this.loadUjian();
  }

  loadMahasiswa = async () => {
    const result = await MahasiswaService.getAllMahasiswa();
    if (result.success) {
      this.setState({
        mahasiswa: result.result,
      });
    } else {
      alert("Error: " + result.result);
    }
  };

  loadUjian = async () => {
    const result = await UjianService.getAllUjian();
    if (result.success) {
      this.setState({
        ujian: result.result,
      });
    } else {
      alert("Error: " + result.result);
    }
  };

  render() {
    const { nilai, command, changeHandler } = this.props;
    const { mahasiswa, ujian } = this.state;
    return (
      <>
        <form>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Select Mahasiswa
            </label>
            <select
              id="countries"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              value={nilai.kode_Mahasiswa}
              onChange={changeHandler("kode_Mahasiswa")}
            >
              {/* <option selected value="0">Choose a category</option> */}
              {mahasiswa?.map((o: ModelMahasiswa) => {
                return (
                  <option value={o.kode_Mahasiswa}>{o.nama_Mahasiswa}</option>
                );
              })}
            </select>
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Select Ujian
            </label>
            <select
              id="countries"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              value={nilai.kode_Ujian}
              onChange={changeHandler("kode_Ujian")}
            >
              {/* <option selected value="0">Choose a category</option> */}
              {ujian?.map((o: ModelUjian) => {
                return <option value={o.kode_Ujian}>{o.nama_Ujian}</option>;
              })}
            </select>
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Nilai Mahasiswa
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={nilai.nilaiMahasiswa}
              onChange={changeHandler("nilaiMahasiswa")}
            />
          </div>
        </form>
      </>
    );
  }
}
