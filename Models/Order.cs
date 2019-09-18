using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw601315_SD1.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime orderDate { get; set; }
    }
}