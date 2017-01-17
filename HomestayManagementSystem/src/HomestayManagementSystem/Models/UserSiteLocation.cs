using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(UserSiteLocation))]
    public class UserSiteLocation : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserSiteLocationId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int SiteLocationId { get; set; }
        public SiteLocation SiteLocation { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
