namespace MovieReviewFormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegComPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkboxShowPass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsername.Location = new System.Drawing.Point(37, 126);
            this.txtRegUsername.Multiline = true;
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(216, 32);
            this.txtRegUsername.TabIndex = 2;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.Location = new System.Drawing.Point(37, 195);
            this.txtRegPassword.Multiline = true;
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '•';
            this.txtRegPassword.Size = new System.Drawing.Size(216, 32);
            this.txtRegPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtRegComPassword
            // 
            this.txtRegComPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegComPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegComPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegComPassword.Location = new System.Drawing.Point(37, 265);
            this.txtRegComPassword.Multiline = true;
            this.txtRegComPassword.Name = "txtRegComPassword";
            this.txtRegComPassword.PasswordChar = '•';
            this.txtRegComPassword.Size = new System.Drawing.Size(216, 32);
            this.txtRegComPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // checkboxShowPass
            // 
            this.checkboxShowPass.AutoSize = true;
            this.checkboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxShowPass.Location = new System.Drawing.Point(102, 307);
            this.checkboxShowPass.Name = "checkboxShowPass";
            this.checkboxShowPass.Size = new System.Drawing.Size(151, 27);
            this.checkboxShowPass.TabIndex = 7;
            this.checkboxShowPass.Text = "Show Password";
            this.checkboxShowPass.UseVisualStyleBackColor = true;
            this.checkboxShowPass.CheckedChanged += new System.EventHandler(this.checkboxShowPass_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(37, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already Have an Account";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkboxShowPass);
            this.Controls.Add(this.txtRegComPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegComPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}