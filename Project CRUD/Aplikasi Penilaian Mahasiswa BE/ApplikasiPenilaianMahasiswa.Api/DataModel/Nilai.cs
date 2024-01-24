using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_nilai")]
    public class Nilai: BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Mahasiswa { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Ujian { get; set; }

        [Required]
        public decimal NilaiMahasiswa { get; set; }


        [ForeignKey("Kode_Mahasiswa")]
        public virtual Mahasiswa Mahasiswa { get; set; }
        [ForeignKey("Kode_Ujian")]
        public virtual Ujian Ujian { get; set; }
    }
}
