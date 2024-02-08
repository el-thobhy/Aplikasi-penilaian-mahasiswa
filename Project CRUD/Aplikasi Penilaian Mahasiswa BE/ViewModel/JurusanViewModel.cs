﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class JurusanViewModel
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Kode_Jurusan { get; set; }
        [Required, MaxLength(50)]
        public string Nama_Jurusan { get; set; }
        [Required, MaxLength(100)]
        public string Status_Jurusan { get; set; }

        public int Created_by { get; set; }
        public bool Is_delete { get; set; }
    }
}
