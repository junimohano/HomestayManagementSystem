using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(HomestayEvaluation))]
    public class HomestayEvaluation : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HomestayEvaluationId { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime? EvaluationDate { get; set; }

        [Display(Name = "FileName")]
        public string EvaluationFileName { get; set; }

        [Required]
        public int Location { get; set; }

        [Required]
        public int EnglishProficiency { get; set; }

        [Required]
        public int CriminalRecordCheck { get; set; }

        [Required]
        public int LivingSpace { get; set; }

        [Required]
        public int QualityOfLivingSpace { get; set; }

        [Required]
        public int FinancialStability { get; set; }

        [Required]
        public int HostingExperience { get; set; }

        [Required]
        public int PaymentFlexibility { get; set; }

        public string Remark { get; set; }

        [Display(Name = "IsActive")]
        public bool IsEvaluationActive { get; set; } = true;

        public int HomestayId { get; set; }
        public Homestay Homestay { get; set; }

        [NotMapped]
        public int Score { get; set; }

        public int GetScore()
        {
            return Location +
                   EnglishProficiency +
                   CriminalRecordCheck +
                   LivingSpace +
                   QualityOfLivingSpace +
                   FinancialStability +
                   HostingExperience +
                   PaymentFlexibility;
        }
    }
}
