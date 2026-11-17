namespace NoteSpaceForm
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLoginCard = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            lblBrand = new Label();
            lblDescription = new Label();
            lblInfo = new Label();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.FromArgb(245, 241, 234);
            pnlLoginCard.Controls.Add(btnExit);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(lblUsername);
            pnlLoginCard.Controls.Add(lblSubtitle);
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Location = new Point(540, 65);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(380, 450);
            pnlLoginCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(37, 44, 67);
            lblTitle.Location = new Point(51, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NoteSpace";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 100, 110);
            lblSubtitle.Location = new Point(75, 100);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(176, 32);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Welcome Back!";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(40, 159);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(40, 190);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 37);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(40, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 37);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(40, 254);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(99, 67, 190);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(40, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(245, 202, 98);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(37, 44, 67);
            btnExit.Location = new Point(40, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(300, 35);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(94, 159);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(390, 86);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "NoteSpace";
            lblBrand.Click += lblBrand_Click;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(245, 202, 98);
            lblDescription.Location = new Point(105, 245);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(350, 40);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Your ideas, your space.";
            lblDescription.Click += label1_Click_1;
            // 
            // lblInfo
            // 
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(105, 300);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(361, 65);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Organize your notes and make ever day productive.";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 44, 67);
            ClientSize = new Size(1076, 609);
            Controls.Add(lblInfo);
            Controls.Add(lblDescription);
            Controls.Add(lblBrand);
            Controls.Add(pnlLoginCard);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteSpace-Login";
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button button2;
        private Button btnExit;
        private Label lblBrand;
        private Label lblDescription;
        private Label lblInfo;
        private Button button3;
    }
}
