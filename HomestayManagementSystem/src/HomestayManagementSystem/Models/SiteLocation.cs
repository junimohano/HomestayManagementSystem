using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(SiteLocation))]
    public class SiteLocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SiteLocationId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public int SiteId { get; set; }
        public Site Site { get; set; }

        public List<UserSiteLocation> UserSiteLocations { get; set; } = new List<UserSiteLocation>();
    }
}
