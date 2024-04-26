namespace ECON_Flower
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductImage = new PictureBox();
            ProductName = new Label();
            Description = new Label();
            Price = new Label();
            btn_add = new Button();
            ProductID = new Label();
            btn_remove = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // ProductImage
            // 
            ProductImage.Location = new Point(12, 18);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(187, 172);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 0;
            ProductImage.TabStop = false;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Arial Black", 15F, FontStyle.Bold);
            ProductName.Location = new Point(205, 38);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(288, 42);
            ProductName.TabIndex = 1;
            ProductName.Text = "PRODUCT NAME";
            ProductName.Click += ProductName_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Arial", 10F);
            Description.Location = new Point(210, 91);
            Description.Name = "Description";
            Description.Size = new Size(108, 23);
            Description.TabIndex = 2;
            Description.Text = "Description";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.Location = new Point(210, 145);
            Price.Name = "Price";
            Price.Size = new Size(84, 27);
            Price.TabIndex = 3;
            Price.Text = "PRICE";
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add.BackColor = Color.FromArgb(64, 0, 0);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(631, 122);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(135, 64);
            btn_add.TabIndex = 4;
            btn_add.Text = "ADD TO CART";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // ProductID
            // 
            ProductID.AutoSize = true;
            ProductID.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductID.Location = new Point(349, 17);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(104, 24);
            ProductID.TabIndex = 5;
            ProductID.Text = "ProductID";
            // 
            // btn_remove
            // 
            btn_remove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_remove.BackColor = Color.Transparent;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.Black;
            btn_remove.Location = new Point(713, 3);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(68, 49);
            btn_remove.TabIndex = 6;
            btn_remove.Text = "X";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 17);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 7;
            label1.Text = "PRODUCT ID:";
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(label1);
            Controls.Add(btn_remove);
            Controls.Add(ProductID);
            Controls.Add(btn_add);
            Controls.Add(Price);
            Controls.Add(Description);
            Controls.Add(ProductName);
            Controls.Add(ProductImage);
            Name = "ProductControl";
            Size = new Size(783, 204);
            Load += ProductControl_Load;
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProductImage;
        private Label ProductName;
        private Label Description;
        private Label Price;
        private Button btn_add;
        private Label ProductID;
        private Button btn_remove;
        private Label label1;
    }
}
