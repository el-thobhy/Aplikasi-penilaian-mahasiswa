import React from "react";
import SideBar from "./sideBar";
import { AccountModel } from "../../models/modelAccount";
import { config } from "../../configurations/config";

interface IProps {
  logged: boolean;
  account: AccountModel;
}

interface IState {}

export default class Header extends React.Component<IProps, IState> {
  render() {
    const { account, logged } = this.props;
    return (
      <header>
        <nav className="bg-white border-gray-200 lg:px-6 py-2  border-b border-solid border-gray-600 pb-3">
          <div className="flex flex-wrap justify-between items-center">
            <div className="flex w-full items-center justify-end flex-shrink-0">
              {logged ? (
                <h2 className="text-black p-3 items-center justify-center ps-3 pb-2">
                  {account.firstName}
                </h2>
              ) : null}
            </div>
          </div>
        </nav>
      </header>
    );
  }
}
