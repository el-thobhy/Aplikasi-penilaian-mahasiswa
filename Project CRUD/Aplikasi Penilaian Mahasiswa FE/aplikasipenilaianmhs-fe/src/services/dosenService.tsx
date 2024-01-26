import axios from "axios";
import { config } from "../configurations/config";
import { ModelPagination } from "../models/modelPagination";
import { ModelDosen } from "../models/modelDosen";

export const DosenService = {
  getAll: (pg: ModelPagination) => {
    const searchStr = pg.search.length > 0 ? `&search=${pg.search}` : ``;
    // console.log(config.apiUrl + `/Dosen?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`);
    const result = axios
      .get(
        config.apiUrl +
          `/Dosen/Search?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`
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
      .get(config.apiUrl + "/Dosen/" + id)
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
  post: (Dosen: ModelDosen) => {
    const { jurusan, id, is_delete, ...newDosen } = Dosen;
    const result = axios
      .post(config.apiUrl + "/Dosen", newDosen)
      .then((respons) => {
        console.log(respons);
        return {
          success: respons.status == 200,
          status: respons.status,
          result: respons.data,
        };
      })
      .catch((error) => {
        // console.log(error);
        return {
          success: false,
          status: error.response.status,
          result: error.response.data,
        };
      });
    return result;
  },
  update: (id: number, Dosen: ModelDosen) => {
    const { jurusan, ...newDosen } = Dosen;
    const result = axios
      .put(config.apiUrl + "/Dosen/" + id, newDosen)
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
      .put(config.apiUrl + `/Dosen/delete/${id}?status=${status}`)
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
