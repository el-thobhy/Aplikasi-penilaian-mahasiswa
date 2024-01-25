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
  id_Jurusan: number = 0;
  id_Type_Dosen: number = 0;
  is_delete: boolean = false;
  jurusan: ModelJurusan;
  typeDosen: ModelTypeDosen;
}
