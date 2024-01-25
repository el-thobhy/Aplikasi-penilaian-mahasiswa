import { ModelMahasiswa } from "./modelMahasiswa";
import { ModelUjian } from "./modelUjian";

export class ModelNilai {
  constructor() {
    this.mahasiswa = new ModelMahasiswa();
    this.ujian = new ModelUjian();
  }
  id: number = 0;
  id_Mahasiswa: number = 0;
  id_Ujian: number = 0;
  nilaiMahasiswa: number = 0;
  is_delete: boolean = false;
  mahasiswa: ModelMahasiswa;
  ujian: ModelUjian;
}
