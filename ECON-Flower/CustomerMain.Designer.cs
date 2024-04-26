namespace ECON_Flower
{
    partial class CustomerMain
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
            paneldisplay = new Panel();
            btn_product = new Button();
            pnlContent = new Panel();
            panel1 = new Panel();
            lblCustomerID = new Label();
            label1 = new Label();
            Logout = new Button();
            lblCustomerName = new Label();
            label2 = new Label();
            paneldisplay.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paneldisplay
            // 
            paneldisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paneldisplay.BackColor = Color.FromArgb(255, 224, 192);
            paneldisplay.Controls.Add(lblCustomerID);
            paneldisplay.Controls.Add(label1);
            paneldisplay.Location = new Point(12, 158);
            paneldisplay.Name = "paneldisplay";
            paneldisplay.Size = new Size(1654, 788);
            paneldisplay.TabIndex = 6;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(255, 192, 128);
            btn_product.FlatAppearance.BorderSize = 0;
            btn_product.FlatStyle = FlatStyle.Flat;
            btn_product.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_product.Location = new Point(1084, 34);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(301, 82);
            btn_product.TabIndex = 1;
            btn_product.Text = "PRODUCTS";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(849, 148);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(805, 803);
            pnlContent.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(lblCustomerName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pnlContent);
            panel1.Controls.Add(btn_product);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1678, 142);
            panel1.TabIndex = 5;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Arial", 16F);
            lblCustomerID.Location = new Point(198, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(125, 36);
            lblCustomerID.TabIndex = 11;
            lblCustomerID.Text = "Cart ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F);
            label1.Location = new Point(-6, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 10;
            label1.Text = "Customer ID:";
            // 
            // Logout
            // 
            Logout.BackColor = Color.Transparent;
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.Location = new Point(1473, 46);
            Logout.Name = "Logout";
            Logout.Size = new Size(168, 42);
            Logout.TabIndex = 9;
            Logout.Text = "LOGOUT";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Impact", 50F);
            lblCustomerName.Location = new Point(210, 9);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(701, 122);
            lblCustomerName.TabIndex = 8;
            lblCustomerName.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 30F);
            label2.Location = new Point(34, 34);
            label2.Name = "label2";
            label2.Size = new Size(175, 75);
            label2.TabIndex = 7;
            label2.Text = "Hello!";
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 956);
            Controls.Add(panel1);
            Controls.Add(paneldisplay);
            Name = "CustomerMain";
            StartPosition = FormStartPosition.CenterScreen;
            paneldisplay.ResumeLayout(false);
            paneldisplay.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneldisplay;
        private Button btn_product;
        private Panel pnlContent;
        private Panel panel1;
        private Label lblCustomerName;
        private Label label2;
        private Button Logout;
        private Label label1;
        private Label lblCustomerID;
    }
}