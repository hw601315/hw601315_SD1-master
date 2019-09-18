using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace hw601315_SD1.Models
{
    public class Visit
    {

        [Key] public int visitID { get; set; }
        public string visitDate { get; set; }

        public int petID { get; set; }
        public virtual Pet Pet { get; set; }

        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }
    }
}