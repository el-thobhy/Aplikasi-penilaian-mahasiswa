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

        public int Id_Mahasiswa { get; set; }

        public int Id_Ujian { get; set; }

        [Required]
        public decimal NilaiMahasiswa { get; set; }


        [ForeignKey("Id_Mahasiswa")]
        public virtual Mahasiswa Mahasiswa { get; set; }
        [ForeignKey("Id_Ujian")]
        public virtual Ujian Ujian { get; set; }
    }
}
