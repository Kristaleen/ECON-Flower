namespace ECON_Flower
{
    partial class OrderPanel
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
            dataGridViewOrders = new DataGridView();
            btn_save = new Button();
            txt_orderID = new TextBox();
            btn_orderId = new Button();
            dataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 107);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(520, 98);
            label1.TabIndex = 0;
            label1.Text = "MANAGE ORDER";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(12, 239);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.Size = new Size(1362, 249);
            dataGridViewOrders.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_save.BackColor = Color.FromArgb(255, 128, 0);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(1100, 695);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(274, 87);
            btn_save.TabIndex = 2;
            btn_save.Text = "SAVE CHANGES";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_orderID
            // 
            txt_orderID.Font = new Font("Impact", 20F);
            txt_orderID.Location = new Point(900, 121);
            txt_orderID.Name = "txt_orderID";
            txt_orderID.Size = new Size(282, 56);
            txt_orderID.TabIndex = 3;
            // 
            // btn_orderId
            // 
            btn_orderId.BackColor = Color.FromArgb(255, 128, 0);
            btn_orderId.FlatAppearance.BorderSize = 0;
            btn_orderId.FlatStyle = FlatStyle.Flat;
            btn_orderId.Font = new Font("Impact", 15F);
            btn_orderId.Location = new Point(1205, 121);
            btn_orderId.Name = "btn_orderId";
            btn_orderId.Size = new Size(169, 56);
            btn_orderId.TabIndex = 4;
            btn_orderId.Text = "VIEW";
            btn_orderId.UseVisualStyleBackColor = false;
            btn_orderId.Click += btn_orderId_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(18, 563);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1356, 126);
            dataGridView.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 30F);
            label2.Location = new Point(493, 112);
            label2.Name = "label2";
            label2.Size = new Size(401, 75);
            label2.TabIndex = 1;
            label2.Text = "ENTER ORDER ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20F);
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(206, 48);
            label3.TabIndex = 1;
            label3.Text = "ORDER LIST:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 20F);
            label4.Location = new Point(18, 512);
            label4.Name = "label4";
            label4.Size = new Size(249, 48);
            label4.TabIndex = 6;
            label4.Text = "PRODUCT LIST:";
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1411, 794);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(dataGridViewOrders);
            Controls.Add(btn_orderId);
            Controls.Add(txt_orderID);
            Controls.Add(btn_save);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderPanel";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewOrders;
        private Button btn_save;
        private TextBox txt_orderID;
        private Button btn_orderId;
        private DataGridView dataGridView;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}