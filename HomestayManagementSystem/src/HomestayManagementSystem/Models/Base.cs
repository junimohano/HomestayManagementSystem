using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    public class Base
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        public int? CreatedUserId { get; set; }
        public User CreatedUser { get; set; }

        public int? UpdatedUserId { get; set; }
        public User UpdatedUser { get; set; }

        [NotMapped]
        [Display(Name = "CretaedUser")]
        public string CreatedUserName { get; set; }

        [NotMapped]
        [Display(Name = "UpdatedUser")]
        public string UpdatedUserName { get; set; }

        //[StringLength(20)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone format is not valid.")]
        //[EmailAddress]
    }
}
