using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(HomestayStudent))]
    public class HomestayStudent : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HomestayStudentId { get; set; }

        [Required]
        public DateTime? Arrival { get; set; }

        [Required]
        public DateTime? Departure { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime? DueDate { get; set; }

        public decimal PaidAmount { get; set; }

        public DateTime? PaidDate { get; set; }

        public string Remark { get; set; }

        public bool IsActive { get; set; } = true;


        [Display(Name = "Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Display(Name = "Homestay")]
        public int HomestayId { get; set; }
        public Homestay Homestay { get; set; }

        [NotMapped]
        public bool IsContractSigned { get; set; }

        [NotMapped]
        [Display(Name = "Site")]
        public int SiteId { get; set; }

        [NotMapped]
        public string SiteName { get; set; }

        [NotMapped]
        [Display(Name = "SiteLocation")]
        public int SiteLocationId { get; set; }

        [NotMapped]
        public string SiteLocationName { get; set; }

        [NotMapped]
        public string HomestayFamily { get; set; }

        [NotMapped]
        public decimal Balance { get; set; }
    }
}
