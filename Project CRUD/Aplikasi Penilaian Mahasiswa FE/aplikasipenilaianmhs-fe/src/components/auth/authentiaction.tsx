import React from "react";
import images from "../../assets/LogoProject.png";
import { withRouter } from "../layout/withRouter";
import { ValidationResult } from "../../validations/validationResult";
import { AiOutlineEye } from "react-icons/ai";
import { FcGoogle } from "react-icons/fc";
import { AccountModel } from "../../models/modelAccount";
import { LoginModel } from "../../models/modelLogin";
import { AuthService } from "../../services/authService";
import { ModelForgot } from "../../models/modelForgot";

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
  showForgot: boolean;
  email: string;
  showChangePwd: boolean;
  loading: boolean;
  masukkanOtp: boolean;
  otp: string;
  seconds: number;
}

class Authentiaction extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      auth: new LoginModel(),
      errorAlerts: { email: false, password: false },
      message: "",
      showForgot: false,
      email: "",
      otp: "",
      showChangePwd: false,
      loading: false,
      masukkanOtp: false,
      seconds: 60 * 3,
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
    this.setState({
      email: event.target.value,
    });
    this.setState({
      otp: event.target.value,
    });
  };

  componentDidMount(): void {
    AuthService.logout();
  }

  showModalForgot = (val: boolean) => {
    this.setState({
      showForgot: val,
    });
  };

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

  handleForgot = (event: any) => {
    event.preventDefault();
    this.setState({
      errorAlerts: {
        Email: {
          valid: this.state.email.length > 0,
          message: "Email required",
        },
      },
    });

    if (this.state.email.length === 0) {
      return;
    }
    this.setState({ loading: true });
    const { email } = this.state;
    AuthService.forgot(email)
      .then((result) => {
        if (result.success) {
          this.setState({
            showChangePwd: false,
            showForgot: false,
            loading: false,
            masukkanOtp: true,
            otp: "",
          });
          console.log(result.result.message);
        } else {
          this.setState({
            errorAlerts: ValidationResult.Validate(result.result),
            loading: false,
          });
          console.log(this.state.message);
        }
      })
      .catch((error) => {
        console.log("Error", error);
      });
  };

  handleVerifikasiOtp = (event: any) => {
    event.preventDefault();
    this.setState({
      errorAlerts: {
        Otp: {
          valid: this.state.otp.length > 0 || this.state.otp.length != 0,
          message: "Otp Tidak Boleh Kosong",
        },
      },
    });

    if (this.state.otp.length === 0) {
      return;
    }
    this.setState({ loading: true });
    const { otp } = this.state;
    AuthService.verifikasiOtp(otp)
      .then((result) => {
        if (result.success) {
          this.setState({
            showChangePwd: true,
            showForgot: false,
            loading: false,
            masukkanOtp: false,
          });
          console.log(result.result.message);
        } else {
          this.setState({
            errorAlerts: ValidationResult.Validate(result.result),
            loading: false,
          });
          console.log(this.state.message);
        }
      })
      .catch((error) => {
        console.log("Error", error);
      });
  };

  formatTime = (minutes: number, seconds: number) => {
    const formattedMinutes = String(minutes).padStart(2, "0");
    const formattedSeconds = String(seconds).padStart(2, "0");
    return `${formattedMinutes}:${formattedSeconds}`;
  };

  render() {
    const {
      auth,
      errorAlerts,
      email,
      showForgot,
      showChangePwd,
      masukkanOtp,
      loading,
      otp,
    } = this.state;
    return (
      <div className=" justify-center items-center">
        {loading ? (
          <div className="flex items-center justify-center">
            <h2 className=" text-base w-full flex items-center justify-center font-light text-black">
              Mohon Tunggu ...
            </h2>
          </div>
        ) : null}
        {showForgot || showChangePwd || masukkanOtp ? null : (
          <div className="max-w-3xl p-5 items-center">
            <div className="flex items-center justify-center pb-3">
              <h2 className="text-xl font-bold text-black">SIAK-</h2>
              <h2 className="text-xl font-bold text-blue-600">MHS</h2>
            </div>
            <div className="ps-8 pe-8 pb-4">
              <form className="flex flex-col gap-4">
                <div>
                  <input
                    className="p-3 bg-gray-300 rounded-xl border w-full"
                    type="text"
                    name="username"
                    placeholder="Username"
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

              <div
                onClick={() => this.showModalForgot(true)}
                className="min-w-52 mt-5 text-xs cursor-pointer border-b border-[#002D74] py-4 text-[#002D74]"
              >
                <a href="#">Forgot your password?</a>
              </div>

              <div className="min-w-52 mt-3 text-xs flex justify-between items-center text-[#002D74]">
                <p className="me-5">Don't have an account?</p>
                <button className="py-2 px-5 bg-[#41a546] text-white border rounded-xl hover:scale-110 duration-300">
                  Register
                </button>
              </div>
            </div>
          </div>
        )}

        {showForgot ? (
          <div>
            <div className="max-w-3xl p-5 items-center">
              <div className="flex items-center justify-center pb-3">
                <h2 className="text-xl font-bold text-black">Lupa-</h2>
                <h2 className="text-xl font-bold text-blue-600">Password</h2>
              </div>
              <div className="flex items-center justify-center pb-3">
                <h2 className="text-base font-normal mb-3 text-black">
                  Masukkan E-mail yang terdaftar
                </h2>
              </div>
              <div className="ps-8 pe-8 pb-4">
                <form className="flex flex-col gap-4">
                  <div>
                    <input
                      className="p-3 bg-gray-300 rounded-xl border w-full"
                      type="text"
                      name="email"
                      value={email}
                      placeholder="Email"
                      onChange={this.changeHandler("Email")}
                      maxLength={100}
                    />
                    <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                      {!errorAlerts.Email?.valid ? (
                        <strong id="title-error" role="alert">
                          {errorAlerts.Email?.message}
                        </strong>
                      ) : null}
                    </p>
                  </div>
                  <button
                    onClick={this.handleForgot}
                    className="bg-[#002D74] w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
                  >
                    Kirim OTP
                  </button>
                </form>
              </div>
            </div>
          </div>
        ) : null}

        {showChangePwd ? (
          <div>
            <div className="max-w-3xl p-5 items-center">
              <div className="flex items-center justify-center">
                <h2 className=" text-base w-full mb-3 flex items-center justify-center font-light text-black">
                  Verifikasi Otp berhasil, silahkan ubah password anda
                </h2>
              </div>
              <div className="flex items-center justify-center pb-3">
                <h2 className="text-xl font-bold text-black">Ubah-</h2>
                <h2 className="text-xl font-bold text-blue-600">Password</h2>
              </div>
              <div className="ps-8 pe-8 pb-4">
                <form className="flex flex-col gap-4">
                  <div>
                    <input
                      className="p-3 bg-gray-300 rounded-xl border w-full"
                      type="text"
                      name="password"
                      // value={email}
                      placeholder="New Password"
                      onChange={this.changeHandler("Password")}
                      maxLength={100}
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
                    // onClick={this.handleForgot}
                    className="bg-[#002D74] w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
                  >
                    Ubah Password
                  </button>
                </form>
              </div>
            </div>
          </div>
        ) : null}
        {masukkanOtp ? (
          <div>
            <div className="max-w-3xl p-5 items-center">
              {loading ? null : (
                <div className="flex items-center justify-center">
                  <h2 className=" text-base w-full flex mb-3 items-center justify-center font-light text-black">
                    OTP Berhasil dikirim, silahkan masukkan Otp
                  </h2>
                </div>
              )}
              <div className="flex items-center justify-center pb-3">
                <h2 className="text-xl font-bold text-black">Verifikasi-</h2>
                <h2 className="text-xl font-bold text-blue-600">OTP</h2>
              </div>
              <div className="ps-8 pe-8 pb-4">
                <form className="flex flex-col gap-4">
                  <div>
                    <input
                      className="p-3 bg-gray-300 rounded-xl border w-full"
                      type="text"
                      name="otp"
                      value={otp}
                      placeholder="Masukkan OTP"
                      onChange={this.changeHandler("Otp")}
                      maxLength={100}
                    />
                    <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                      {!errorAlerts.Otp?.valid ? (
                        <strong id="title-error" role="alert">
                          {errorAlerts.Otp?.message}
                        </strong>
                      ) : null}
                    </p>
                  </div>
                  <button
                    onClick={this.handleVerifikasiOtp}
                    className="bg-[#002D74] w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
                  >
                    Verifikasi
                  </button>
                  <div className="flex items-center justify-center">
                    <h2
                      onClick={this.handleForgot}
                      className="cursor-pointer text-sm w-full flex mb-3 items-center justify-center font-light text-black"
                    >
                      Kirim Ulang :
                    </h2>
                    <h2 className=" text-sm w-full flex mb-3 items-center justify-center font-light text-black"></h2>
                  </div>
                </form>
              </div>
            </div>
          </div>
        ) : null}
      </div>
    );
  }
}

export default withRouter(Authentiaction);
