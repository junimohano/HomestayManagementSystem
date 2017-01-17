using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(HomestayPoliceCheck))]
    public class HomestayPoliceCheck : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HomestayPoliceCheckId { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime? PoliceCheckDate { get; set; }

        public string Remark { get; set; }

        [Display(Name = "FileName")]
        public string PoliceCheckFileName { get; set; }

        [Display(Name = "IsActive")]
        public bool IsPoliceCheckActive { get; set; } = true;

        public int HomestayId { get; set; }
        public Homestay Homestay { get; set; }
    }
}
