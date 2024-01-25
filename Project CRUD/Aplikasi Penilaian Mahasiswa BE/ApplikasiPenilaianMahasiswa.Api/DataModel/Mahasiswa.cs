using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_mahasiswa")]
    public class Mahasiswa: BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Kode_Mahasiswa { get; set; }

        [Required, MaxLength(100)]
        public string Nama_Mahasiswa { get; set; }

        [Required, MaxLength(200)]
        public string Alamat { get; set; }

        public int Id_Agama { get; set; }

        public int Id_Jurusan { get; set; }



        [ForeignKey("Id_Agama")]
        public virtual Agama Agama { get; set; }

        [ForeignKey("Id_Jurusan")]
        public virtual Jurusan Jurusan { get; set; }
    }
}
