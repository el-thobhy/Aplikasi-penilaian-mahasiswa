﻿using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_dosen")]
    public class Dosen: BaseProperties
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key, Required, MaxLength(5)]
        public string Kode_Dosen { get; set; }

        [Required, MaxLength(100)]
        public string Nama_Dosen { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Jurusan { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Type_Dosen { get; set; }


        [ForeignKey("Kode_Jurusan")]
        public virtual Jurusan Jurusan { get; set; }

        [ForeignKey("Kode_Type_Dosen")]
        public virtual TypeDosen TypeDosen { get; set; }
    }
}
