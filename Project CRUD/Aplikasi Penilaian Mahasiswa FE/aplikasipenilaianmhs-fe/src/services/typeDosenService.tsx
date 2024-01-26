import axios from "axios";
import { config } from "../configurations/config";
import { ModelPagination } from "../models/modelPagination";
import { ModelTypeDosen } from "../models/modelTypeDosen";

export const TypeDosenService = {
  getAll: (pg: ModelPagination) => {
    const searchStr = pg.search.length > 0 ? `&search=${pg.search}` : ``;
    // console.log(config.apiUrl + `/TypeDosen?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`);
    const result = axios
      .get(
        config.apiUrl +
          `/TypeDosen/Search?pageNum=${pg.pageNum}&rows=${pg.rows}${searchStr}&orderBy=${pg.orderBy}&sort=${pg.sort}`
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

  getAllTypeDosen: () => {
    const result = axios
      .get(config.apiUrl + "/TypeDosen/GetAll")
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
      .get(config.apiUrl + "/TypeDosen/" + id)
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
  post: (TypeDosen: ModelTypeDosen) => {
    const result = axios
      .post(config.apiUrl + "/TypeDosen", TypeDosen)
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
  update: (id: number, TypeDosen: ModelTypeDosen) => {
    const result = axios
      .put(config.apiUrl + "/TypeDosen/" + id, TypeDosen)
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
      .put(config.apiUrl + `/TypeDosen/delete/${id}?status=${status}`)
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
