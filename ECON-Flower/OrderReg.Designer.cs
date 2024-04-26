namespace ECON_Flower
{
    partial class OrderReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            btn_back = new Button();
            panel1 = new Panel();
            button1 = new Button();
            TotalPrice = new Label();
            label3 = new Label();
            lblCustomerID = new Label();
            dataGridView1 = new DataGridView();
            lblCartID = new Label();
            Date = new DateTimePicker();
            label6 = new Label();
            PaymentMethod = new ComboBox();
            label7 = new Label();
            btn_order = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            Address = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 9);
            label2.Name = "label2";
            label2.Size = new Size(276, 63);
            label2.TabIndex = 3;
            label2.Text = "ORDER FORM";
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(1249, 0);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(107, 31);
            btn_back.TabIndex = 0;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_back);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 82);
            panel1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(670, 2);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 14;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPrice.Location = new Point(548, 293);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(166, 37);
            TotalPrice.TabIndex = 16;
            TotalPrice.Text = "TOTAL PRICE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 135);
            label3.Name = "label3";
            label3.Size = new Size(96, 37);
            label3.TabIndex = 15;
            label3.Text = "ITEMS:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(196, 86);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(183, 37);
            lblCustomerID.TabIndex = 14;
            lblCustomerID.Text = "CUSTOMER ID:";
            lblCustomerID.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(142, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(589, 155);
            dataGridView1.TabIndex = 17;
            // 
            // lblCartID
            // 
            lblCartID.AutoSize = true;
            lblCartID.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCartID.Location = new Point(565, 86);
            lblCartID.Name = "lblCartID";
            lblCartID.Size = new Size(116, 37);
            lblCartID.TabIndex = 18;
            lblCartID.Text = "CART ID:";
            // 
            // Date
            // 
            Date.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.Location = new Point(210, 412);
            Date.Name = "Date";
            Date.Size = new Size(521, 51);
            Date.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 422);
            label6.Name = "label6";
            label6.Size = new Size(190, 37);
            label6.TabIndex = 20;
            label6.Text = "DELIVERY DATE:";
            // 
            // PaymentMethod
            // 
            PaymentMethod.BackColor = Color.White;
            PaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentMethod.Font = new Font("Impact", 18F);
            PaymentMethod.FormattingEnabled = true;
            PaymentMethod.Items.AddRange(new object[] { "Card", "Cash" });
            PaymentMethod.Location = new Point(262, 493);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(469, 52);
            PaymentMethod.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 499);
            label7.Name = "label7";
            label7.Size = new Size(231, 37);
            label7.TabIndex = 22;
            label7.Text = "PAYMENT METHOD:";
            // 
            // btn_order
            // 
            btn_order.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_order.BackColor = Color.FromArgb(192, 64, 0);
            btn_order.FlatAppearance.BorderSize = 0;
            btn_order.FlatStyle = FlatStyle.Flat;
            btn_order.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order.ForeColor = Color.White;
            btn_order.Location = new Point(485, 562);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(281, 92);
            btn_order.TabIndex = 24;
            btn_order.Text = "PLACE ORDER";
            btn_order.UseVisualStyleBackColor = false;
            btn_order.Click += btn_order_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 352);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 28;
            label1.Text = "ADDRESS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(447, 86);
            label4.Name = "label4";
            label4.Size = new Size(116, 37);
            label4.TabIndex = 27;
            label4.Text = "CART ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(378, 293);
            label5.Name = "label5";
            label5.Size = new Size(166, 37);
            label5.TabIndex = 26;
            label5.Text = "TOTAL PRICE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 86);
            label8.Name = "label8";
            label8.Size = new Size(183, 37);
            label8.TabIndex = 25;
            label8.Text = "CUSTOMER ID:";
            // 
            // Address
            // 
            Address.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address.Location = new Point(142, 344);
            Address.Name = "Address";
            Address.Size = new Size(589, 51);
            Address.TabIndex = 29;
            Address.TextChanged += Address_TextChanged;
            // 
            // OrderReg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 666);
            ControlBox = false;
            Controls.Add(Address);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(btn_order);
            Controls.Add(PaymentMethod);
            Controls.Add(label7);
            Controls.Add(Date);
            Controls.Add(label6);
            Controls.Add(lblCartID);
            Controls.Add(dataGridView1);
            Controls.Add(TotalPrice);
            Controls.Add(label3);
            Controls.Add(lblCustomerID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderReg";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btn_back;
        private Panel panel1;
        private Button button1;
        private Label TotalPrice;
        private Label label3;
        private Label lblCustomerID;
        private DataGridView dataGridView1;
        private Label lblCartID;
        private DateTimePicker Date;
        private Label label6;
        private ComboBox PaymentMethod;
        private Label label7;
        private Button btn_order;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox Address;
    }
}