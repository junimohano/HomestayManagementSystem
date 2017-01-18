using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(HomestayContract))]
    public class HomestayContract : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HomestayContractId { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime? ContractDate { get; set; }

        public string Remark { get; set; }

        [Display(Name = "IsActive")]
        public bool IsContractActive { get; set; } = true;

        [Display(Name = "FileName")]
        public string ContractFileName { get; set; }

        public int HomestayId { get; set; }
        public Homestay Homestay { get; set; }
    }
}
