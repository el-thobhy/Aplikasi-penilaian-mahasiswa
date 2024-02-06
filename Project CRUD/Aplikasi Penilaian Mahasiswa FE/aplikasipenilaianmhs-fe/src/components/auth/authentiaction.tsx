import React from "react";
import images from "../../assets/LogoProject.png";
import { withRouter } from "../layout/withRouter";
import { ValidationResult } from "../../validations/validationResult";
import {
  AiOutlineArrowLeft,
  AiOutlineClose,
  AiOutlineEye,
} from "react-icons/ai";
import { FcGoogle } from "react-icons/fc";
import { AccountModel } from "../../models/modelAccount";
import { LoginModel } from "../../models/modelLogin";
import { AuthService } from "../../services/authService";
import { ModelForgot } from "../../models/modelForgot";
import { ModelRegistrasi } from "../../models/modelRegistration";

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
  berhasilUbah: boolean;
  userName: string;
  register: boolean;
  isInputRegis: boolean;
  back: boolean;
  modelRegistrasi: ModelRegistrasi;
  inputRegis: boolean;
  berhasilDaftar: boolean;
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
      berhasilUbah: false,
      userName: "",
      register: false,
      back: false,
      isInputRegis: false,
      modelRegistrasi: new ModelRegistrasi(),
      inputRegis: false,
      berhasilDaftar: false,
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
    if (name === "Email") {
      this.setState({
        email: event.target.value,
      });
    }
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
    if (name === "UserName") {
      this.setState({
        modelRegistrasi: {
          ...this.state.modelRegistrasi,
          userName: event.target.value,
        },
      });
    }
    if (name === "FirstName") {
      this.setState({
        modelRegistrasi: {
          ...this.state.modelRegistrasi,
          firstName: event.target.value,
        },
      });
    }
    if (name === "LastName") {
      this.setState({
        modelRegistrasi: {
          ...this.state.modelRegistrasi,
          lastName: event.target.value,
        },
      });
    }
    if (name === "PwdAccount") {
      this.setState({
        modelRegistrasi: {
          ...this.state.modelRegistrasi,
          password: event.target.value,
        },
      });
    }
    if (name === "UlangiPwdAccount") {
      this.setState({
        ulangiPassword: event.target.value,
      });
    }
    if (name === "Role") {
      this.setState({
        modelRegistrasi: {
          ...this.state.modelRegistrasi,
          roleGroupId: event.target.value,
        },
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
      back: true,
      isInputRegis: false,
      email: "",
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

  handleKirimOtp = (event: any, regis: boolean) => {
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
    AuthService.kirimOtp(regis, email)
      .then((result) => {
        if (result.success) {
          this.setState({
            showChangePwd: false,
            showForgot: false,
            loading: false,
            masukkanOtp: true,
            register: false,
            back: true,
            otp: "",
            berhasilUbah: false,
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
    const { otp, isInputRegis } = this.state;
    AuthService.verifikasiOtp(otp)
      .then((result) => {
        if (result.success) {
          this.setState({
            showChangePwd: isInputRegis ? false : true,
            showForgot: false,
            loading: false,
            masukkanOtp: false,
            otp: "",
            berhasilUbah: false,
            userName: result.result.userName,
          });
          console.log(result.result.message);
          if (isInputRegis) {
            this.setState({
              inputRegis: true,
              modelRegistrasi: {
                ...this.state.modelRegistrasi,
                id: result.result.id,
              },
              ulangiPassword: "",
            });
          }
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

  handleGantiPassword = async (event: any) => {
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

    if (
      this.state.newPassword.length === 0 ||
      this.state.ulangiPassword.length === 0 ||
      this.state.ulangiPassword !== this.state.newPassword ||
      this.state.newPassword.length < 8
    ) {
      return;
    }

    await AuthService.ubahPassword(this.state.userName, this.state.newPassword)
      .then((result) => {
        if (result.success) {
          this.setState({
            showChangePwd: false,
            showForgot: false,
            loading: false,
            masukkanOtp: false,
            berhasilUbah: true,
          });
        } else {
          console.log(result.result);
          this.setState({
            berhasilUbah: false,
          });
        }
      })
      .catch((error) => {
        console.log("Error", error);
      });
  };

  registerClicked = () => {
    this.setState({
      isInputRegis: true,
      register: true,
      back: true,
      email: "",
    });
  };

  arrowLeftClicker = () => {
    this.setState({
      register: false,
      showForgot: false,
      masukkanOtp: false,
      showChangePwd: false,
      berhasilUbah: false,
      inputRegis: false,
      back: false,
    });
  };

  handleRegister = async (event: any) => {
    event.preventDefault();
    this.setState({
      errorAlerts: {
        UserName: {
          valid: this.state.modelRegistrasi.userName.length > 0,
          message: "Username required",
        },
        FirstName: {
          valid: this.state.modelRegistrasi.firstName.length > 0,
          message: "FirstName required",
        },
        LastName: {
          valid: this.state.modelRegistrasi.lastName.length > 0,
          message: "LastName required",
        },
        PwdAccount: {
          valid: this.state.modelRegistrasi.password.length > 0,
          message: "Password required",
        },
        UlangiPwdAccount: {
          valid: this.state.ulangiPassword.length > 0,
          message: "Ulangi Password required",
        },
        Role: {
          valid: this.state.modelRegistrasi.roleGroupId > 0,
          message: "Role required",
        },
        MatchPassword: {
          valid:
            this.state.modelRegistrasi.password === this.state.ulangiPassword,
          message: "Ulangi Password Harus sama dengan password baru",
        },
        CheckLengthPassword: {
          valid: this.state.modelRegistrasi.password.length >= 8,
          message: "Password Harus 8 karakter atau lebih",
        },
      },
    });

    if (
      this.state.modelRegistrasi.password.length === 0 ||
      this.state.modelRegistrasi.userName.length === 0 ||
      this.state.modelRegistrasi.firstName.length === 0 ||
      this.state.modelRegistrasi.lastName.length === 0 ||
      this.state.modelRegistrasi.roleGroupId === 0 ||
      this.state.modelRegistrasi.password !== this.state.ulangiPassword ||
      this.state.modelRegistrasi.password.length < 8
    ) {
      return;
    }

    const { modelRegistrasi, email } = this.state;
    this.setState({
      modelRegistrasi: {
        ...this.state.modelRegistrasi,
        email: email,
      },
    });
    await AuthService.registration(modelRegistrasi)
      .then((result) => {
        if (result.success) {
          this.setState({
            showChangePwd: false,
            inputRegis: false,
            showForgot: false,
            loading: false,
            masukkanOtp: false,
            register: false,
            back: false,
            otp: "",
            berhasilUbah: false,
            berhasilDaftar: true,
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
      berhasilUbah,
      register,
      back,
      modelRegistrasi,
      inputRegis,
      berhasilDaftar,
    } = this.state;

    const minutes = Math.floor(seconds / 60);
    const remainingSeconds = seconds % 60;
    return (
      <div className="justify-center items-center">
        {back ? (
          <button onClick={this.arrowLeftClicker}>
            <AiOutlineArrowLeft className="justify-center text-black text-3xl" />
          </button>
        ) : (
          <button onClick={() => this.props.setShowModal(false)}>
            <AiOutlineClose className="justify-center text-black text-3xl" />
          </button>
        )}

        {loading ? (
          <div className="flex items-center justify-center">
            <h2 className=" text-base w-full flex items-center justify-center font-light text-black">
              Mohon Tunggu ...
            </h2>
          </div>
        ) : null}

        {berhasilUbah ? (
          <h2 className=" text-base w-full flex mb-3 items-center justify-center font-light text-black">
            Berhasil Ubah Password, Silakan Login kembali
          </h2>
        ) : null}

        {berhasilDaftar ? (
          <h2 className=" text-base w-full flex mb-3 items-center justify-center font-light text-black">
            Berhasil Daftar, Silakan Login kembali
          </h2>
        ) : null}

        {showForgot ||
        showChangePwd ||
        masukkanOtp ||
        register ||
        inputRegis ? null : (
          <div>
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
                  <button
                    onClick={this.registerClicked}
                    className="py-2 px-5 bg-[#41a546] text-white border rounded-xl hover:scale-110 duration-300"
                  >
                    Register
                  </button>
                </div>
              </div>
            </div>
          </div>
        )}

        {register || showForgot ? (
          <div>
            <div className="max-w-3xl p-5 items-center">
              {register ? (
                <div>
                  <div className="flex items-center justify-center pb-3">
                    <h2 className="text-xl font-bold text-black">Daftar-</h2>
                    <h2 className="text-xl font-bold text-blue-600">Akun</h2>
                  </div>
                  <div className="flex items-center justify-center pb-3">
                    <h2 className="text-base font-normal mb-3 text-black">
                      Masukkan E-mail Anda
                    </h2>
                  </div>
                </div>
              ) : (
                <div>
                  <div className="flex items-center justify-center pb-3">
                    <h2 className="text-xl font-bold text-black">Lupa-</h2>
                    <h2 className="text-xl font-bold text-blue-600">
                      Password
                    </h2>
                  </div>
                  <div className="flex items-center justify-center pb-3">
                    <h2 className="text-base font-normal mb-3 text-black">
                      Masukkan E-mail yang terdaftar
                    </h2>
                  </div>
                </div>
              )}

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
                  {register ? (
                    <button
                      onClick={(event: React.SyntheticEvent) =>
                        this.handleKirimOtp(event, true)
                      }
                      className="bg-[#002D74] w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
                    >
                      Kirim OTP
                    </button>
                  ) : (
                    <button
                      onClick={(event: React.SyntheticEvent) =>
                        this.handleKirimOtp(event, false)
                      }
                      className="bg-[#002D74] w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
                    >
                      Kirim OTP
                    </button>
                  )}
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
                  {register ? (
                    <div className="flex items-center justify-center">
                      {kirimUlang ? (
                        <h2
                          onClick={(event: React.SyntheticEvent) =>
                            this.handleKirimOtp(event, true)
                          }
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
                  ) : (
                    <div className="flex items-center justify-center">
                      {kirimUlang ? (
                        <h2
                          onClick={(event: React.SyntheticEvent) =>
                            this.handleKirimOtp(event, false)
                          }
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
                  )}
                </form>
              </div>
            </div>
          </div>
        ) : null}
        {inputRegis ? (
          <div className="h-[450px]">
            <div className="max-w-3xl p-5 items-center">
              <div className="flex items-center justify-center pb-3">
                <h2 className="text-xl font-bold text-black">Daftar-</h2>
                <h2 className="text-xl font-bold text-blue-600">Akun</h2>
              </div>
              <div className="flex items-center justify-center">
                <h2 className=" text-base w-full mb-3 flex items-center justify-center font-light text-black">
                  Verifikasi Otp berhasil, silahkan Lengkapi Data Diri Anda
                </h2>
              </div>
              <div className="ps-8pe-8 pb-4">
                <form>
                  <div className="overflow-y-auto h-[280px] p-3 flex flex-col gap-4">
                    <div>
                      <p className="text-xs pb-2">Username</p>
                      <input
                        className="p-3 bg-gray-300 rounded-xl border w-full"
                        type="text"
                        name="username"
                        value={modelRegistrasi.userName}
                        placeholder="Username"
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
                      <p className="text-xs pb-2">First Name</p>
                      <input
                        className="p-3 bg-gray-300 rounded-xl border w-full"
                        type="text"
                        name="FirstName"
                        value={modelRegistrasi.firstName}
                        placeholder="First Name"
                        onChange={this.changeHandler("FirstName")}
                        maxLength={100}
                      />
                      <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                        {!errorAlerts.FirstName?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.FirstName?.message}
                          </strong>
                        ) : null}
                      </p>
                    </div>
                    <div>
                      <p className="text-xs pb-2">Last Name</p>
                      <input
                        className="p-3 bg-gray-300 rounded-xl border w-full"
                        type="text"
                        name="LastName"
                        value={modelRegistrasi.lastName}
                        placeholder="Last Name"
                        onChange={this.changeHandler("LastName")}
                        maxLength={100}
                      />
                      <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                        {!errorAlerts.LastName?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.LastName?.message}
                          </strong>
                        ) : null}
                      </p>
                    </div>
                    <div>
                      <p className="text-xs pb-2">Email</p>
                      <input
                        className="p-3 text-gray-500 bg-gray-300 rounded-xl border w-full"
                        type="text"
                        name="Email"
                        value={email}
                        disabled
                        placeholder="Email"
                        maxLength={100}
                      />
                      <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light"></p>
                    </div>
                    <div>
                      <p className="text-xs pb-2">Password</p>
                      <input
                        className="p-3 bg-gray-300 rounded-xl border w-full"
                        type="password"
                        name="Password"
                        value={modelRegistrasi.password}
                        placeholder="Password"
                        onChange={this.changeHandler("PwdAccount")}
                        maxLength={100}
                      />
                      <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                        {modelRegistrasi.password.length > 0 ? (
                          !errorAlerts.CheckLengthPassword?.valid ? (
                            <strong id="title-error" role="alert">
                              {errorAlerts.CheckLengthPassword?.message}
                            </strong>
                          ) : null
                        ) : !errorAlerts.PwdAccount?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.PwdAccount?.message}
                          </strong>
                        ) : null}
                      </p>
                    </div>
                    <div>
                      <p className="text-xs pb-2">Ulangi Password</p>
                      <input
                        className="p-3 bg-gray-300 rounded-xl border w-full"
                        type="password"
                        name="Ulangi"
                        value={ulangiPassword}
                        placeholder="Ulangi Password"
                        onChange={this.changeHandler("UlangiPwdAccount")}
                        maxLength={100}
                      />
                      <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                        {ulangiPassword.length > 0 ? (
                          !errorAlerts.MatchPassword?.valid ? (
                            <strong id="title-error" role="alert">
                              {errorAlerts.MatchPassword?.message}
                            </strong>
                          ) : null
                        ) : !errorAlerts.UlangiPwdAccount?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.UlangiPwdAccount?.message}
                          </strong>
                        ) : null}
                      </p>
                    </div>
                    <div>
                      <p className="text-xs pb-2">Role</p>
                      <select
                        id="countries"
                        onChange={this.changeHandler("Role")}
                        value={modelRegistrasi.roleGroupId}
                        className="p-3 bg-gray-300 rounded-xl border w-full"
                      >
                        <option selected value="0">
                          --- Pilih Role ---
                        </option>
                        <option value="1">Admin</option>
                        <option value="2">Dosen</option>
                        <option value="3">Mahasiswa</option>
                      </select>
                      <p className="text-red-600 flex mx-auto text-center justify-center text-xs font-light">
                        {!errorAlerts.Role?.valid ? (
                          <strong id="title-error" role="alert">
                            {errorAlerts.Role?.message}
                          </strong>
                        ) : null}
                      </p>
                    </div>
                  </div>
                  <button
                    onClick={(event: React.SyntheticEvent) =>
                      this.handleRegister(event)
                    }
                    className="bg-[#002D74] p-4 w-full rounded-xl text-white py-2 hover:scale-105 duration-300"
                  >
                    Daftar
                  </button>
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
