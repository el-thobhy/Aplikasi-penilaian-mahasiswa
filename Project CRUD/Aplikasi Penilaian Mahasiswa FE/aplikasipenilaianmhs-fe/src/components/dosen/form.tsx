import React from "react";
import { ECommand } from "../../enums/eCommand";
import { ModelDosen } from "../../models/modelDosen";
import { ModelAgama } from "../../models/modelAgama";
import { AgamaService } from "../../services/agamaService";
import { ModelJurusan } from "../../models/modelJurusan";
import { Jurusan } from "../jurusan";
import { JurusanService } from "../../services/jurusanService";
import { ModelTypeDosen } from "../../models/modelTypeDosen";
import { TypeDosenService } from "../../services/typeDosenService";

interface IProps {
  dosen: ModelDosen;
  command: ECommand;
  changeHandler: any;
}

interface IState {
  typeDosens: ModelTypeDosen[];
  jurusans: ModelJurusan[];
}

export default class Form extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      typeDosens: [],
      jurusans: [],
    };
  }

  componentDidMount(): void {
    this.loadTypeDosen();
    this.loadJurusan();
  }

  loadTypeDosen = async () => {
    const result = await TypeDosenService.getAllTypeDosen();
    if (result.success) {
      this.setState({
        typeDosens: result.result,
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
    const { dosen, command, changeHandler } = this.props;
    const { typeDosens, jurusans } = this.state;
    return (
      <>
        <form>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Kode Dosen
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="initial"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={dosen.kode_Dosen}
              onChange={changeHandler("kode_Dosen")}
            />
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Nama Dosen
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={dosen.nama_Dosen}
              onChange={changeHandler("nama_Dosen")}
            />
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Select Jurusan
            </label>
            <select
              id="countries"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              value={dosen.kode_Jurusan}
              onChange={changeHandler("kode_Jurusan")}
            >
              {/* <option selected value="0">Choose a category</option> */}
              {jurusans?.map((o: ModelJurusan) => {
                return <option value={o.kode_Jurusan}>{o.nama_Jurusan}</option>;
              })}
            </select>
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Select Type Dosen
            </label>
            <select
              id="countries"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              value={dosen.kode_Type_Dosen}
              onChange={changeHandler("kode_Type_Dosen")}
            >
              {/* <option selected value="0">Choose a category</option> */}
              {typeDosens?.map((o: ModelTypeDosen) => {
                return <option value={o.kode_Type_Dosen}>{o.deskripsi}</option>;
              })}
            </select>
          </div>
        </form>
      </>
    );
  }
}
