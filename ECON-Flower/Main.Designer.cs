namespace ECON_Flower
{
    partial class Main
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
            pnlContent = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            btn_order = new Button();
            btn_product = new Button();
            pnldisplay = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            loginPNL = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnldisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pnlContent);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(btn_order);
            panel1.Controls.Add(btn_product);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1678, 142);
            panel1.TabIndex = 2;
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(849, 148);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(805, 803);
            pnlContent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(471, 98);
            label1.TabIndex = 0;
            label1.Text = "FLOWER SHOP";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.R__2__removebg_preview;
            pictureBox1.Location = new Point(1476, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(1440, 95);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(165, 41);
            btn_login.TabIndex = 1;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_order
            // 
            btn_order.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_order.BackColor = Color.FromArgb(255, 192, 128);
            btn_order.FlatAppearance.BorderSize = 0;
            btn_order.FlatStyle = FlatStyle.Flat;
            btn_order.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order.Location = new Point(1051, 41);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(359, 82);
            btn_order.TabIndex = 2;
            btn_order.Text = "TRACK ORDER";
            btn_order.UseVisualStyleBackColor = false;
            btn_order.Click += btn_cart_Click;
            // 
            // btn_product
            // 
            btn_product.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_product.BackColor = Color.FromArgb(255, 192, 128);
            btn_product.FlatAppearance.BorderSize = 0;
            btn_product.FlatStyle = FlatStyle.Flat;
            btn_product.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_product.Location = new Point(699, 41);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(301, 82);
            btn_product.TabIndex = 1;
            btn_product.Text = "PRODUCTS";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // pnldisplay
            // 
            pnldisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnldisplay.BackColor = Color.FromArgb(255, 224, 192);
            pnldisplay.Controls.Add(label4);
            pnldisplay.Controls.Add(label3);
            pnldisplay.Controls.Add(label2);
            pnldisplay.Controls.Add(pictureBox2);
            pnldisplay.Location = new Point(12, 160);
            pnldisplay.Name = "pnldisplay";
            pnldisplay.Size = new Size(1654, 788);
            pnldisplay.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20F);
            label4.Location = new Point(73, 567);
            label4.Name = "label4";
            label4.Size = new Size(784, 45);
            label4.TabIndex = 3;
            label4.Text = "FLOWERS FOR EVERY SPECIAL EVENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Black", 53F, FontStyle.Bold);
            label3.Location = new Point(43, 373);
            label3.Name = "label3";
            label3.Size = new Size(1066, 150);
            label3.TabIndex = 1;
            label3.Text = "E-FLOWER SHOP!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial Black", 60F, FontStyle.Bold);
            label2.Location = new Point(37, 218);
            label2.Name = "label2";
            label2.Size = new Size(973, 169);
            label2.TabIndex = 0;
            label2.Text = "WELCOME TO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.R1;
            pictureBox2.Location = new Point(849, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(884, 666);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // loginPNL
            // 
            loginPNL.Location = new Point(861, 146);
            loginPNL.Name = "loginPNL";
            loginPNL.Size = new Size(805, 802);
            loginPNL.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1678, 956);
            Controls.Add(pnldisplay);
            Controls.Add(panel1);
            Controls.Add(loginPNL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnldisplay.ResumeLayout(false);
            pnldisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_login;
        private Button btn_order;
        private Button btn_product;
        private Label label1;
        private Panel pnlContent;
        private Panel pnldisplay;
        private Panel loginPNL;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label4;
    }
}