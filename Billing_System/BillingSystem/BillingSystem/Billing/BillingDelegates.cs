using System;
using System.Collections.Generic;
using BillingSystem.Models;
using System.Text;

namespace BillingSystem.Delegates
{
    public delegate bool ValidateItem(string name, int quantity, double price);

    public class ItemAddedEventArgs : EventArgs
    {
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double ItemTotal { get; set; }
    }

    public class BillCalculatedEventArgs : EventArgs
    {
        public double Subtotal { get; set; }
        public double Discount { get; set; }
        public double FinalTotal { get; set; }
        public DateTime BillDateTime { get; set; }
    }

    public class BillClearedEventArgs : EventArgs
    {
        public DateTime ClearedDateTime { get; set; }
    }

    public delegate void ItemAddedEventHandler(object sender, ItemAddedEventArgs e);
    public delegate void BillCalculatedEventHandler(object sender, BillCalculatedEventArgs e);
    public delegate void BillClearedEventHandler(object sender, BillClearedEventArgs e);
}
