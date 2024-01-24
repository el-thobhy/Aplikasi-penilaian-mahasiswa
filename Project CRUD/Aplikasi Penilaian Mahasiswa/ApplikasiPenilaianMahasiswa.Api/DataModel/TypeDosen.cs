﻿using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_type_dosen")]
    public class TypeDosen: BaseProperties
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(5), Key]
        public string Kode_Type_Dosen { get; set; }

        [Required, MaxLength(20)]
        public string Deskripsi { get; set; }
    }
}
