using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(Homestay))]
    public class Homestay : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HomestayId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Email { get; set; }

        [Required]
        public int Room { get; set; }

        public string Remark { get; set; }

        public bool IsActive { get; set; } = true;


        [Display(Name = "Profile")]
        public string ProfileFileName { get; set; }

        public string VideoUrl { get; set; }

        public string Students { get; set; }

        public string Language { get; set; }

        public List<HomestayEvaluation> HomestayEvaluations { get; set; } = new List<HomestayEvaluation>();
        public List<HomestayContract> HomestayContracts { get; set; } = new List<HomestayContract>();
        public List<HomestayPoliceCheck> HomestayPoliceChecks { get; set; } = new List<HomestayPoliceCheck>();
        public List<HomestayHouseHold> HomestayHouseHolds { get; set; } = new List<HomestayHouseHold>();
        public List<HomestayStudent> HomestayStudents { get; set; } = new List<HomestayStudent>();

        [NotMapped]
        public int Score { get; set; }

        [NotMapped]
        public DateTime? Contract { get; set; }

        [NotMapped]
        public DateTime? PoliceCheck { get; set; }

        [NotMapped]
        public int HouseHolders { get; set; }

        [NotMapped]
        public string HomestayFamily { get; set; }
    }
}
