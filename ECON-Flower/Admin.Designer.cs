namespace ECON_Flower
{
    partial class Admin
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
            panel2 = new Panel();
            btn_main = new Button();
            btn_logout = new Button();
            btn_orderlist = new Button();
            btn_product = new Button();
            btn_customer = new Button();
            pnldisplay = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnldisplay.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1678, 142);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(418, 98);
            label1.TabIndex = 0;
            label1.Text = "ADMIN PAGE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btn_main);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_orderlist);
            panel2.Controls.Add(btn_product);
            panel2.Controls.Add(btn_customer);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 814);
            panel2.TabIndex = 7;
            // 
            // btn_main
            // 
            btn_main.BackColor = Color.FromArgb(255, 128, 0);
            btn_main.FlatAppearance.BorderSize = 0;
            btn_main.FlatStyle = FlatStyle.Flat;
            btn_main.Font = new Font("Impact", 11.5F);
            btn_main.Location = new Point(10, 35);
            btn_main.Name = "btn_main";
            btn_main.Size = new Size(223, 64);
            btn_main.TabIndex = 12;
            btn_main.Text = "VIEW PRODUCT DISPLAY";
            btn_main.UseVisualStyleBackColor = false;
            btn_main.Click += btn_main_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(255, 128, 0);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(10, 706);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(223, 64);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "LOGOUT";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_orderlist
            // 
            btn_orderlist.BackColor = Color.FromArgb(255, 128, 0);
            btn_orderlist.FlatAppearance.BorderSize = 0;
            btn_orderlist.FlatStyle = FlatStyle.Flat;
            btn_orderlist.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_orderlist.Location = new Point(10, 254);
            btn_orderlist.Name = "btn_orderlist";
            btn_orderlist.Size = new Size(223, 64);
            btn_orderlist.TabIndex = 10;
            btn_orderlist.Text = "ORDER LIST";
            btn_orderlist.UseVisualStyleBackColor = false;
            btn_orderlist.Click += btn_orderlist_Click;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(255, 128, 0);
            btn_product.FlatAppearance.BorderSize = 0;
            btn_product.FlatStyle = FlatStyle.Flat;
            btn_product.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_product.Location = new Point(10, 144);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(223, 64);
            btn_product.TabIndex = 9;
            btn_product.Text = "PRODUCT LIST";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // btn_customer
            // 
            btn_customer.BackColor = Color.FromArgb(255, 128, 0);
            btn_customer.FlatAppearance.BorderSize = 0;
            btn_customer.FlatStyle = FlatStyle.Flat;
            btn_customer.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_customer.Location = new Point(10, 367);
            btn_customer.Name = "btn_customer";
            btn_customer.Size = new Size(223, 64);
            btn_customer.TabIndex = 8;
            btn_customer.Text = "CUSTOMER LIST";
            btn_customer.UseVisualStyleBackColor = false;
            btn_customer.Click += btn_customer_Click;
            // 
            // pnldisplay
            // 
            pnldisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnldisplay.BackColor = Color.FromArgb(255, 224, 192);
            pnldisplay.Controls.Add(label4);
            pnldisplay.Controls.Add(label3);
            pnldisplay.Location = new Point(253, 151);
            pnldisplay.Name = "pnldisplay";
            pnldisplay.Size = new Size(1413, 796);
            pnldisplay.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20F);
            label4.Location = new Point(203, 473);
            label4.Name = "label4";
            label4.Size = new Size(784, 45);
            label4.TabIndex = 5;
            label4.Text = "FLOWERS FOR EVERY SPECIAL EVENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Black", 53F, FontStyle.Bold);
            label3.Location = new Point(173, 279);
            label3.Name = "label3";
            label3.Size = new Size(1066, 150);
            label3.TabIndex = 4;
            label3.Text = "E-FLOWER SHOP!";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 956);
            Controls.Add(pnldisplay);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnldisplay.ResumeLayout(false);
            pnldisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_customer;
        private Button btn_logout;
        private Button btn_orderlist;
        private Button btn_product;
        private Panel pnldisplay;
        private Button btn_main;
        private Label label4;
        private Label label3;
    }
}