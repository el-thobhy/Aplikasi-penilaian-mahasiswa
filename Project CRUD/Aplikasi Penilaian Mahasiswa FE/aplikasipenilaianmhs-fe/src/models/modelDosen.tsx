import { ModelJurusan } from "./modelJurusan";
import { ModelTypeDosen } from "./modelTypeDosen";

export class ModelDosen {
  constructor() {
    this.jurusan = new ModelJurusan();
    this.typeDosen = new ModelTypeDosen();
  }
  id: number = 0;
  kode_Dosen: string = "";
  nama_Dosen: string = "";
  kode_Jurusan: string = "";
  kode_Type_Dosen: string = "";
  is_delete: boolean = false;
  jurusan: ModelJurusan;
  typeDosen: ModelTypeDosen;
}
