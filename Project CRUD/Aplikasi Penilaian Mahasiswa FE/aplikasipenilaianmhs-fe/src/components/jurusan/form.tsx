import React from "react";
import { ECommand } from "../../enums/eCommand";
import { ModelJurusan } from "../../models/modelJurusan";

interface IProps {
  jurusan: ModelJurusan;
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
    const { jurusan, command, changeHandler, errorAlerts } = this.props;
    return (
      <>
        <form>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 text-black">
              Nama Jurusan
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-200 dark:placeholder-gray-400 text-black dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={jurusan.nama_Jurusan}
              onChange={changeHandler("nama_Jurusan")}
            />
            {!errorAlerts.nama_Jurusan?.valid ? (
              <strong
                className="text-red-600 text-xs font-normal"
                id="title-error"
                role="alert"
              >
                {errorAlerts.nama_Jurusan?.message}
              </strong>
            ) : null}
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 text-black">
              Select Jurusan
            </label>
            <select
              id="countries"
              value={jurusan.status_Jurusan}
              className="bg-gray-200 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:placeholder-gray-400 text-black dark:focus:ring-blue-500 dark:focus:border-blue-500"
              onChange={changeHandler("status_Jurusan")}
            >
              <option selected value="">
                Pilih Status
              </option>
              <option value="Aktif">Aktif</option>
              <option value="Non Aktif">Non Aktif</option>
            </select>
            {!errorAlerts.status_Jurusan?.valid ? (
              <strong
                className="text-red-600 text-xs font-normal"
                id="title-error"
                role="alert"
              >
                {errorAlerts.status_Jurusan?.message}
              </strong>
            ) : null}
          </div>
        </form>
      </>
    );
  }
}
