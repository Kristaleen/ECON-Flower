namespace ECON_Flower
{
    partial class LoginForm
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
            panel = new Panel();
            back = new Button();
            label1 = new Label();
            pnlregister = new Panel();
            login = new Button();
            email = new TextBox();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            create = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel.BackColor = Color.FromArgb(128, 64, 64);
            panel.Controls.Add(back);
            panel.Controls.Add(label1);
            panel.Controls.Add(pnlregister);
            panel.Location = new Point(0, -20);
            panel.Name = "panel";
            panel.Size = new Size(803, 103);
            panel.TabIndex = 0;
            // 
            // back
            // 
            back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            back.BackColor = Color.Transparent;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Cascadia Code Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.ActiveCaptionText;
            back.Location = new Point(738, 20);
            back.Name = "back";
            back.Size = new Size(65, 52);
            back.TabIndex = 22;
            back.Text = "x";
            back.TextAlign = ContentAlignment.TopCenter;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Nova", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(73, 33);
            label1.Name = "label1";
            label1.Size = new Size(270, 48);
            label1.TabIndex = 3;
            label1.Text = "LOGIN FORM";
            // 
            // pnlregister
            // 
            pnlregister.Location = new Point(4, 105);
            pnlregister.Name = "pnlregister";
            pnlregister.Size = new Size(801, 717);
            pnlregister.TabIndex = 7;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            login.BackColor = Color.FromArgb(192, 64, 0);
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ButtonHighlight;
            login.Location = new Point(343, 576);
            login.Name = "login";
            login.Size = new Size(402, 79);
            login.TabIndex = 0;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            email.BackColor = Color.WhiteSmoke;
            email.Font = new Font("Impact", 25F);
            email.Location = new Point(73, 225);
            email.Name = "email";
            email.Size = new Size(672, 68);
            email.TabIndex = 1;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            password.BackColor = Color.WhiteSmoke;
            password.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(73, 441);
            password.Name = "password";
            password.Size = new Size(672, 74);
            password.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 148);
            label2.Name = "label2";
            label2.Size = new Size(191, 56);
            label2.TabIndex = 4;
            label2.Text = "EMAIL :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 363);
            label3.Name = "label3";
            label3.Size = new Size(299, 56);
            label3.TabIndex = 5;
            label3.Text = "PASSWORD :";
            // 
            // create
            // 
            create.BackColor = Color.FromArgb(255, 128, 0);
            create.FlatAppearance.BorderSize = 0;
            create.FlatStyle = FlatStyle.Flat;
            create.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            create.ForeColor = SystemColors.ButtonHighlight;
            create.Location = new Point(343, 693);
            create.Name = "create";
            create.Size = new Size(402, 79);
            create.TabIndex = 6;
            create.Text = "CREATE ACCOUNT";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(803, 800);
            ControlBox = false;
            Controls.Add(create);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(login);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button login;
        private TextBox email;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlregister;
        private Button create;
        private Button back;
    }
}