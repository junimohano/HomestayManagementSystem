using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(HomestayHouseHold))]
    public class HomestayHouseHold : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HomestayHouseHoldId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public bool Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string Remark { get; set; }

        [Display(Name = "IsActive")]
        public bool IsHouseHoldActive { get; set; } = true;

        public int HomestayId { get; set; }
        public Homestay Homestay { get; set; }
    }
}
