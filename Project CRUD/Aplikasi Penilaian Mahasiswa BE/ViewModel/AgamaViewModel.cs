﻿using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    public class AgamaViewModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Kode_Agama { get; set; }

        [Required, MaxLength(20)]
        public string Deskripsi { get; set; }

        public bool Is_delete { get; set; }
    }
}