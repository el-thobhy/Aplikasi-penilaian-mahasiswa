import React from "react";
import { Link, Route, Routes } from "react-router-dom";
import { Home } from "../home";
import { Jurusan } from "../jurusan";
import { Mahasiswa } from "../mahasiswa";
import { Agama } from "../agama";
import { Dosen } from "../dosen";
import { Nilai } from "../nilai";

export default class SideBar extends React.Component {
  render() {
    return (
      <div className="w-full h-screen flex">
        <div className="flex flex-col h-screen p-3 bg-gray-800 shadow w-60">
          <div className="space-y-3">
            <div className="flex items-center">
              <h2 className="text-xl font-bold text-white">
                Aplikasi Penilaian Mahasiswa
              </h2>
            </div>
            <div className="flex-1">
              <ul className="pt-2 pb-4 space-y-1 text-sm">
                <li className="rounded-sm">
                  <a
                    href="#"
                    className="flex items-center p-2 space-x-3 rounded-md"
                  >
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
                    <span className="text-gray-100">
                      <Link to="/nilai">Nilai</Link>
                    </span>
                  </a>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <div className="w-full grid grid-cols-1 gap-3 px-8 h-1/2 text-center">
          <Routes>
            <Route path="/" Component={Home} />
            <Route path="/jurusan" Component={Jurusan} />
            <Route path="/mahasiswa" Component={Mahasiswa} />
            <Route path="/agama" Component={Agama} />
            <Route path="/dosen" Component={Dosen} />
            <Route path="/nilai" Component={Nilai} />
          </Routes>
        </div>
      </div>
    );
  }
}
