import React from "react";
import SideBar from "./sideBar";

export default class Header extends React.Component {
  render() {
    return (
      <div>
        <h3>Aplikasi Penilaian Mahasiswa</h3>
        <SideBar />
      </div>
    );
  }
}
