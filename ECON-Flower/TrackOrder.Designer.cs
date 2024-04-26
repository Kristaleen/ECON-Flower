namespace ECON_Flower
{
    partial class TrackOrder
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            OrderID = new Label();
            pnl_order = new Panel();
            Date = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            TotalPrice = new Label();
            OrderDate = new Label();
            Status = new Label();
            btn_enter = new Button();
            pnl_cancel = new Panel();
            label9 = new Label();
            btn_cancel = new Button();
            txtCancel = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            pnl_order.SuspendLayout();
            pnl_cancel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1652, 174);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 44);
            label1.Name = "label1";
            label1.Size = new Size(506, 98);
            label1.TabIndex = 0;
            label1.Text = "ORDER DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 212);
            label2.Name = "label2";
            label2.Size = new Size(277, 48);
            label2.TabIndex = 1;
            label2.Text = "ENTER ORDER ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(313, 206);
            txtID.Name = "txtID";
            txtID.Size = new Size(258, 61);
            txtID.TabIndex = 2;
            // 
            // OrderID
            // 
            OrderID.AutoSize = true;
            OrderID.BackColor = Color.Transparent;
            OrderID.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderID.ForeColor = Color.White;
            OrderID.Location = new Point(350, 35);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(266, 48);
            OrderID.TabIndex = 4;
            OrderID.Text = "ORDER NUMBER";
            // 
            // pnl_order
            // 
            pnl_order.BackColor = Color.FromArgb(255, 128, 0);
            pnl_order.Controls.Add(Date);
            pnl_order.Controls.Add(label5);
            pnl_order.Controls.Add(label3);
            pnl_order.Controls.Add(label4);
            pnl_order.Controls.Add(label6);
            pnl_order.Controls.Add(label7);
            pnl_order.Controls.Add(TotalPrice);
            pnl_order.Controls.Add(OrderDate);
            pnl_order.Controls.Add(Status);
            pnl_order.Controls.Add(OrderID);
            pnl_order.Location = new Point(669, 206);
            pnl_order.Name = "pnl_order";
            pnl_order.Size = new Size(879, 524);
            pnl_order.TabIndex = 5;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.Transparent;
            Date.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.ForeColor = Color.White;
            Date.Location = new Point(350, 204);
            Date.Name = "Date";
            Date.Size = new Size(246, 48);
            Date.TabIndex = 15;
            Date.Text = "DELIVERY DATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 204);
            label5.Name = "label5";
            label5.Size = new Size(254, 48);
            label5.TabIndex = 14;
            label5.Text = "DELIVERY DATE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 300);
            label3.Name = "label3";
            label3.Size = new Size(219, 48);
            label3.TabIndex = 13;
            label3.Text = "TOTAL PRICE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 121);
            label4.Name = "label4";
            label4.Size = new Size(215, 48);
            label4.TabIndex = 12;
            label4.Text = "ORDER DATE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 392);
            label6.Name = "label6";
            label6.Size = new Size(256, 48);
            label6.TabIndex = 10;
            label6.Text = "ORDER STATUS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 35);
            label7.Name = "label7";
            label7.Size = new Size(274, 48);
            label7.TabIndex = 9;
            label7.Text = "ORDER NUMBER:";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.BackColor = Color.Transparent;
            TotalPrice.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPrice.ForeColor = Color.White;
            TotalPrice.Location = new Point(346, 300);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(211, 48);
            TotalPrice.TabIndex = 8;
            TotalPrice.Text = "TOTAL PRICE";
            // 
            // OrderDate
            // 
            OrderDate.AutoSize = true;
            OrderDate.BackColor = Color.Transparent;
            OrderDate.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderDate.ForeColor = Color.White;
            OrderDate.Location = new Point(350, 121);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(207, 48);
            OrderDate.TabIndex = 7;
            OrderDate.Text = "ORDER DATE";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.BackColor = Color.Transparent;
            Status.Font = new Font("Impact", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.White;
            Status.Location = new Point(346, 392);
            Status.Name = "Status";
            Status.Size = new Size(248, 48);
            Status.TabIndex = 5;
            Status.Text = "ORDER STATUS";
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.FromArgb(192, 64, 0);
            btn_enter.FlatStyle = FlatStyle.Flat;
            btn_enter.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_enter.ForeColor = Color.White;
            btn_enter.Location = new Point(313, 299);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(194, 61);
            btn_enter.TabIndex = 6;
            btn_enter.Text = "ENTER";
            btn_enter.UseVisualStyleBackColor = false;
            btn_enter.Click += btn_enter_Click;
            // 
            // pnl_cancel
            // 
            pnl_cancel.BackColor = Color.Transparent;
            pnl_cancel.Controls.Add(label9);
            pnl_cancel.Controls.Add(btn_cancel);
            pnl_cancel.Controls.Add(txtCancel);
            pnl_cancel.Controls.Add(label8);
            pnl_cancel.Location = new Point(30, 394);
            pnl_cancel.Name = "pnl_cancel";
            pnl_cancel.Size = new Size(599, 331);
            pnl_cancel.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 30);
            label9.Name = "label9";
            label9.Size = new Size(271, 48);
            label9.TabIndex = 11;
            label9.Text = "CANCEL ORDER?";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(192, 64, 0);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(283, 222);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(194, 61);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // txtCancel
            // 
            txtCancel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCancel.Location = new Point(283, 126);
            txtCancel.Name = "txtCancel";
            txtCancel.Size = new Size(258, 61);
            txtCancel.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 126);
            label8.Name = "label8";
            label8.Size = new Size(277, 48);
            label8.TabIndex = 8;
            label8.Text = "ENTER ORDER ID:";
            // 
            // TrackOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1652, 786);
            ControlBox = false;
            Controls.Add(pnl_cancel);
            Controls.Add(btn_enter);
            Controls.Add(pnl_order);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TrackOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl_order.ResumeLayout(false);
            pnl_order.PerformLayout();
            pnl_cancel.ResumeLayout(false);
            pnl_cancel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Label OrderID;
        private Panel pnl_order;
        private Label Status;
        private Button btn_enter;
        private Label OrderDate;
        private Label TotalPrice;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label Date;
        private Label label5;
        private Panel pnl_cancel;
        private Label label9;
        private Button btn_cancel;
        private TextBox txtCancel;
        private Label label8;
    }
}