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
  FaGraduationCap,
  FaHome,
  FaUserGraduate,
} from "react-icons/fa";
import { BsFillMoonStarsFill } from "react-icons/bs";
import { MdCategory, MdCreditScore } from "react-icons/md";
import { GrTest } from "react-icons/gr";

export default class SideBar extends React.Component {
  render() {
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
              <h2 className="text-white items-center justify-center ps-3 pb-2">
                Hi Guest
              </h2>
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
          </div>
        </div>
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
