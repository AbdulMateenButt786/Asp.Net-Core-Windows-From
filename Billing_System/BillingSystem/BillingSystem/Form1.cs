using BillingSystem.Delegates;
using BillingSystem.Logger;
using BillingSystem.Models;
using System.Text.RegularExpressions;

namespace BillingSystem
{
    public partial class Form1 : Form
    {
        private ValidateItem Itemvalidator;
        private Func<double, double>? DiscountCalculator;
        private Action<string>? logMessenger;

        public event ItemAddedEventHandler? OnItemAdded;
        public event BillCalculatedEventHandler? OnBillCalculated;
        public event BillClearedEventHandler? OnBillCleared;

        private BillingLogger _logger;

        public Form1()
        {
            Itemvalidator = ValidateBillItem;
            InitializeComponent();

            logMessenger = (message) =>
            {
                richTextBox1.AppendText(message + Environment.NewLine);
            };

            DiscountCalculator = (subtotal) => subtotal * 0.90;

            _logger = new BillingLogger(logMessenger);
            SubscribeToEvents();
        }



        private void SubscribeToEvents()
        {
            OnItemAdded += _logger.OnItemAddedHandler;
            OnBillCalculated += _logger.OnBillCalculatedHandler;
            OnBillCleared += _logger.OnBillClearedHandler;

            OnItemAdded += (sender, e) =>
            {
                lblDateTim.Text = $"Last Item Added: {DateTime.Now:g}";
            };
            OnBillCalculated += (sender, e) =>
            {
                lblDateTim.Text = $"Bill Generated: {e.BillDateTime:g}";
            };
        }


        private bool ValidateBillItem(string productName, int quantity, double price)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return false;

            if (quantity <= 0)
                return false;

            if (price <= 0)
                return false;

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("    My log for bill \n");
            lblSubtotal.Text = "SubTotal: 0.00";
            lblDiscount.Text = "Discount: 0.00";
            lblFinalTot.Text = "Final Total: 0.00";
        }

        private void txtAddbtn_Click(object sender, EventArgs e)
        {
            string itemName = txtProductName.Text.Trim();
            int quantity;
            bool QuantityValidation = int.TryParse(txtQuantity.Text, out quantity);
            double price;
            bool priceValid = double.TryParse(txtPrice.Text, out price);

            if (!QuantityValidation || !priceValid)
            {
                MessageBox.Show("quantity or price is not valid", "input not correct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isValid = Itemvalidator(itemName, quantity, price);
            if (!isValid)
            {
                MessageBox.Show("Your validation against Feeded data failed ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double itemTotal = quantity * price;
            BillItem billItem = new BillItem
            {
                ProductName = itemName,
                Price = price,
                Quantity = quantity,
                ItemTotal = itemTotal
            };

            dgvBill.Rows.Add(
                billItem.ProductName,
                billItem.Quantity,
                billItem.Price.ToString(),
                billItem.ItemTotal.ToString());

            OnItemAdded?.Invoke(this, new ItemAddedEventArgs
            {
                ProductName = billItem.ProductName,
                Quantity = billItem.Quantity,
                Price = billItem.Price,
                ItemTotal = billItem.ItemTotal
            });
            ClearInputBoxes();
        }



        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            if (dgvBill.Rows.Count == 0)
            {
                MessageBox.Show("None of the  item in Your bill", "Empty Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double subtotal = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (!int.TryParse(row.Cells[1].Value?.ToString(), out int quantity) || quantity <= 0)
                {
                    MessageBox.Show($"Invalid quantity in row {row.Index + 1}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string priceStr = new string((row.Cells[2].Value?.ToString() ?? "0").Where(c => char.IsDigit(c) || c == '.').ToArray());
                if (string.IsNullOrEmpty(priceStr) || !double.TryParse(priceStr, out double price) || price <= 0)
                {
                    MessageBox.Show($"Invalid price in row {row.Index + 1}", "validating error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double itemTotal = quantity * price;
                subtotal += itemTotal;
            }

            double discountedTotal;
            if (DiscountCalculator != null)
            {
                discountedTotal = DiscountCalculator(subtotal);
            }
            else
            {
                discountedTotal = subtotal;
            }

            double discount = subtotal - discountedTotal;
            lblSubtotal.Text = $"Subtotal: {subtotal}";
            lblDiscount.Text = $"Discount (10%): {discount}";

            lblFinalTot.Text = $"Final Total: {discountedTotal}";
            DateTime billDateTime = DateTime.Now;
            lblDateTim.Text = $"Bill Generated: {billDateTime:g}";

            OnBillCalculated?.Invoke(this, new BillCalculatedEventArgs
            {
                Subtotal = subtotal,
                Discount = discount,
                FinalTotal = discountedTotal,
                BillDateTime = billDateTime
            });
            MessageBox.Show($"yur bill is calculated\n\nSubtotal: {subtotal:C}\n Discount (10%): {discount:C}\nFinal Total: {discountedTotal:C}", "Calculation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvBill.Rows.RemoveAt(dgvBill.SelectedRows[0].Index);
            MessageBox.Show("Product item Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputBoxes();
            dgvBill.Rows.Clear();
            lblSubtotal.Text = "Subtotal: 0.00";
            lblDiscount.Text = "Discount: 0.00";
            lblFinalTot.Text = "Final Total: 0.00";

            OnBillCleared?.Invoke(this, new BillClearedEventArgs
            {
                ClearedDateTime = DateTime.Now
            });
            MessageBox.Show("your bill is cleared", "Clear Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBill.Rows.Count)
            {
                dgvBill.Rows[e.RowIndex].Selected = true;
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void ClearInputBoxes()
        {
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtProductName.Focus();
        }

        private void txt_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e)
        {}
        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
