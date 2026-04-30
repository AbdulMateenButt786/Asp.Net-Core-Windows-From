namespace BillingSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtAddbtn = new Button();
            btnCalculateTotal = new Button();
            btnRemoveItem = new Button();
            btnClear = new Button();
            label7 = new Label();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblFinalTot = new Label();
            lblDateTim = new Label();
            richTextBox1 = new RichTextBox();
            ItemTotal = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            dgvBill = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Price Per Item";
            label3.Click += label3_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(114, 33);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(114, 92);
            txtQuantity.Margin = new Padding(4, 3, 4, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(114, 63);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtAddbtn
            // 
            txtAddbtn.Location = new Point(28, 133);
            txtAddbtn.Margin = new Padding(4, 3, 4, 3);
            txtAddbtn.Name = "txtAddbtn";
            txtAddbtn.Size = new Size(75, 23);
            txtAddbtn.TabIndex = 6;
            txtAddbtn.Text = "Add Item";
            txtAddbtn.UseVisualStyleBackColor = true;
            txtAddbtn.Click += txtAddbtn_Click;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Location = new Point(114, 135);
            btnCalculateTotal.Margin = new Padding(4, 3, 4, 3);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(104, 21);
            btnCalculateTotal.TabIndex = 7;
            btnCalculateTotal.Text = "Calculate Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(234, 135);
            btnRemoveItem.Margin = new Padding(4, 3, 4, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(134, 23);
            btnRemoveItem.TabIndex = 8;
            btnRemoveItem.Text = "Remove Selected Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(387, 135);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 398);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 14;
            label7.Text = "Date and Time : ";
            label7.Click += label7_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(18, 317);
            lblSubtotal.Margin = new Padding(4, 0, 4, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(90, 15);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "Subtotal: Rs0.00";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(15, 343);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(93, 15);
            lblDiscount.TabIndex = 16;
            lblDiscount.Text = "Discount: Rs0.00";
            // 
            // lblFinalTot
            // 
            lblFinalTot.AutoSize = true;
            lblFinalTot.Location = new Point(14, 367);
            lblFinalTot.Margin = new Padding(4, 0, 4, 0);
            lblFinalTot.Name = "lblFinalTot";
            lblFinalTot.Size = new Size(99, 15);
            lblFinalTot.TabIndex = 17;
            lblFinalTot.Text = "Final Total: Rs0.00";
            // 
            // lblDateTim
            // 
            lblDateTim.AutoSize = true;
            lblDateTim.Location = new Point(115, 398);
            lblDateTim.Margin = new Padding(4, 0, 4, 0);
            lblDateTim.Name = "lblDateTim";
            lblDateTim.Size = new Size(0, 15);
            lblDateTim.TabIndex = 18;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(480, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 370);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // ItemTotal
            // 
            ItemTotal.HeaderText = "Item Total";
            ItemTotal.Name = "ItemTotal";
            ItemTotal.ReadOnly = true;
            ItemTotal.Width = 110;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 80;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Width = 60;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 120;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Product, Qty, Price, ItemTotal });
            dgvBill.Location = new Point(13, 164);
            dgvBill.Margin = new Padding(4, 3, 4, 3);
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(410, 105);
            dgvBill.TabIndex = 10;
            dgvBill.CellContentClick += dgvBill_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(lblDateTim);
            Controls.Add(lblFinalTot);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubtotal);
            Controls.Add(label7);
            Controls.Add(dgvBill);
            Controls.Add(btnClear);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnCalculateTotal);
            Controls.Add(txtAddbtn);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Billing System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button txtAddbtn;
        private Button btnCalculateTotal;
        private Button btnRemoveItem;
        private Button btnClear;
        private Label label7;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblFinalTot;
        private Label lblDateTim;
        private RichTextBox richTextBox1;
        private DataGridViewTextBoxColumn ItemTotal;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Product;
        private DataGridView dgvBill;
    }
}