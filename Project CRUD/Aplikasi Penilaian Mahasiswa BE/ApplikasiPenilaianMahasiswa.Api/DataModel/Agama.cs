using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_agama")]
    public class Agama: BaseProperties
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Key, MaxLength(5)]
        public string Kode_Agama { get; set; }

        [Required, MaxLength(20)]
        public string Deskripsi { get; set; }
    }
}
