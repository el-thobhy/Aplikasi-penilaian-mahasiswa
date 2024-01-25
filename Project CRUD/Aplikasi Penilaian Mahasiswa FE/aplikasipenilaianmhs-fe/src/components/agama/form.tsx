import React from "react";
import { ECommand } from "../../enums/eCommand";
import { ModelAgama } from "../../models/modelAgama";

interface IProps {
  agama: ModelAgama;
  command: ECommand;
  changeHandler: any;
}

interface IState {}

export default class Form extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
  }

  render() {
    const { agama, command, changeHandler } = this.props;
    return (
      <>
        <form>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Kode Agama
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="initial"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={agama.kode_Agama}
              onChange={changeHandler("kode_Agama")}
            />
          </div>
          <div className="mb-6">
            <label className="block mb-2 text-sm font-medium text-gray-900 dark:text-white">
              Deskripsi
            </label>
            <input
              readOnly={command == ECommand.changeStatus}
              type="text"
              id="name"
              className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              required
              value={agama.deskripsi}
              onChange={changeHandler("deskripsi")}
            />
          </div>
        </form>
      </>
    );
  }
}
