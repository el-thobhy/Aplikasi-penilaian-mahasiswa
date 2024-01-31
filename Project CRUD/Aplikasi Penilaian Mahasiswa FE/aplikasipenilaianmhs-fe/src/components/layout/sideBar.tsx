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

  logoutBtn = () => {
    AuthService.logout();
    this.props.navigate("/");
    window.location.reload();
  };
  render() {
    const { showModalLogin } = this.state;
    const { changeLoggedHandler, logged, user } = this.props;
    return (
      <div className="w-full h-screen flex bg-gray-700">
        <div className="flex flex-col h-auto p-3 m-3 rounded-3xl bg-gray-800 w-60 shadow-xl">
          <div className="space-y-3">
            <div className="flex items-center justify-center border-b border-solid border-gray-600 pb-3">
              <h2 className="text-xl font-bold text-white">SIAK-</h2>
              <h2 className="text-xl font-bold text-blue-600">MHS</h2>
            </div>
            {/* {logged ? ( */}
            <div className="flex items-center justify-start border-b border-solid border-gray-600 pb-2 flex-shrink-0 ">
              <img
                // src={account.image ? account.image : config.noImage}
                src={config.noImage}
                // alt={`${account.fullName}'s profile`}
                className="w-10 h-10 object-cover rounded-full border border-blue-700 p-1 mb-1"
              />
              {logged ? (
                <h2 className="text-white items-center justify-center ps-3 pb-2">
                  {user.firstName}
                </h2>
              ) : (
                <button
                  onClick={() => this.setShowModal(true)}
                  className="bg-blue-800 rounded-3xl w-full m-2 p-1 text-white font-bold"
                >
                  Login
                </button>
              )}
            </div>
            {/* ) : null} */}
            <div className="flex-1">
              <ul className="pt-2 pb-4 space-y-4 text-sm">
                <li className="rounded-sm">
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
                <li className="rounded-sm">
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
                <li className="rounded-sm">
                  <a
                    href="#"
                    className="flex items-center p-2 space-x-3 rounded-md"
                  >
                    <FaGraduationCap className="text-white" size={20} />
                    <span className="text-gray-100">
                      <Link to="/mahasiswa">Mahasiswa</Link>
                    </span>
                  </a>
                </li>

                <li className="rounded-sm">
                  <a
                    href="#"
                    className="flex items-center p-2 space-x-3 rounded-md"
                  >
                    <BsFillMoonStarsFill className="text-white" size={20} />
                    <span className="text-gray-100">
                      <Link to="/agama">Agama</Link>
                    </span>
                  </a>
                </li>

                <li className="rounded-sm">
                  <a
                    href="#"
                    className="flex items-center p-2 space-x-3 rounded-md"
                  >
                    <FaUserGraduate className="text-white" size={20} />
                    <span className="text-gray-100">
                      <Link to="/dosen">Dosen</Link>
                    </span>
                  </a>
                </li>
                <li className="rounded-sm">
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
                <li className="rounded-sm">
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
                <li className="rounded-sm">
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
              </ul>
            </div>
            {logged ? (
              <button
                onClick={this.logoutBtn}
                className="bg-red-800 rounded-3xl w-full p-1 text-white font-bold"
              >
                Logout
              </button>
            ) : null}
          </div>
        </div>
        {showModalLogin ? (
          <div className="items-center fixed inset-0 z-50 outline-none focus:outline-none ">
            <div className="w-full h-screen flex justify-center items-center">
              <div>
                <div className="h-full p-3 bg-white rounded-2xl shadow-lg ">
                  <button onClick={() => this.setShowModal(false)}>
                    <AiOutlineClose className="justify-center text-black text-3xl" />
                  </button>
                  <Authentiaction
                    setShowModal={this.setShowModal}
                    changeLoggedHandler={changeLoggedHandler}
                    logged={logged}
                  />
                </div>
              </div>
            </div>
          </div>
        ) : null}
        <div className="w-full grid grid-cols-1 gap-3 overflow-auto h-screen text-center">
          <Routes>
            <Route path="/" Component={Home} />
            <Route path="/jurusan" Component={Jurusan} />
            <Route path="/mahasiswa" Component={Mahasiswa} />
            <Route path="/agama" Component={Agama} />
            <Route path="/dosen" Component={Dosen} />
            <Route path="/nilai" Component={Nilai} />
            <Route path="/typedosen" Component={TypeDosen} />
            <Route path="/ujian" Component={Ujian} />
          </Routes>
        </div>
      </div>
    );
  }
}

export default withRouter(SideBar);
