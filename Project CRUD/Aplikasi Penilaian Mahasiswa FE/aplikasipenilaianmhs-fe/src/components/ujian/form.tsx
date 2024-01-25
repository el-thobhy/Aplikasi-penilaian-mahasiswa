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
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Nama Ujian
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={ujian.nama_Ujian}
              onChange={changeHandler("nama_Ujian")}
            />
            {!errorAlerts.nama_Ujian?.nama ? (
              <strong
                className="text-red-600 text-xs font-normal"
                id="title-error"
                role="alert"
              >
                {errorAlerts.nama_Ujian?.message_nama}
              </strong>
            ) : null}
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Status Ujian
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={ujian.status_Ujian}
              onChange={changeHandler("status_Ujian")}
            />
            {!errorAlerts.status_Ujian?.status ? (
              <strong
                className="text-red-600 text-xs font-normal"
                id="title-error"
                role="alert"
              >
                {errorAlerts.status_Ujian?.message_status}
              </strong>
            ) : null}
          </div>
        </form>
      </>
    );
  }
}