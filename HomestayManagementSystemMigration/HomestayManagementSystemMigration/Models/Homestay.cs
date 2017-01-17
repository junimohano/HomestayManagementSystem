using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomestayManagementSystemMigration.Models
{
    public class Homestay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Score { get; set; }
        public string Contract { get; set; }
        public string Students { get; set; }
        public List<HouseHold> Household = new List<HouseHold>();
        public List<string> PoliceCheck = new List<string>();
        public string Language { get; set; }
    }

    public class HouseHold
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
    }
}
