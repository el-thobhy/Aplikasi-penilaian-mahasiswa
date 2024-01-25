using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TypeDosenViewModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Kode_Type_Dosen { get; set; }

        [Required, MaxLength(20)]
        public string Deskripsi { get; set; }
        public bool Is_delete { get; set; }
    }
}
