using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ApplikasiPenilaianMahasiswa.DataModel;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_announcement")]
    public class Announcement : BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }

    }
}