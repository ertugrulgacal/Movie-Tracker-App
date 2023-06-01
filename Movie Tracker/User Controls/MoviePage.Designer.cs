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
            movieDesc.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            movieDesc.Location = new Point(179, 61);
            movieDesc.Name = "movieDesc";
            movieDesc.Size = new Size(504, 169);
            movieDesc.TabIndex = 2;
            movieDesc.Text = "";
            // 
            // movieName
            // 
            movieName.BackColor = SystemColors.Control;
            movieName.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            movieName.Location = new Point(179, 20);
            movieName.Name = "movieName";
            movieName.Size = new Size(504, 35);
            movieName.TabIndex = 3;
            // 
            // MoviePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(movieName);
            Controls.Add(movieDesc);
            Controls.Add(moviePoster);
            Name = "MoviePage";
            Size = new Size(700, 425);
            Load += FormTest_Load;
            ((System.ComponentModel.ISupportInitialize)moviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox moviePoster;
        private RichTextBox movieDesc;
        private TextBox movieName;
    }
}
