namespace Movie_Tracker.Forms
{
    partial class FormSeeReviews
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
            reviewMovieTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)reviewMoviePoster).BeginInit();
            SuspendLayout();
            // 
            // reviewMoviePoster
            // 
            reviewMoviePoster.Location = new Point(12, 12);
            reviewMoviePoster.Name = "reviewMoviePoster";
            reviewMoviePoster.Size = new Size(140, 210);
            reviewMoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            reviewMoviePoster.TabIndex = 6;
            reviewMoviePoster.TabStop = false;
            // 
            // reviewMovieTitle
            // 
            reviewMovieTitle.AutoSize = true;
            reviewMovieTitle.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            reviewMovieTitle.Location = new Point(172, 12);
            reviewMovieTitle.Name = "reviewMovieTitle";
            reviewMovieTitle.Size = new Size(72, 30);
            reviewMovieTitle.TabIndex = 10;
            reviewMovieTitle.Text = "label1";
            // 
            // FormSeeReviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(684, 369);
            Controls.Add(reviewMovieTitle);
            Controls.Add(reviewMoviePoster);
            Name = "FormSeeReviews";
            Text = "FormSeeReviews";
            Load += FormTest_Load;
            ((System.ComponentModel.ISupportInitialize)reviewMoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox reviewMoviePoster;
        private Label reviewMovieTitle;
    }
}