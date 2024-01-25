using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_dosen")]
    public class Dosen: BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Kode_Dosen { get; set; }

        [Required, MaxLength(100)]
        public string Nama_Dosen { get; set; }

        public int Id_Jurusan { get; set; }

        public int Id_Type_Dosen { get; set; }


        [ForeignKey("Id_Jurusan")]
        public virtual Jurusan Jurusan { get; set; }

        [ForeignKey("Id_Type_Dosen")]
        public virtual TypeDosen TypeDosen { get; set; }
    }
}
