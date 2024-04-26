
namespace ECON_Flower
{
    partial class ProductList
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label2 = new Label();
            txt_description = new TextBox();
            label3 = new Label();
            txt_price = new TextBox();
            label4 = new Label();
            txt_categoryid = new TextBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            label5 = new Label();
            btn_upload = new Button();
            btn_add = new Button();
            panel1 = new Panel();
            txt_productname = new TextBox();
            panel2 = new Panel();
            btn_remove = new Button();
            lblProductID = new Label();
            txtProductID = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(613, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(766, 687);
            dataGridView1.TabIndex = 1;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(210, 27);
            label2.TabIndex = 3;
            label2.Text = "PRODUCT NAME:";
            // 
            // txt_description
            // 
            txt_description.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_description.Location = new Point(228, 77);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(330, 35);
            txt_description.TabIndex = 6;
            txt_description.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 5;
            label3.Text = "DESCRIPTION:";
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_price.Location = new Point(228, 129);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(330, 35);
            txt_price.TabIndex = 8;
            txt_price.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(91, 27);
            label4.TabIndex = 7;
            label4.Text = "PRICE:";
            // 
            // txt_categoryid
            // 
            txt_categoryid.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_categoryid.Location = new Point(228, 183);
            txt_categoryid.Name = "txt_categoryid";
            txt_categoryid.Size = new Size(330, 35);
            txt_categoryid.TabIndex = 10;
            txt_categoryid.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 183);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 9;
            label1.Text = "CATEGORY ID:";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox.Location = new Point(228, 233);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(150, 95);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 11;
            pictureBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(94, 27);
            label5.TabIndex = 12;
            label5.Text = "IMAGE:";
            // 
            // btn_upload
            // 
            btn_upload.BackColor = Color.Transparent;
            btn_upload.FlatAppearance.BorderSize = 0;
            btn_upload.FlatStyle = FlatStyle.Flat;
            btn_upload.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_upload.Location = new Point(228, 329);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(168, 34);
            btn_upload.TabIndex = 13;
            btn_upload.Text = "UPLOAD IMAGE";
            btn_upload.UseVisualStyleBackColor = false;
            btn_upload.Click += btn_upload_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(192, 64, 0);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(304, 369);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(254, 68);
            btn_add.TabIndex = 14;
            btn_add.Text = "ADD PRODUCT";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_upload);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_productname);
            panel1.Controls.Add(txt_categoryid);
            panel1.Controls.Add(txt_description);
            panel1.Controls.Add(txt_price);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 454);
            panel1.TabIndex = 15;
            // 
            // txt_productname
            // 
            txt_productname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_productname.Location = new Point(228, 27);
            txt_productname.Name = "txt_productname";
            txt_productname.Size = new Size(330, 35);
            txt_productname.TabIndex = 4;
            txt_productname.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 64, 0);
            panel2.Controls.Add(btn_remove);
            panel2.Controls.Add(lblProductID);
            panel2.Controls.Add(txtProductID);
            panel2.Location = new Point(14, 483);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 216);
            panel2.TabIndex = 16;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(255, 128, 0);
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.Location = new Point(304, 128);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(254, 68);
            btn_remove.TabIndex = 14;
            btn_remove.Text = "REMOVE";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductID.Location = new Point(5, 5);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(546, 42);
            lblProductID.TabIndex = 3;
            lblProductID.Text = "ENTER PRODUCT ID TO DELETE";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Arial", 20F);
            txtProductID.Location = new Point(9, 56);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(409, 53);
            txtProductID.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1163, 708);
            button1.Name = "button1";
            button1.Size = new Size(216, 57);
            button1.TabIndex = 17;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 774);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductList";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        #endregion

        private DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label2;
        private TextBox txt_description;
        private Label label3;
        private TextBox txt_price;
        private Label label4;
        private TextBox txt_categoryid;
        private Label label1;
        private PictureBox pictureBox;
        private Label label5;
        private Button btn_upload;
        private Button btn_add;
        private Panel panel1;
        private Panel panel2;
        private Button btn_remove;
        private Label lblProductID;
        private TextBox txtProductID;
        private TextBox txt_productname;
        private Button button1;
    }
}