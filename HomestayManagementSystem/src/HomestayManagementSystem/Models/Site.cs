using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(Site))]
    public class Site
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SiteId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FullName { get; set; }

        public List<SiteLocation> SiteLocations { get; set; } = new List<SiteLocation>();
    }
}
