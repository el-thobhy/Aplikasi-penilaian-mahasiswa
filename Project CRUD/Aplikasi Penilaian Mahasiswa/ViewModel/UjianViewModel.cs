using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UjianViewModel
    {
        public int Id { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Ujian { get; set; }

        [Required, MaxLength(50)]
        public string Nama_Ujian { get; set; }

        [Required, MaxLength(100)]
        public string Status_Ujian { get; set; }
    }
}
