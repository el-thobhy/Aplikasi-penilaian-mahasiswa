using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DosenViewModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Kode_Dosen { get; set; }

        [Required, MaxLength(100)]
        public string Nama_Dosen { get; set; }

        public int Id_Jurusan { get; set; }

        public int Id_Type_Dosen { get; set; }
        public bool Is_delete { get; set; }
    }

    public class GetDosenViewModel: DosenViewModel
    {
        public JurusanViewModel Jurusan { get; set; }

        public TypeDosenViewModel TypeDosen { get; set; }
    }
}
