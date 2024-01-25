using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_jurusan")]
    public class Jurusan: BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Kode_Jurusan { get; set; }
        [Required, MaxLength(50)]
        public string Nama_Jurusan { get; set; }
        [Required, MaxLength(100)]
        public string Status_Jurusan { get; set; }
    }
}
