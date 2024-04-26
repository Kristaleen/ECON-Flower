namespace ECON_Flower
{
    partial class CustomerList
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            lblProductID = new Label();
            txtcustomerID = new TextBox();
            label1 = new Label();
            dataGridViewOrder = new DataGridView();
            btn_view = new Button();
            CID = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            dataGridViewProduct = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(677, 497);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lblProductID);
            panel2.Controls.Add(txtcustomerID);
            panel2.Location = new Point(12, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 108);
            panel2.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(405, 41);
            button2.Name = "button2";
            button2.Size = new Size(254, 53);
            button2.TabIndex = 14;
            button2.Text = "REMOVE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductID.Location = new Point(14, 5);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(474, 33);
            lblProductID.TabIndex = 3;
            lblProductID.Text = "ENTER CUSTOMER ID TO REMOVE:";
            // 
            // txtcustomerID
            // 
            txtcustomerID.Font = new Font("Arial", 20F);
            txtcustomerID.Location = new Point(14, 41);
            txtcustomerID.Name = "txtcustomerID";
            txtcustomerID.Size = new Size(331, 53);
            txtcustomerID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(530, 98);
            label1.TabIndex = 18;
            label1.Text = "CUSTOMER LIST";
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.AllowUserToDeleteRows = false;
            dataGridViewOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrder.BackgroundColor = Color.White;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(721, 215);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.RowHeadersWidth = 62;
            dataGridViewOrder.Size = new Size(647, 244);
            dataGridViewOrder.TabIndex = 19;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(255, 128, 0);
            btn_view.FlatAppearance.BorderSize = 2;
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_view.Location = new Point(376, 47);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(254, 53);
            btn_view.TabIndex = 14;
            btn_view.Text = "VIEW";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // CID
            // 
            CID.Font = new Font("Arial", 20F);
            CID.Location = new Point(13, 47);
            CID.Name = "CID";
            CID.Size = new Size(331, 53);
            CID.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btn_view);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CID);
            panel1.Location = new Point(721, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 114);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(300, 33);
            label2.TabIndex = 3;
            label2.Text = "ENTER CUSTOMER ID";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(721, 547);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersWidth = 62;
            dataGridViewProduct.Size = new Size(647, 215);
            dataGridViewProduct.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(721, 149);
            label3.Name = "label3";
            label3.Size = new Size(329, 63);
            label3.TabIndex = 21;
            label3.Text = "ORDER DETAILS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(721, 481);
            label4.Name = "label4";
            label4.Size = new Size(445, 63);
            label4.TabIndex = 22;
            label4.Text = "PRODUCT'S ORDERED:";
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1391, 774);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridViewProduct);
            Controls.Add(panel1);
            Controls.Add(dataGridViewOrder);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerList";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button2;
        private Label lblProductID;
        private TextBox txtcustomerID;
        private Label label1;
        private DataGridView dataGridViewOrder;
        private Button btn_view;
        private TextBox CID;
        private Panel panel1;
        private Label label2;
        private DataGridView dataGridViewProduct;
        private Label label3;
        private Label label4;
    }
}