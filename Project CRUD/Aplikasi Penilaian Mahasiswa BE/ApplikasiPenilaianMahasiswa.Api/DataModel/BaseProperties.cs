using System.ComponentModel.DataAnnotations;

namespace ApplikasiPenilaianMahasiswa.DataModel
{
    public class BaseProperties
    {
        [Required, MaxLength(50)]
        public long Created_by { get; set; }
        public DateTime Created_on { get; set; }

        [MaxLength(50)]
        public long? Modified_by { get; set; }
        public DateTime? Modified_on { get; set; }

        [MaxLength(50)]
        public long? Deleted_by { get; set; }
        public DateTime? Deleted_on { get; set; }

        public bool Is_delete { get; set; } = false;

    }
}
