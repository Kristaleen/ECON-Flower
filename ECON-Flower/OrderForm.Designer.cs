namespace ECON_Flower
{
    partial class OrderForm
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
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            TotalPrice = new Label();
            label6 = new Label();
            txtPaymentMethod = new ComboBox();
            btn_order = new Button();
            panel1 = new Panel();
            back = new Button();
            label5 = new Label();
            date = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 100);
            label1.Name = "label1";
            label1.Size = new Size(92, 37);
            label1.TabIndex = 1;
            label1.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(138, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(604, 51);
            txtEmail.TabIndex = 2;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(138, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(604, 149);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 166);
            label3.Name = "label3";
            label3.Size = new Size(96, 37);
            label3.TabIndex = 5;
            label3.Text = "ITEMS:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(274, 434);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(468, 51);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 442);
            label4.Name = "label4";
            label4.Size = new Size(243, 37);
            label4.TabIndex = 6;
            label4.Text = "DELIVERY ADDRESS:";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPrice.Location = new Point(409, 308);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(166, 37);
            TotalPrice.TabIndex = 8;
            TotalPrice.Text = "TOTAL PRICE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 505);
            label6.Name = "label6";
            label6.Size = new Size(231, 37);
            label6.TabIndex = 9;
            label6.Text = "PAYMENT METHOD:";
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.BackColor = Color.White;
            txtPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPaymentMethod.Font = new Font("Impact", 18F);
            txtPaymentMethod.FormattingEnabled = true;
            txtPaymentMethod.Items.AddRange(new object[] { "Card", "Cash" });
            txtPaymentMethod.Location = new Point(273, 500);
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.Size = new Size(469, 52);
            txtPaymentMethod.TabIndex = 10;
            // 
            // btn_order
            // 
            btn_order.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_order.BackColor = Color.FromArgb(192, 64, 0);
            btn_order.FlatAppearance.BorderSize = 0;
            btn_order.FlatStyle = FlatStyle.Flat;
            btn_order.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order.ForeColor = Color.White;
            btn_order.Location = new Point(484, 571);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(281, 92);
            btn_order.TabIndex = 11;
            btn_order.Text = "PLACE ORDER";
            btn_order.UseVisualStyleBackColor = false;
            btn_order.Click += btn_order_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(back);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 82);
            panel1.TabIndex = 12;
            // 
            // back
            // 
            back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.Location = new Point(671, 0);
            back.Name = "back";
            back.Size = new Size(107, 31);
            back.TabIndex = 4;
            back.Text = "BACK";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 369);
            label5.Name = "label5";
            label5.Size = new Size(190, 37);
            label5.TabIndex = 13;
            label5.Text = "DELIVERY DATE:";
            // 
            // date
            // 
            date.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Location = new Point(221, 359);
            date.Name = "date";
            date.Size = new Size(521, 51);
            date.TabIndex = 15;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(778, 666);
            ControlBox = false;
            Controls.Add(date);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btn_order);
            Controls.Add(txtPaymentMethod);
            Controls.Add(label6);
            Controls.Add(TotalPrice);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Label TotalPrice;
        private Label label6;
        private ComboBox txtPaymentMethod;
        private Button btn_order;
        private Panel panel1;
        private Label label5;
        private DateTimePicker date;
        private Button back;
    }
}