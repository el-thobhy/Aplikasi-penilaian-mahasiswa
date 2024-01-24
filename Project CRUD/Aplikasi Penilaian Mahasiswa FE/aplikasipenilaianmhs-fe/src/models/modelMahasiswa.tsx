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
  kode_Agama: string = "";
  kode_Jurusan: string = "";
  is_delete: boolean = false;
  agama: ModelAgama;
  jurusan: ModelJurusan;
}
