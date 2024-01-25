import axios from "axios";
import { config } from "../configurations/config";
import { ModelPagination } from "../models/modelPagination";
import { ModelMahasiswa } from "../models/modelMahasiswa";

export const MahasiswaService = {
  getAll: (pg: ModelPagination) => {
    const searchStr = pg.search.length > 0 ? `&search=${pg.search}` : ``;
    // console.log(config.apiUrl + `/Mahasiswa?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`);
    const result = axios
      .get(
        config.apiUrl +
          `/Mahasiswa/Search?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`
      )
      .then((respons) => {
        console.log(respons);
        return {
          success: respons.data.success,
          result: respons.data.data,
          pages: respons.data.pages,
        };
      })
      .catch((error) => {
        return {
          success: false,
          result: error,
          pages: 0,
        };
      });
    return result;
  },
  getById: (id: number) => {
    const result = axios
      .get(config.apiUrl + "/Mahasiswa/" + id)
      .then((respons) => {
        // console.log(respons);
        return {
          success: respons.status == 200,
          result: respons.data,
        };
      })
      .catch((error) => {
        return {
          success: false,
          result: error,
        };
      });
    return result;
  },

  getAllMahasiswa: () => {
    const result = axios
      .get(config.apiUrl + "/Mahasiswa/GetAll")
      .then((respons) => {
        // console.log(respons);
        return {
          success: respons.status == 200,
          result: respons.data,
        };
      })
      .catch((error) => {
        return {
          success: false,
          result: error,
        };
      });
    return result;
  },
  post: (Mahasiswa: ModelMahasiswa) => {
    const { jurusan, agama, id, is_delete, ...newMahasiswa } = Mahasiswa;
    const result = axios
      .post(config.apiUrl + "/Mahasiswa", newMahasiswa)
      .then((respons) => {
        console.log(respons);
        return {
          success: respons.status == 200,
          result: respons.data,
        };
      })
      .catch((error) => {
        // console.log(error);
        return {
          success: false,
          result: error,
        };
      });
    return result;
  },
  update: (id: number, Mahasiswa: ModelMahasiswa) => {
    const { jurusan, agama, ...newMahasiswa } = Mahasiswa;
    const result = axios
      .put(config.apiUrl + "/Mahasiswa/" + id, newMahasiswa)
      .then((respons) => {
        console.log(respons);
        return {
          success: respons.status == 200,
          result: respons.data,
        };
      })
      .catch((error) => {
        // console.log(error);
        return {
          success: false,
          result: error,
        };
      });
    return result;
  },
  changeStatus: (id: number, status: boolean) => {
    const result = axios
      .put(config.apiUrl + `/Mahasiswa/delete/${id}/${status}`)
      .then((respons) => {
        console.log(respons);
        return {
          success: respons.status == 200,
          result: respons.data,
        };
      })
      .catch((error) => {
        // console.log(error);
        return {
          success: false,
          result: error,
        };
      });
    return result;
  },
};
