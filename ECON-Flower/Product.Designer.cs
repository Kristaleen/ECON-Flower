
namespace ECON_Flower
{
    partial class Product
    {
        private Panel panel;
        private Panel pnlregister;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

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
            panel = new Panel();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlregister = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnl_cart = new Panel();
            TotalPrice = new Label();
            btn_order = new Button();
            label1 = new Label();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_cart.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(128, 64, 64);
            panel.Controls.Add(button6);
            panel.Controls.Add(pictureBox1);
            panel.Controls.Add(button4);
            panel.Controls.Add(button3);
            panel.Controls.Add(button2);
            panel.Controls.Add(button1);
            panel.Controls.Add(pnlregister);
            panel.Dock = DockStyle.Top;
            panel.Font = new Font("Impact", 15F);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1652, 106);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 13F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1420, 66);
            button6.Name = "button6";
            button6.Size = new Size(176, 37);
            button6.TabIndex = 11;
            button6.Text = "CART";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.R__1_;
            pictureBox1.Location = new Point(1420, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 15F);
            button4.Location = new Point(1034, 12);
            button4.Name = "button4";
            button4.Size = new Size(319, 84);
            button4.TabIndex = 9;
            button4.Text = "NEW BORN";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 15F);
            button3.Location = new Point(684, 12);
            button3.Name = "button3";
            button3.Size = new Size(319, 84);
            button3.TabIndex = 8;
            button3.Text = "WEDDING";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 15F);
            button2.Location = new Point(338, 12);
            button2.Name = "button2";
            button2.Size = new Size(319, 84);
            button2.TabIndex = 4;
            button2.Text = "ANNIVERSARY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 15F);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(305, 84);
            button1.TabIndex = 3;
            button1.Text = "BIRTHDAY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlregister
            // 
            pnlregister.Location = new Point(4, 105);
            pnlregister.Name = "pnlregister";
            pnlregister.Size = new Size(801, 717);
            pnlregister.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 128, 0);
            flowLayoutPanel1.Location = new Point(7, 112);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1637, 668);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Location = new Point(6, 77);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(789, 442);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // pnl_cart
            // 
            pnl_cart.BackColor = Color.FromArgb(192, 64, 0);
            pnl_cart.Controls.Add(TotalPrice);
            pnl_cart.Controls.Add(btn_order);
            pnl_cart.Controls.Add(label1);
            pnl_cart.Controls.Add(flowLayoutPanel2);
            pnl_cart.Location = new Point(844, 112);
            pnl_cart.Name = "pnl_cart";
            pnl_cart.Size = new Size(800, 668);
            pnl_cart.TabIndex = 4;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.BackColor = Color.Transparent;
            TotalPrice.FlatStyle = FlatStyle.Flat;
            TotalPrice.Font = new Font("Impact", 25F);
            TotalPrice.ForeColor = Color.White;
            TotalPrice.Location = new Point(6, 522);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(255, 63);
            TotalPrice.TabIndex = 7;
            TotalPrice.Text = "Total Price:";
            // 
            // btn_order
            // 
            btn_order.BackColor = Color.FromArgb(255, 128, 0);
            btn_order.FlatAppearance.BorderSize = 0;
            btn_order.FlatStyle = FlatStyle.Flat;
            btn_order.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order.ForeColor = Color.Black;
            btn_order.Location = new Point(529, 593);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(256, 69);
            btn_order.TabIndex = 5;
            btn_order.Text = "ORDER";
            btn_order.UseVisualStyleBackColor = false;
            btn_order.Click += btn_order_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(224, 5);
            label1.Name = "label1";
            label1.Size = new Size(377, 68);
            label1.TabIndex = 4;
            label1.Text = "SHOPPING CART";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1652, 786);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel);
            Controls.Add(pnl_cart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Product";
            WindowState = FormWindowState.Maximized;
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_cart.ResumeLayout(false);
            pnl_cart.PerformLayout();
            ResumeLayout(false);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

#endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button6;
        private Panel pnl_cart;
        private Label label1;
        private Button btn_order;
        private PictureBox pictureBox1;
        private Label TotalPrice;
    }
}
