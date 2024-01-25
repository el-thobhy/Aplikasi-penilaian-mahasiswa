import axios from "axios";
import { config } from "../configurations/config";
import { ModelPagination } from "../models/modelPagination";
import { ModelJurusan } from "../models/modelJurusan";

export const JurusanService = {
  getAll: (pg: ModelPagination) => {
    const searchStr = pg.search.length > 0 ? `&search=${pg.search}` : ``;
    // console.log(config.apiUrl + `/Jurusan?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`);
    const result = axios
      .get(
        config.apiUrl +
          `/Jurusan/Search?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`
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
  getAllJurusan: () => {
    const result = axios
      .get(config.apiUrl + "/Jurusan/GetAll")
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
  getById: (id: number) => {
    const result = axios
      .get(config.apiUrl + "/Jurusan/" + id)
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
  post: (jurusan: ModelJurusan) => {
    const result = axios
      .post(config.apiUrl + "/Jurusan", jurusan)
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
  update: (id: number, jurusan: ModelJurusan) => {
    const result = axios
      .put(config.apiUrl + "/Jurusan/" + id, jurusan)
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
      .put(config.apiUrl + `/Jurusan/delete/${id}?status=${status}`)
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
