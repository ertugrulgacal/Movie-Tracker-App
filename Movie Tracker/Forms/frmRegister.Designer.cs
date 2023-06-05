namespace Movie_Tracker
{
    partial class frmRegister
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
            label4 = new Label();
            button1 = new Button();
            CheckbxShowPas = new CheckBox();
            regPassword = new TextBox();
            txtpassword = new Label();
            regUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            regConPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(84, 420);
            label4.Name = "label4";
            label4.Size = new Size(165, 17);
            label4.TabIndex = 28;
            label4.Text = "I already have an account";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 362);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 27;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.Location = new Point(154, 320);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(119, 21);
            CheckbxShowPas.TabIndex = 26;
            CheckbxShowPas.Text = "Show Password";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // regPassword
            // 
            regPassword.BackColor = Color.WhiteSmoke;
            regPassword.BorderStyle = BorderStyle.None;
            regPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            regPassword.Location = new Point(57, 221);
            regPassword.Multiline = true;
            regPassword.Name = "regPassword";
            regPassword.PasswordChar = '•';
            regPassword.Size = new Size(216, 28);
            regPassword.TabIndex = 25;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(57, 201);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(66, 17);
            txtpassword.TabIndex = 24;
            txtpassword.Text = "Password";
            // 
            // regUsername
            // 
            regUsername.BackColor = Color.WhiteSmoke;
            regUsername.BorderStyle = BorderStyle.None;
            regUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            regUsername.Location = new Point(57, 160);
            regUsername.Multiline = true;
            regUsername.Name = "regUsername";
            regUsername.Size = new Size(216, 28);
            regUsername.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 140);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 22;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(57, 87);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 21;
            label1.Text = "Get Started";
            // 
            // regConPassword
            // 
            regConPassword.BackColor = Color.WhiteSmoke;
            regConPassword.BorderStyle = BorderStyle.None;
            regConPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            regConPassword.Location = new Point(57, 286);
            regConPassword.Multiline = true;
            regConPassword.Name = "regConPassword";
            regConPassword.PasswordChar = '•';
            regConPassword.Size = new Size(216, 28);
            regConPassword.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 266);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 29;
            label3.Text = "Confirm Password";
            label3.Click += label3_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(330, 554);
            Controls.Add(regConPassword);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(CheckbxShowPas);
            Controls.Add(regPassword);
            Controls.Add(txtpassword);
            Controls.Add(regUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private CheckBox CheckbxShowPas;
        private TextBox regPassword;
        private Label txtpassword;
        private TextBox regUsername;
        private Label label2;
        private Label label1;
        private TextBox regConPassword;
        private Label label3;
    }
}