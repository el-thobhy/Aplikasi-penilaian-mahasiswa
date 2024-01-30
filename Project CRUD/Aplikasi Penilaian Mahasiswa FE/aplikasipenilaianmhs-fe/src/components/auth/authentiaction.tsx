import React from "react";
import images from "../../assets/LogoProject.png";
import { withRouter } from "../layout/withRouter";
import { ValidationResult } from "../../validations/validationResult";
import { AiOutlineEye } from "react-icons/ai";
import { FcGoogle } from "react-icons/fc";
import { AccountModel } from "../../models/modelAccount";
import { LoginModel } from "../../models/modelLogin";
import { AuthService } from "../../services/authService";

interface IProps {
  logged: boolean;
  changeLoggedHandler: any;
  setShowModal: any;
  navigate: any;
  user: AccountModel;
}
interface IState {
  auth: LoginModel;
  errorAlerts: any;
  message: string;
}

class Authentiaction extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      auth: new LoginModel(),
      errorAlerts: { email: false, password: false },
      message: "",
    };
  }

  changeHandler = (name: string) => (event: any) => {
    this.setState({
      auth: {
        ...this.state.auth,
        [name.toLowerCase()]: event.target.value,
      },
    });
    this.setState({
      errorAlerts: {
        ...this.state.errorAlerts,
        [name]: !event.target.value,
      },
    });
  };

  componentDidMount(): void {
    AuthService.logout();
  }

  handleSubmit = (event: any) => {
    event.preventDefault();
    this.setState({
      errorAlerts: {
        UserName: {
          valid: this.state.auth.username.length > 0,
          message: "Email required",
        },
        Password: {
          valid: this.state.auth.password.length > 0,
          message: "Password required",
        },
      },
    });

    if (
      this.state.auth.username.length === 0 ||
      this.state.auth.password.length === 0
    ) {
      return;
    }

    const { auth } = this.state;
    const { changeLoggedHandler, setShowModal } = this.props;
    AuthService.login(auth)
      .then((result) => {
        if (result.success) {
          changeLoggedHandler(true);
          setShowModal(false);
          this.props.navigate("/");
          console.log(this.props.user);
        } else {
          this.setState({
            errorAlerts: ValidationResult.Validate(result.result),
          });
          console.log(this.state.message);
        }
      })
      .catch((error) => {
        console.log("Error", error);
      });
  };

  render() {
    const { auth, errorAlerts, message } = this.state;
    return (
      <div className="items-center justify-center">
        <div className="max-w-3xl p-5 items-center">
          <div className="ps-8 pe-8 pb-4">
            <form className="flex flex-col gap-4">
              <div>
                <input
                  className="p-3 bg-gray-300 rounded-xl border w-full"
                  type="text"
                  name="email"
                  placeholder="Email"
                  value={auth.username}
                  onChange={this.changeHandler("UserName")}
                  maxLength={100}
                />
                <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                  {!errorAlerts.UserName?.valid ? (
                    <strong id="title-error" role="alert">
                      {errorAlerts.UserName?.message}
                    </strong>
                  ) : null}
                </p>
              </div>

              <div>
                <input
                  className="p-3 rounded-xl bg-gray-300 border  w-full"
                  type="password"
                  name="password"
                  placeholder="Password"
                  required
                  value={auth.password}
                  onChange={this.changeHandler("Password")}
                  maxLength={255}
                />
                <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                  {!errorAlerts.Password?.valid ? (
                    <strong id="title-error" role="alert">
                      {errorAlerts.Password?.message}
                    </strong>
                  ) : null}
                </p>
              </div>

              <button
                onClick={this.handleSubmit}
                className="bg-[#002D74] w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
              >
                Sign In
              </button>
            </form>

            <div className="mt-6 grid grid-cols-3 items-center text-gray-400">
              <hr className="border-gray-400" />
              <p className="text-center text-sm">OR</p>
              <hr className="border-gray-400" />
            </div>

            <div className="min-w-52 mt-5 text-xs border-b border-[#002D74] py-4 text-[#002D74]">
              <a href="#">Forgot your password?</a>
            </div>

            <div className="min-w-52 mt-3 text-xs flex justify-between items-center text-[#002D74]">
              <p className="me-5">Don't have an account?</p>
              <button className="py-2 px-5 bg-white border rounded-xl hover:scale-110 duration-300">
                Register
              </button>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default withRouter(Authentiaction);
