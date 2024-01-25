using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MahasiswaViewModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Kode_Mahasiswa { get; set; }

        [Required, MaxLength(100)]
        public string Nama_Mahasiswa { get; set; }

        [Required, MaxLength(200)]
        public string Alamat { get; set; }

        public int Id_Agama { get; set; }

        public int Id_Jurusan { get; set; }
        public bool Is_delete { get; set; }
    }

    public class GetMahasiswaViewModel: MahasiswaViewModel
    {
        public AgamaViewModel Agama { get; set; }
        public JurusanViewModel Jurusan { get; set; }
    }
}
