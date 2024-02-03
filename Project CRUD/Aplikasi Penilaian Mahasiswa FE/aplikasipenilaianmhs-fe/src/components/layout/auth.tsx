import React from "react";
import { AiOutlineClose } from "react-icons/ai";
import Authentiaction from "../auth/authentiaction";

const Modal = ({ setShowModal, changeLoggedHandler, logged }: any) => {
  return (
    <div className="items-center fixed inset-0 z-50 outline-none focus:outline-none">
      <div className="w-full h-screen flex justify-center items-center">
        <div>
          <div className="h-full p-3 bg-white rounded-2xl shadow-lg">
            <button onClick={() => setShowModal(false)}>
              <AiOutlineClose className="justify-center text-black text-3xl" />
            </button>
            <Authentiaction
              setShowModal={setShowModal}
              changeLoggedHandler={changeLoggedHandler}
              logged={logged}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Modal;
