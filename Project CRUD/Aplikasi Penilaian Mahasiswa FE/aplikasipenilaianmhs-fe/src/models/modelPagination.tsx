import { config } from "../configurations/config";

export class ModelPagination {
  pageNum: number = 1;
  rows: number = config.rowsPerPage[0];
  search: string = "";
  orderBy: string = "";
  sort: number = 0;
  pages: number = 1;
}
