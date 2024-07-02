using ApplikasiPenilaianMahasiswa.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    [Table("m_role_group")]
    public class RoleGroup: BaseProperties
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string GroupName { get; set; }

        public ICollection<AuthorizationGroup> AuthorizationGroups { get; set; }
    }
}
