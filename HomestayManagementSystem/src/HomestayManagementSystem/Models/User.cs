using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(User))]
    public class User : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }

        [Required]
        public string LoginId { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Remark { get; set; }

        public bool IsActive { get; set; } = true;

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }

        public List<UserSiteLocation> UserSiteLocations { get; set; } = new List<UserSiteLocation>();

        [Display(Name = "Site")]
        [NotMapped]
        public int SiteId { get; set; }

        [Display(Name = "SiteLocation")]
        [NotMapped]
        public int SiteLocationId { get; set; }
    }
}
