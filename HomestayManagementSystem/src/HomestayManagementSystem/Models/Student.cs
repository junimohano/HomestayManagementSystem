using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(Student))]
    public class Student : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public string StudentNo { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Display(Name = "Profile")]
        public string ProfileFileName { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Email { get; set; }

        public string Remark { get; set; }

        public bool IsActive { get; set; } = true;


        [Display(Name = "SiteLocation")]
        public int SiteLocationId { get; set; }
        public SiteLocation SiteLocation { get; set; }

        public List<HomestayStudent> HomestayStudents { get; set; } = new List<HomestayStudent>();

        [NotMapped]
        [Display(Name = "Site")]
        public int SiteId { get; set; }

        [NotMapped]
        public string SiteName { get; set; }
    }
}
