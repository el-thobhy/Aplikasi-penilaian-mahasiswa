import axios from "axios";
import { config } from "../configurations/config";
import { ModelPagination } from "../models/modelPagination";
import { ModelUjian } from "../models/modelUjian";

export const UjianService = {
  getAll: (pg: ModelPagination) => {
    const searchStr = pg.search.length > 0 ? `&search=${pg.search}` : ``;
    // console.log(config.apiUrl + `/Ujian?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`);
    const result = axios
      .get(
        config.apiUrl +
          `/Ujian/Search?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`
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
      .get(config.apiUrl + "/Ujian/" + id)
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
  post: (Ujian: ModelUjian) => {
    const result = axios
      .post(config.apiUrl + "/Ujian", Ujian)
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
  update: (id: number, Ujian: ModelUjian) => {
    const result = axios
      .put(config.apiUrl + "/Ujian/" + id, Ujian)
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
      .put(config.apiUrl + `/Ujian/delete/${id}/${status}`)
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
