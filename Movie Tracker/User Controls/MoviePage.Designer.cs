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
            textBox1 = new TextBox();
            movieLength = new TextBox();
            movieUserWatched = new CheckBox();
            movieUserWatchlist = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            movieName = new Label();
            movieRating = new Label();
            movieReviewCount = new TextBox();
            label1 = new Label();
            genresTextBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            directorTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)moviePoster).BeginInit();
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
            movieDesc.ReadOnly = true;
            movieDesc.Size = new Size(331, 160);
            movieDesc.TabIndex = 2;
            movieDesc.Text = "";
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
            movieLength.Location = new Point(19, 236);
            movieLength.Name = "movieLength";
            movieLength.ReadOnly = true;
            movieLength.Size = new Size(140, 16);
            movieLength.TabIndex = 5;
            movieLength.TextAlign = HorizontalAlignment.Center;
            // 
            // movieUserWatched
            // 
            movieUserWatched.Appearance = Appearance.Button;
            movieUserWatched.AutoSize = true;
            movieUserWatched.BackColor = Color.BlueViolet;
            movieUserWatched.FlatAppearance.BorderSize = 0;
            movieUserWatched.FlatStyle = FlatStyle.Flat;
            movieUserWatched.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            movieUserWatched.ForeColor = Color.White;
            movieUserWatched.Location = new Point(527, 73);
            movieUserWatched.Name = "movieUserWatched";
            movieUserWatched.Size = new Size(123, 35);
            movieUserWatched.TabIndex = 6;
            movieUserWatched.Text = " WATCHED ";
            movieUserWatched.UseVisualStyleBackColor = false;
            movieUserWatched.MouseClick += checkBox1_CheckedChanged;
            // 
            // movieUserWatchlist
            // 
            movieUserWatchlist.Appearance = Appearance.Button;
            movieUserWatchlist.AutoSize = true;
            movieUserWatchlist.BackColor = Color.BlueViolet;
            movieUserWatchlist.FlatStyle = FlatStyle.Flat;
            movieUserWatchlist.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            movieUserWatchlist.ForeColor = Color.White;
            movieUserWatchlist.Location = new Point(527, 114);
            movieUserWatchlist.Name = "movieUserWatchlist";
            movieUserWatchlist.Size = new Size(127, 35);
            movieUserWatchlist.TabIndex = 7;
            movieUserWatchlist.Text = "WATCHLIST";
            movieUserWatchlist.UseVisualStyleBackColor = false;
            movieUserWatchlist.MouseClick += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(527, 155);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 9;
            button1.Text = "REVIEW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(551, 192);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 21;
            label4.Text = "See all reviews";
            label4.Click += label4_Click;
            // 
            // movieName
            // 
            movieName.AutoSize = true;
            movieName.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            movieName.Location = new Point(179, 20);
            movieName.Name = "movieName";
            movieName.Size = new Size(138, 30);
            movieName.TabIndex = 22;
            movieName.Text = "Movie Name";
            // 
            // movieRating
            // 
            movieRating.AutoSize = true;
            movieRating.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            movieRating.ForeColor = Color.BlueViolet;
            movieRating.Location = new Point(527, 222);
            movieRating.Name = "movieRating";
            movieRating.Size = new Size(132, 30);
            movieRating.TabIndex = 23;
            movieRating.Text = "Rating: 5.55";
            // 
            // movieReviewCount
            // 
            movieReviewCount.BorderStyle = BorderStyle.None;
            movieReviewCount.Location = new Point(550, 255);
            movieReviewCount.Name = "movieReviewCount";
            movieReviewCount.ReadOnly = true;
            movieReviewCount.Size = new Size(100, 16);
            movieReviewCount.TabIndex = 24;
            movieReviewCount.Text = "10 total reviews";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 276);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 25;
            label1.Text = "Genres:";
            // 
            // genresTextBox
            // 
            genresTextBox.BackColor = SystemColors.Control;
            genresTextBox.BorderStyle = BorderStyle.None;
            genresTextBox.Location = new Point(94, 283);
            genresTextBox.Name = "genresTextBox";
            genresTextBox.ReadOnly = true;
            genresTextBox.Size = new Size(406, 25);
            genresTextBox.TabIndex = 26;
            genresTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 314);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 27;
            label2.Text = "Director:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 354);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 28;
            label3.Text = "Actors:";
            // 
            // directorTextBox
            // 
            directorTextBox.BackColor = SystemColors.Control;
            directorTextBox.BorderStyle = BorderStyle.None;
            directorTextBox.Location = new Point(106, 321);
            directorTextBox.Name = "directorTextBox";
            directorTextBox.ReadOnly = true;
            directorTextBox.Size = new Size(200, 25);
            directorTextBox.TabIndex = 29;
            directorTextBox.Text = "";
            // 
            // MoviePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(directorTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(genresTextBox);
            Controls.Add(label1);
            Controls.Add(movieReviewCount);
            Controls.Add(movieRating);
            Controls.Add(movieName);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(movieUserWatchlist);
            Controls.Add(movieUserWatched);
            Controls.Add(movieLength);
            Controls.Add(textBox1);
            Controls.Add(movieDesc);
            Controls.Add(moviePoster);
            Name = "MoviePage";
            Size = new Size(700, 408);
            Load += FormTest_Load;
            ((System.ComponentModel.ISupportInitialize)moviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox moviePoster;
        private RichTextBox movieDesc;
        private TextBox textBox1;
        private TextBox movieLength;
        private CheckBox movieUserWatched;
        private CheckBox movieUserWatchlist;
        private Button button1;
        private Label label4;
        private Label movieName;
        private Label movieRating;
        private TextBox movieReviewCount;
        private Label label1;
        private RichTextBox genresTextBox;
        private Label label2;
        private Label label3;
        private RichTextBox directorTextBox;
    }
}
