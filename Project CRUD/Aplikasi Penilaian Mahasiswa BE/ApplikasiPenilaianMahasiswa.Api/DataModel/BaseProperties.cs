using System.ComponentModel.DataAnnotations;

namespace ApplikasiPenilaianMahasiswa.DataModel
{
    public class BaseProperties
    {
        [Required, MaxLength(50)]
        public string? Created_by { get; set; }
        public DateTime Created_on { get; set; }

        [MaxLength(50)]
        public string? Modified_by { get; set; }
        public DateTime? Modified_on { get; set; }

        [MaxLength(50)]
        public string? Deleted_by { get; set; }
        public DateTime? Deleted_on { get; set; }

        public bool Is_delete { get; set; } = false;

    }
}
