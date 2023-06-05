namespace Movie_Tracker
{
    partial class frmLogin
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
            logPassword = new TextBox();
            txtpassword = new Label();
            logUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(92, 355);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 20;
            label4.Text = "I don't have an account";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 297);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 19;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.Location = new Point(154, 254);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(119, 21);
            CheckbxShowPas.TabIndex = 18;
            CheckbxShowPas.Text = "Show Password";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // logPassword
            // 
            logPassword.BackColor = Color.WhiteSmoke;
            logPassword.BorderStyle = BorderStyle.None;
            logPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logPassword.Location = new Point(57, 220);
            logPassword.Multiline = true;
            logPassword.Name = "logPassword";
            logPassword.PasswordChar = '•';
            logPassword.Size = new Size(216, 28);
            logPassword.TabIndex = 15;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(57, 200);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(66, 17);
            txtpassword.TabIndex = 14;
            txtpassword.Text = "Password";
            // 
            // logUsername
            // 
            logUsername.BackColor = Color.WhiteSmoke;
            logUsername.BorderStyle = BorderStyle.None;
            logUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logUsername.Location = new Point(57, 159);
            logUsername.Multiline = true;
            logUsername.Name = "logUsername";
            logUsername.Size = new Size(216, 28);
            logUsername.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 139);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(57, 86);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 11;
            label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(330, 554);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(CheckbxShowPas);
            Controls.Add(logPassword);
            Controls.Add(txtpassword);
            Controls.Add(logUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private CheckBox CheckbxShowPas;
        private TextBox logPassword;
        private Label txtpassword;
        private TextBox logUsername;
        private Label label2;
        private Label label1;
    }
}