import { ModelAgama } from "./modelAgama";
import { ModelJurusan } from "./modelJurusan";

export class ModelMahasiswa {
  constructor() {
    this.agama = new ModelAgama();
    this.jurusan = new ModelJurusan();
  }
  id: number = 0;
  kode_Mahasiswa: string = "";
  nama_Mahasiswa: string = "";
  alamat: string = "";
  id_Agama: number = 0;
  id_Jurusan: number = 0;
  is_delete: boolean = false;
  agama: ModelAgama;
  jurusan: ModelJurusan;
}
