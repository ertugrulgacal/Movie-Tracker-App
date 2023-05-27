namespace MovieReviewFormApp
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
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkboxShowPass = new System.Windows.Forms.CheckBox();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dont Have an Account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(35, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkboxShowPass
            // 
            this.checkboxShowPass.AutoSize = true;
            this.checkboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxShowPass.Location = new System.Drawing.Point(101, 248);
            this.checkboxShowPass.Name = "checkboxShowPass";
            this.checkboxShowPass.Size = new System.Drawing.Size(151, 27);
            this.checkboxShowPass.TabIndex = 18;
            this.checkboxShowPass.Text = "Show Password";
            this.checkboxShowPass.UseVisualStyleBackColor = true;
            this.checkboxShowPass.CheckedChanged += new System.EventHandler(this.checkboxShowPass_CheckedChanged);
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtLogPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPassword.Location = new System.Drawing.Point(36, 198);
            this.txtLogPassword.Multiline = true;
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.PasswordChar = '•';
            this.txtLogPassword.Size = new System.Drawing.Size(216, 28);
            this.txtLogPassword.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtLogUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUsername.Location = new System.Drawing.Point(36, 129);
            this.txtLogUsername.Multiline = true;
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.Size = new System.Drawing.Size(216, 28);
            this.txtLogUsername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Get Started";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(80, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Create Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkboxShowPass);
            this.Controls.Add(this.txtLogPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}