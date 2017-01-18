using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomestayManagementSystem.Models
{
    [Table(nameof(LoginHistory))]
    public class LoginHistory : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int LoginHistoryId { get; set; }

        public string IpAddress { get; set; }
    }
}
