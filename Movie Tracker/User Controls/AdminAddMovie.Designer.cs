namespace Movie_Tracker.User_Controls
{
    partial class AdminAddMovie
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
            label1 = new Label();
            movTitle = new TextBox();
            movDesc = new TextBox();
            label2 = new Label();
            movYear = new TextBox();
            label3 = new Label();
            movLength = new TextBox();
            label4 = new Label();
            movLanguage = new TextBox();
            label5 = new Label();
            movPoster = new TextBox();
            label6 = new Label();
            button1 = new Button();
            moviePoster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)moviePoster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // movTitle
            // 
            movTitle.Location = new Point(75, 32);
            movTitle.Name = "movTitle";
            movTitle.Size = new Size(312, 23);
            movTitle.TabIndex = 6;
            // 
            // movDesc
            // 
            movDesc.Location = new Point(115, 61);
            movDesc.Name = "movDesc";
            movDesc.Size = new Size(272, 23);
            movDesc.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(35, 67);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = "Description:";
            // 
            // movYear
            // 
            movYear.Location = new Point(75, 90);
            movYear.Name = "movYear";
            movYear.Size = new Size(312, 23);
            movYear.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(35, 96);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Year:";
            // 
            // movLength
            // 
            movLength.Location = new Point(90, 119);
            movLength.Name = "movLength";
            movLength.Size = new Size(297, 23);
            movLength.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(35, 125);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Length:";
            // 
            // movLanguage
            // 
            movLanguage.Location = new Point(104, 148);
            movLanguage.Name = "movLanguage";
            movLanguage.Size = new Size(283, 23);
            movLanguage.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.BlueViolet;
            label5.Location = new Point(35, 154);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 13;
            label5.Text = "Language:";
            // 
            // movPoster
            // 
            movPoster.Location = new Point(113, 177);
            movPoster.Name = "movPoster";
            movPoster.Size = new Size(274, 23);
            movPoster.TabIndex = 16;
            movPoster.TextChanged += Poster_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.BlueViolet;
            label6.Location = new Point(35, 183);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 15;
            label6.Text = "Poster URL:";
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(606, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 17;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // moviePoster
            // 
            moviePoster.Location = new Point(542, 16);
            moviePoster.Name = "moviePoster";
            moviePoster.Size = new Size(140, 210);
            moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            moviePoster.TabIndex = 18;
            moviePoster.TabStop = false;
            // 
            // AdminAddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(moviePoster);
            Controls.Add(button1);
            Controls.Add(movPoster);
            Controls.Add(label6);
            Controls.Add(movLanguage);
            Controls.Add(label5);
            Controls.Add(movLength);
            Controls.Add(label4);
            Controls.Add(movYear);
            Controls.Add(label3);
            Controls.Add(movDesc);
            Controls.Add(label2);
            Controls.Add(movTitle);
            Controls.Add(label1);
            Name = "AdminAddMovie";
            Size = new Size(700, 408);
            ((System.ComponentModel.ISupportInitialize)moviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox movTitle;
        private TextBox movDesc;
        private Label label2;
        private TextBox movYear;
        private Label label3;
        private TextBox movLength;
        private Label label4;
        private TextBox movLanguage;
        private Label label5;
        private TextBox movPoster;
        private Label label6;
        private Button button1;
        private PictureBox moviePoster;
    }
}
