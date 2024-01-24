using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class NilaiViewModel
    {
        public int Id { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Mahasiswa { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Ujian { get; set; }

        [Required]
        public decimal NilaiMahasiswa { get; set; }
        public bool Is_delete { get; set; }
    }

    public class GetNilaiViewModel : NilaiViewModel
    {
        public GetMahasiswaViewModel Mahasiswa { get; set; }

        public UjianViewModel Ujian { get; set; }
    }
}
