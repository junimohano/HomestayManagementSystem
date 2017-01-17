using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomestayManagementSystemMigration.Models
{
    public class HomestayStudent
    {
        public Homestay Homestay { get; set; } = new Homestay();
        public Student Student { get; set; } = new Student();
        public string Arrival { get; set; }
        public string Departure { get; set; }
        public string AmountOwing { get; set; }
        public string AmountPaid { get; set; }

        public string SiteLocation { get; set; }
    }
}
