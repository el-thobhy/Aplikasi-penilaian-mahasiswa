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
  timerInterval: any;
  kirimUlang: boolean;
  newPassword: string;
  ulangiPassword: string;
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
      timerInterval: null,
      kirimUlang: false,
      newPassword: "",
      ulangiPassword: "",
    };
  }

  handleResendOtp = () => {
    // Reset the timer
    this.resetTimer();

    // Add logic to resend OTP here (similar to handleForgot method)
  };

  startTimer = () => {
    clearInterval(this.state.timerInterval);
    const timerInterval = setInterval(() => {
      if (this.state.seconds > 0) {
        this.setState({ seconds: this.state.seconds - 1, kirimUlang: false });
      } else {
        // Timer reached 0, handle what you need to do here
        clearInterval(this.state.timerInterval);
        this.setState({
          kirimUlang: true,
        });
      }
    }, 1000);

    this.setState({ timerInterval });
  };

  resetTimer = () => {
    clearInterval(this.state.timerInterval);
    this.setState({ seconds: 180 }); // Reset timer to 3 minutes
    this.startTimer(); // Start the timer again
  };
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
    if (name === "NewPassword") {
      this.setState({
        newPassword: event.target.value,
      });
    }
    if (name === "UlangiPassword") {
      this.setState({
        ulangiPassword: event.target.value,
      });
    }
  };

  componentDidMount(): void {
    AuthService.logout();
  }
  componentWillUnmount(): void {
    clearInterval(this.state.timerInterval); // Clear the timer interval when the component unmounts
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
          this.handleResendOtp();
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

  handleGantiPassword = (event: any) => {
    event.preventDefault();
    this.setState({
      errorAlerts: {
        NewPassword: {
          valid:
            this.state.newPassword.length > 0 ||
            this.state.newPassword.length != 0,
          message: "Password Baru Tidak Boleh Kosong",
        },
        UlangiPassword: {
          valid:
            this.state.ulangiPassword.length > 0 ||
            this.state.ulangiPassword.length != 0,
          message: "Ulangi Password Tidak Boleh Kosong",
        },
        MatchPassword: {
          valid: this.state.ulangiPassword === this.state.newPassword,
          message: "Ulangi Password Harus sama dengan password baru",
        },
        CheckLengthPassword: {
          valid: this.state.newPassword.length >= 8,
          message: "Password Harus 8 karakter atau lebih",
        },
      },
    });

    if (this.state.newPassword.length === 0) {
      return;
    }
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
      kirimUlang,
      seconds,
      newPassword,
      ulangiPassword,
    } = this.state;

    const minutes = Math.floor(seconds / 60);
    const remainingSeconds = seconds % 60;
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
                      type="password"
                      name="password"
                      value={newPassword}
                      placeholder="New Password"
                      onChange={this.changeHandler("NewPassword")}
                      maxLength={100}
                    />
                    <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                      {newPassword.length > 0 ? (
                        !errorAlerts.CheckLengthPassword?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.CheckLengthPassword?.message}
                          </strong>
                        ) : null
                      ) : !errorAlerts.NewPassword?.valid ? (
                        <strong id="title-error" role="alert">
                          {errorAlerts.NewPassword?.message}
                        </strong>
                      ) : null}
                    </p>
                  </div>
                  <div>
                    <input
                      className="p-3 bg-gray-300 rounded-xl border w-full"
                      type="password"
                      name="ulangi password"
                      value={ulangiPassword}
                      placeholder="Ulangi Password"
                      onChange={this.changeHandler("UlangiPassword")}
                      maxLength={100}
                    />
                    <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                      {ulangiPassword.length > 0 ? (
                        !errorAlerts.MatchPassword?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.MatchPassword?.message}
                          </strong>
                        ) : null
                      ) : !errorAlerts.UlangiPassword?.valid ? (
                        <strong id="title-error" role="alert">
                          {errorAlerts.UlangiPassword?.message}
                        </strong>
                      ) : null}
                    </p>
                  </div>
                  <button
                    onClick={this.handleGantiPassword}
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
                    {kirimUlang ? (
                      <h2
                        onClick={this.handleForgot}
                        className="cursor-pointer text-sm w-full flex mb-3 items-center justify-center font-light text-black"
                      >
                        Kirim Ulang :
                      </h2>
                    ) : null}

                    <h2 className=" text-sm w-full flex mb-3 items-center justify-center font-light text-black">{`${
                      minutes < 10 ? "0" : ""
                    }${minutes}:${
                      remainingSeconds < 10 ? "0" : ""
                    }${remainingSeconds}`}</h2>
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
