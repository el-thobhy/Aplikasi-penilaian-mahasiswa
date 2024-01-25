using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_ujian")]
    public class Ujian: BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Kode_Ujian { get; set; }

        [Required, MaxLength(50)]
        public string Nama_Ujian { get; set; }

        [Required, MaxLength(100)]
        public string Status_Ujian { get; set; }
    }
}
