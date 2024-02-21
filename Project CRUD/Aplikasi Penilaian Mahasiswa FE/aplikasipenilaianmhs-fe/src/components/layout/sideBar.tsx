import React from "react";
import { Link, Route, Routes } from "react-router-dom";
import { Home } from "../home";
import { Jurusan } from "../jurusan";
import { Mahasiswa } from "../mahasiswa";
import { Agama } from "../agama";
import { Dosen } from "../dosen";
import { Nilai } from "../nilai";
import { TypeDosen } from "../typedosen";
import { Ujian } from "../ujian";
import { config } from "../../configurations/config";
import {
  FaBook,
  FaClosedCaptioning,
  FaGraduationCap,
  FaHome,
  FaUserGraduate,
} from "react-icons/fa";
import { BsFillMoonStarsFill } from "react-icons/bs";
import { MdCategory, MdClose, MdCreditScore } from "react-icons/md";
import { GrTest } from "react-icons/gr";
import { AccountModel } from "../../models/modelAccount";
import { withRouter } from "./withRouter";
import Authentiaction from "../auth/authentiaction";
import { AiOutlineClose } from "react-icons/ai";
import { AuthService } from "../../services/authService";
import { ProtectedRoute } from "./protectedRoute";
import Modal from "./auth";
import Header from "./header";

interface IProps {
  logged: boolean;
  changeLoggedHandler: any;
  user: AccountModel;
  navigate: any;
}
interface IState {
  showModalLogin: boolean;
}

