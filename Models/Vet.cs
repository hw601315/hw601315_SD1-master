using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw601315_SD1.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string vetName { get; set; }
        public string technicianName { get; set; }
        public string vetLocation { get; set; }

        public ICollection<Visit> Visit { get; set; }
    }
}