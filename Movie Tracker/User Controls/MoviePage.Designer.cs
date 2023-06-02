namespace Movie_Tracker.User_Controls
{
    partial class MoviePage
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
            moviePoster = new PictureBox();
            movieDesc = new RichTextBox();
            movieName = new TextBox();
            textBox1 = new TextBox();
            movieLength = new TextBox();
            movieUserWatched = new CheckBox();
            movieUserWatchlist = new CheckBox();
            movieUserRating = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)moviePoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieUserRating).BeginInit();
            SuspendLayout();
            // 
            // moviePoster
            // 
            moviePoster.Location = new Point(19, 20);
            moviePoster.Name = "moviePoster";
            moviePoster.Size = new Size(140, 210);
            moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            moviePoster.TabIndex = 1;
            moviePoster.TabStop = false;
            // 
            // movieDesc
            // 
            movieDesc.BackColor = SystemColors.Control;
            movieDesc.BorderStyle = BorderStyle.None;
            movieDesc.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            movieDesc.Location = new Point(179, 70);
            movieDesc.Name = "movieDesc";
            movieDesc.Size = new Size(331, 160);
            movieDesc.TabIndex = 2;
            movieDesc.Text = "";
            // 
            // movieName
            // 
            movieName.BackColor = SystemColors.Control;
            movieName.BorderStyle = BorderStyle.None;
            movieName.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            movieName.Location = new Point(179, 20);
            movieName.Name = "movieName";
            movieName.Size = new Size(499, 28);
            movieName.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, -29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(499, 23);
            textBox1.TabIndex = 4;
            // 
            // movieLength
            // 
            movieLength.BackColor = SystemColors.Control;
            movieLength.BorderStyle = BorderStyle.None;
            movieLength.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            movieLength.Location = new Point(19, 245);
            movieLength.Name = "movieLength";
            movieLength.Size = new Size(140, 16);
            movieLength.TabIndex = 5;
            movieLength.TextAlign = HorizontalAlignment.Center;
            // 
            // movieUserWatched
            // 
            movieUserWatched.Appearance = Appearance.Button;
            movieUserWatched.AutoSize = true;
            movieUserWatched.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            movieUserWatched.Location = new Point(535, 70);
            movieUserWatched.Name = "movieUserWatched";
            movieUserWatched.Size = new Size(107, 35);
            movieUserWatched.TabIndex = 6;
            movieUserWatched.Text = "WATCHED";
            movieUserWatched.UseVisualStyleBackColor = true;
            movieUserWatched.MouseClick += checkBox1_CheckedChanged;
            // 
            // movieUserWatchlist
            // 
            movieUserWatchlist.Appearance = Appearance.Button;
            movieUserWatchlist.AutoSize = true;
            movieUserWatchlist.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            movieUserWatchlist.Location = new Point(535, 122);
            movieUserWatchlist.Name = "movieUserWatchlist";
            movieUserWatchlist.Size = new Size(118, 35);
            movieUserWatchlist.TabIndex = 7;
            movieUserWatchlist.Text = "WATCHLIST";
            movieUserWatchlist.UseVisualStyleBackColor = true;
            movieUserWatchlist.MouseClick += checkBox2_CheckedChanged;
            // 
            // movieUserRating
            // 
            movieUserRating.Location = new Point(535, 173);
            movieUserRating.Name = "movieUserRating";
            movieUserRating.Size = new Size(45, 23);
            movieUserRating.TabIndex = 8;
            // 
            // MoviePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(movieUserRating);
            Controls.Add(movieUserWatchlist);
            Controls.Add(movieUserWatched);
            Controls.Add(movieLength);
            Controls.Add(textBox1);
            Controls.Add(movieName);
            Controls.Add(movieDesc);
            Controls.Add(moviePoster);
            Name = "MoviePage";
            Size = new Size(700, 408);
            Load += FormTest_Load;
            ((System.ComponentModel.ISupportInitialize)moviePoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieUserRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox moviePoster;
        private RichTextBox movieDesc;
        private TextBox movieName;
        private TextBox textBox1;
        private TextBox movieLength;
        private CheckBox movieUserWatched;
        private CheckBox movieUserWatchlist;
        private NumericUpDown movieUserRating;
    }
}
