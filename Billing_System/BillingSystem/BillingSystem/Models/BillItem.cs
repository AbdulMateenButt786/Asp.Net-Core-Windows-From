using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Models
{
    public class BillItem
    {
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double ItemTotal { get; set; }
    }
}
