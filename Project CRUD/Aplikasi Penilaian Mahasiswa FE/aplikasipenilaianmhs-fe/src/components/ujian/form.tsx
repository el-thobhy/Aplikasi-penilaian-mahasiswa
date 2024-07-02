import React from "react";
import { ECommand } from "../../enums/eCommand";
import { ModelUjian } from "../../models/modelUjian";

interface IProps {
  ujian: ModelUjian;
  command: ECommand;
  changeHandler: any;
  errorAlerts: any;
}

interface IState {}

export default class Form extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
  }

  render() {
    const { ujian, command, changeHandler, errorAlerts } = this.props;
    return (
      <>
        <form>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 text-black">
              Nama Ujian
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-200 dark:placeholder-gray-400 text-black dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={ujian.nama_Ujian}
              onChange={changeHandler("nama_Ujian")}
            />
            {!errorAlerts.nama_Ujian?.valid ? (
              <strong
                className="text-red-600 text-xs font-normal"
                id="title-error"
                role="alert"
              >
                {errorAlerts.nama_Ujian?.message}
              </strong>
            ) : null}
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 text-black"></label>
            <select
              id="countries"
              value={ujian.status_Ujian}
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-200 dark:placeholder-gray-400 text-black dark:focus:ring-blue-500 dark:focus:border-blue-500"
              onChange={changeHandler("status_Ujian")}
            >
              <option selected value="">
                Pilih Status
              </option>
              <option value="Aktif">Aktif</option>
              <option value="Non Aktif">Non Aktif</option>
            </select>
            {!errorAlerts.status_Ujian?.valid ? (
              <strong
                className="text-red-600 text-xs font-normal"
                id="title-error"
                role="alert"
              >
                {errorAlerts.status_Ujian?.message}
              </strong>
            ) : null}
          </div>
        </form>
      </>
    );
  }
}
