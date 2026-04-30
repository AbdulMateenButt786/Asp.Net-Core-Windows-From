using BillingSystem.Delegates;
using System;
namespace BillingSystem.Logger
{
    public class BillingLogger
    {
        private Action<string> _logWriter;
        public BillingLogger(Action<string> logWriter)
        {
            _logWriter = logWriter ?? throw new ArgumentNullException(nameof(logWriter));
        }

        public void OnItemAddedHandler(object sender, ItemAddedEventArgs e)
        {
            string message = $"[{DateTime.Now:HH:mm:ss}] Item Added: {e.ProductName} x{e.Quantity} = {e.ItemTotal}";
            _logWriter(message);
        }
        public void OnBillCalculatedHandler(object sender, BillCalculatedEventArgs e)
        {
            string message = $"[{DateTime.Now:HH:mm:ss}] Bill Calculated: Subtotal={e.Subtotal}, Discount={e.Discount}, Total={e.FinalTotal}";
            _logWriter(message);
        }

        public void OnBillClearedHandler(object sender, BillClearedEventArgs e)
        {
            string message = $"[{DateTime.Now:HH:mm:ss}] The Bill is Cleared ";
            _logWriter(message);
        }
    }
}