class SideBar extends React.Component<IProps, IState> {
  constructor(props: IProps) {
    super(props);
    this.state = {
      showModalLogin: false,
    };
  }
  setShowModal = (val: boolean) => {
    this.setState({
      showModalLogin: val,
    });
  };
  activeMenu = (route: string) => {
    return window.location.pathname === route ? "bg-gray-900" : "";
  };
  logoutBtn = () => {
    AuthService.logout();
    this.props.navigate("/");
    window.location.reload();
  };
  render() {
    const { showModalLogin } = this.state;
    const { changeLoggedHandler, logged, user } = this.props;
    return (
      <>
        <div className="w-full flex">
          <div className="flex flex-col bg-gray-800 w-60 shadow-xl">
            <div className="h-full">
              <a
                href="/#"
                className="flex items-start justify-center border-b border-gray-600 lg:px-6 py-1.5"
              >
                <div className="flex items-center p-3 justify-center">
                  <h2 className="text-xl font-bold text-white">SIAK-</h2>
                  <h2 className="text-xl font-bold text-blue-600">MHS</h2>
                </div>
              </a>
              <div>
                <div className="flex ps-4 pe-4 border-b border-gray-600">
                  {logged ? (
                    <ul className="mb-6 space-y-4 text-sm">
                      <li
                        className={`rounded-full m-1 ${this.activeMenu("/")}`}
                      >
                        <a
                          href="#"
                          className="flex items-center p-2 space-x-3 rounded-md"
                        >
                          <FaHome className="text-white" size={20} />
                          <span className="text-gray-100">
                            <Link to="/">Home</Link>
                          </span>
                        </a>
                      </li>
                      {user.roles.indexOf("jurusan") > -1 ? (
                        <>
                          <li
                            className={`rounded-full  m-1 ${this.activeMenu(
                              "/jurusan"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <FaBook className="text-white" size={20} />
                              <span className="text-gray-100">
                                <Link to="/jurusan">Jurusan</Link>
                              </span>
                            </a>
                          </li>
                        </>
                      ) : null}
                      {user.roles.indexOf("mahasiswa") > -1 ? (
                        <>
                          <li
                            className={`rounded-full m-1 ${this.activeMenu(
                              "/mahasiswa"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <FaGraduationCap
                                className="text-white"
                                size={20}
                              />
                              <span className="text-gray-100">
                                <Link to="/mahasiswa">Mahasiswa</Link>
                              </span>{" "}
                            </a>
                          </li>
                        </>
                      ) : null}

                      {user.roles.indexOf("agama") > -1 ? (
                        <>
                          <li
                            className={`rounded-full m-1 ${this.activeMenu(
                              "/agama"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <BsFillMoonStarsFill
                                className="text-white"
                                size={20}
                              />
                              <span className="text-gray-100">
                                <Link to="/agama">Agama</Link>
                              </span>
                            </a>
                          </li>
                        </>
                      ) : null}

                      {user.roles.indexOf("dosen") > -1 ? (
                        <>
                          <li
                            className={`rounded-full m-1 ${this.activeMenu(
                              "/dosen"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <FaUserGraduate
                                className="text-white"
                                size={20}
                              />
                              <span className="text-gray-100">
                                <Link to="/dosen">Dosen</Link>
                              </span>
                            </a>
                          </li>
                        </>
                      ) : null}
                      {user.roles.indexOf("nilai") > -1 ? (
                        <>
                          <li
                            className={`rounded-full m-1 ${this.activeMenu(
                              "/nilai"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <MdCreditScore className="text-white" size={20} />
                              <span className="text-gray-100">
                                <Link to="/nilai">Nilai</Link>
                              </span>
                            </a>
                          </li>
                        </>
                      ) : null}
                      {user.roles.indexOf("typedosen") > -1 ? (
                        <>
                          <li
                            className={`rounded-full m-1 ${this.activeMenu(
                              "/typedosen"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <MdCategory className="text-white" size={20} />
                              <span className="text-gray-100">
                                <Link to="/typedosen">Tipe Dosen</Link>
                              </span>
                            </a>
                          </li>
                        </>
                      ) : null}
                      {user.roles.indexOf("ujian") > -1 ? (
                        <>
                          <li
                            className={`rounded-full m-1 ${this.activeMenu(
                              "/ujian"
                            )}`}
                          >
                            <a
                              href="#"
                              className="flex items-center p-2 space-x-3 rounded-md"
                            >
                              <GrTest className="text-white" size={20} />
                              <span className="text-gray-100">
                                <Link to="/ujian">Ujian</Link>
                              </span>
                            </a>
                          </li>
                        </>
                      ) : null}
                    </ul>
                  ) : null}
                </div>
                {logged ? (
                  <div className="p-4">
                    <button
                      onClick={this.logoutBtn}
                      className="bg-red-800 rounded-3xl p-2 w-full text-white font-bold"
                    >
                      Logout
                    </button>
                  </div>
                ) : (
                  <div className="p-4">
                    <button
                      onClick={() => this.setShowModal(true)}
                      className="bg-blue-800 rounded-3xl w-full p-2 text-white font-bold"
                    >
                      Login
                    </button>
                  </div>
                )}
              </div>
            </div>
          </div>
          {showModalLogin ? (
            <Modal
              setShowModal={this.setShowModal}
              changeLoggedHandler={changeLoggedHandler}
              logged={logged}
            />
          ) : null}
          <div className="w-full">
            <Header account={user} logged={logged} />
            <div className="w-full ms-3 grid h-screen grid-cols-1 gap-3 h-screen text-center">
              <Routes>
                <Route path="/" Component={Home} />
                <Route element={<ProtectedRoute role="jurusan" />}>
                  <Route path="/jurusan" element={<Jurusan />} />
                </Route>
                <Route element={<ProtectedRoute role="mahasiswa" />}>
                  <Route path="/mahasiswa" element={<Mahasiswa />} />
                </Route>
                <Route element={<ProtectedRoute role="agama" />}>
                  <Route path="/agama" element={<Agama />} />
                </Route>
                <Route element={<ProtectedRoute role="dosen" />}>
                  <Route path="/dosen" element={<Dosen />} />
                </Route>
                <Route element={<ProtectedRoute role="nilai" />}>
                  <Route path="/nilai" element={<Nilai />} />
                </Route>
                <Route element={<ProtectedRoute role="typedosen" />}>
                  <Route path="/typedosen" element={<TypeDosen />} />
                </Route>
                <Route element={<ProtectedRoute role="ujian" />}>
                  <Route path="/ujian" element={<Ujian />} />
                </Route>
              </Routes>
            </div>
          </div>
        </div>
      </>
    );
  }
}

export default withRouter(SideBar);
