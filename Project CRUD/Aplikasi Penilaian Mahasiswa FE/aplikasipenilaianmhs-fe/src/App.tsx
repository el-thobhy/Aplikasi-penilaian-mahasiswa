import "./App.css";
import { BrowserRouter } from "react-router-dom";
import SideBar from "./components/layout/sideBar";
import { AccountModel } from "./models/modelAccount";
import React from "react";
import { AuthService } from "./services/authService";

interface IProps {}

interface IState {
  logged: boolean;
  user: AccountModel;
}

export default class App extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      logged: false,
      user: new AccountModel(),
    };
  }

  componentDidMount = async () => {
    await this.setState({
      logged: AuthService.getToken() ? true : false,
      user: AuthService.getAccount(),
    });
  };

  handleChangeStatus = (val: boolean) => {
    this.setState({
      logged: val,
      user: val ? AuthService.getAccount() : new AccountModel(),
    });
  };

  render() {
    return (
      <BrowserRouter>
        <SideBar
          user={this.state.user}
          logged={this.state.logged}
          changeLoggedHandler={this.handleChangeStatus}
        />
      </BrowserRouter>
    );
  }
}
