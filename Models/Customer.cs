﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw601315_SD1.Models
{
    public class Customer
    {
        // type prop and hit tab twice 
        public int customerID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}