using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw601315_SD1.Models
{
    public class Visit
    {
        public int visitID { get; set; }
        public int petID { get; set; }
        public int vetID { get; set; }
        public DateTime visitDate { get; set; }
        public string diagnosis { get; set; }
        public string weight { get; set; }
        public int visitCost { get; set; }
    }
}