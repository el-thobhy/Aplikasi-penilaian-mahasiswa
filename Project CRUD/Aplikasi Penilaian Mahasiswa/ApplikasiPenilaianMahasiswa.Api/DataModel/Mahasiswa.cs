using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_mahasiswa")]
    public class Mahasiswa: BaseProperties
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key, Required, MaxLength(5)]
        public string Kode_Mahasiswa { get; set; }

        [Required, MaxLength(100)]
        public string Nama_Mahasiswa { get; set; }

        [Required, MaxLength(200)]
        public string Alamat { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Agama { get; set; }

        [Required, MaxLength(5)]
        public string Kode_Jurusan { get; set; }



        [ForeignKey("Kode_Agama")]
        public virtual Agama Agama { get; set; }

        [ForeignKey("Kode_Jurusan")]
        public virtual Jurusan Jurusan { get; set; }
    }
}
