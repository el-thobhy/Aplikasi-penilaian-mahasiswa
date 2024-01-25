import { ModelMahasiswa } from "./modelMahasiswa";
import { ModelUjian } from "./modelUjian";

export class ModelNilai {
  constructor() {
    this.mahasiswa = new ModelMahasiswa();
    this.ujian = new ModelUjian();
  }
  id: number = 0;
  kode_Mahasiswa: string = "";
  kode_Ujian: string = "";
  nilaiMahasiswa: number = 0;
  is_delete: boolean = false;
  mahasiswa: ModelMahasiswa;
  ujian: ModelUjian;
}
