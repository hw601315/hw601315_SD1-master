using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw601315_SD1.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string petName { get; set; }
        public string breed { get; set; }
        public int petAge { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public string ownerFullName { get
            {
                return ownerLastName + ", " + ownerFirstName;
            }
        }
        public int ownerPhoneNumber { get; set; }
    }
}