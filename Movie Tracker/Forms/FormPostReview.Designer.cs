namespace Movie_Tracker.Forms
{
    partial class FormPostReview
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
            reviewMoviePoster = new PictureBox();
            reviewText = new RichTextBox();
            movieRating = new NumericUpDown();
            button1 = new Button();
            reviewMovieTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)reviewMoviePoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieRating).BeginInit();
            SuspendLayout();
            // 
            // reviewMoviePoster
            // 
            reviewMoviePoster.Location = new Point(12, 12);
            reviewMoviePoster.Name = "reviewMoviePoster";
            reviewMoviePoster.Size = new Size(140, 210);
            reviewMoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            reviewMoviePoster.TabIndex = 2;
            reviewMoviePoster.TabStop = false;
            // 
            // reviewText
            // 
            reviewText.BackColor = Color.Gainsboro;
            reviewText.BorderStyle = BorderStyle.None;
            reviewText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reviewText.Location = new Point(172, 62);
            reviewText.Name = "reviewText";
            reviewText.Size = new Size(490, 123);
            reviewText.TabIndex = 4;
            reviewText.Text = "";
            // 
            // movieRating
            // 
            movieRating.BackColor = SystemColors.ControlLight;
            movieRating.BorderStyle = BorderStyle.None;
            movieRating.Location = new Point(172, 203);
            movieRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            movieRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            movieRating.Name = "movieRating";
            movieRating.RightToLeft = RightToLeft.No;
            movieRating.Size = new Size(44, 19);
            movieRating.TabIndex = 8;
            movieRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(587, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 10;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // reviewMovieTitle
            // 
            reviewMovieTitle.AutoSize = true;
            reviewMovieTitle.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            reviewMovieTitle.Location = new Point(172, 12);
            reviewMovieTitle.Name = "reviewMovieTitle";
            reviewMovieTitle.Size = new Size(72, 30);
            reviewMovieTitle.TabIndex = 11;
            reviewMovieTitle.Text = "label1";
            // 
            // FormPostReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 369);
            Controls.Add(reviewMovieTitle);
            Controls.Add(button1);
            Controls.Add(movieRating);
            Controls.Add(reviewText);
            Controls.Add(reviewMoviePoster);
            Name = "FormPostReview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Post a Review";
            Load += FormTest_Load;
            ((System.ComponentModel.ISupportInitialize)reviewMoviePoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox reviewMoviePoster;
        private RichTextBox reviewText;
        private NumericUpDown movieRating;
        private Button button1;
        private Label reviewMovieTitle;
    }
}