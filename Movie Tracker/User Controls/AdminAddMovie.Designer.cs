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
            genreAction = new CheckBox();
            genreAdventure = new CheckBox();
            genreAnimation = new CheckBox();
            genreComedy = new CheckBox();
            genreCrime = new CheckBox();
            genreDrama = new CheckBox();
            genreFantasy = new CheckBox();
            genreMystery = new CheckBox();
            genreRomance = new CheckBox();
            genreSciFi = new CheckBox();
            genreThriller = new CheckBox();
            genreHorror = new CheckBox();
            label7 = new Label();
            movDirector = new TextBox();
            label8 = new Label();
            movActors = new TextBox();
            label9 = new Label();
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
            // genreAction
            // 
            genreAction.Appearance = Appearance.Button;
            genreAction.AutoSize = true;
            genreAction.BackColor = Color.BlueViolet;
            genreAction.FlatAppearance.BorderSize = 0;
            genreAction.FlatStyle = FlatStyle.Flat;
            genreAction.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreAction.ForeColor = Color.White;
            genreAction.Location = new Point(35, 300);
            genreAction.Name = "genreAction";
            genreAction.Size = new Size(52, 25);
            genreAction.TabIndex = 19;
            genreAction.Text = "Action";
            genreAction.UseVisualStyleBackColor = false;
            // 
            // genreAdventure
            // 
            genreAdventure.Appearance = Appearance.Button;
            genreAdventure.AutoSize = true;
            genreAdventure.BackColor = Color.BlueViolet;
            genreAdventure.FlatAppearance.BorderSize = 0;
            genreAdventure.FlatStyle = FlatStyle.Flat;
            genreAdventure.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreAdventure.ForeColor = Color.White;
            genreAdventure.Location = new Point(93, 300);
            genreAdventure.Name = "genreAdventure";
            genreAdventure.Size = new Size(72, 25);
            genreAdventure.TabIndex = 20;
            genreAdventure.Text = "Adventure";
            genreAdventure.UseVisualStyleBackColor = false;
            // 
            // genreAnimation
            // 
            genreAnimation.Appearance = Appearance.Button;
            genreAnimation.AutoSize = true;
            genreAnimation.BackColor = Color.BlueViolet;
            genreAnimation.FlatAppearance.BorderSize = 0;
            genreAnimation.FlatStyle = FlatStyle.Flat;
            genreAnimation.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreAnimation.ForeColor = Color.White;
            genreAnimation.Location = new Point(171, 300);
            genreAnimation.Name = "genreAnimation";
            genreAnimation.Size = new Size(73, 25);
            genreAnimation.TabIndex = 21;
            genreAnimation.Text = "Animation";
            genreAnimation.UseVisualStyleBackColor = false;
            // 
            // genreComedy
            // 
            genreComedy.Appearance = Appearance.Button;
            genreComedy.AutoSize = true;
            genreComedy.BackColor = Color.BlueViolet;
            genreComedy.FlatAppearance.BorderSize = 0;
            genreComedy.FlatStyle = FlatStyle.Flat;
            genreComedy.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreComedy.ForeColor = Color.White;
            genreComedy.Location = new Point(250, 300);
            genreComedy.Name = "genreComedy";
            genreComedy.Size = new Size(62, 25);
            genreComedy.TabIndex = 22;
            genreComedy.Text = "Comedy";
            genreComedy.UseVisualStyleBackColor = false;
            // 
            // genreCrime
            // 
            genreCrime.Appearance = Appearance.Button;
            genreCrime.AutoSize = true;
            genreCrime.BackColor = Color.BlueViolet;
            genreCrime.FlatAppearance.BorderSize = 0;
            genreCrime.FlatStyle = FlatStyle.Flat;
            genreCrime.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreCrime.ForeColor = Color.White;
            genreCrime.Location = new Point(35, 331);
            genreCrime.Name = "genreCrime";
            genreCrime.Size = new Size(49, 25);
            genreCrime.TabIndex = 23;
            genreCrime.Text = "Crime";
            genreCrime.UseVisualStyleBackColor = false;
            // 
            // genreDrama
            // 
            genreDrama.Appearance = Appearance.Button;
            genreDrama.AutoSize = true;
            genreDrama.BackColor = Color.BlueViolet;
            genreDrama.FlatAppearance.BorderSize = 0;
            genreDrama.FlatStyle = FlatStyle.Flat;
            genreDrama.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreDrama.ForeColor = Color.White;
            genreDrama.Location = new Point(90, 331);
            genreDrama.Name = "genreDrama";
            genreDrama.Size = new Size(52, 25);
            genreDrama.TabIndex = 24;
            genreDrama.Text = "Drama";
            genreDrama.UseVisualStyleBackColor = false;
            // 
            // genreFantasy
            // 
            genreFantasy.Appearance = Appearance.Button;
            genreFantasy.AutoSize = true;
            genreFantasy.BackColor = Color.BlueViolet;
            genreFantasy.FlatAppearance.BorderSize = 0;
            genreFantasy.FlatStyle = FlatStyle.Flat;
            genreFantasy.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreFantasy.ForeColor = Color.White;
            genreFantasy.Location = new Point(148, 331);
            genreFantasy.Name = "genreFantasy";
            genreFantasy.Size = new Size(57, 25);
            genreFantasy.TabIndex = 25;
            genreFantasy.Text = "Fantasy";
            genreFantasy.UseVisualStyleBackColor = false;
            // 
            // genreMystery
            // 
            genreMystery.Appearance = Appearance.Button;
            genreMystery.AutoSize = true;
            genreMystery.BackColor = Color.BlueViolet;
            genreMystery.FlatAppearance.BorderSize = 0;
            genreMystery.FlatStyle = FlatStyle.Flat;
            genreMystery.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreMystery.ForeColor = Color.White;
            genreMystery.Location = new Point(35, 362);
            genreMystery.Name = "genreMystery";
            genreMystery.Size = new Size(59, 25);
            genreMystery.TabIndex = 27;
            genreMystery.Text = "Mystery";
            genreMystery.UseVisualStyleBackColor = false;
            // 
            // genreRomance
            // 
            genreRomance.Appearance = Appearance.Button;
            genreRomance.AutoSize = true;
            genreRomance.BackColor = Color.BlueViolet;
            genreRomance.FlatAppearance.BorderSize = 0;
            genreRomance.FlatStyle = FlatStyle.Flat;
            genreRomance.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreRomance.ForeColor = Color.White;
            genreRomance.Location = new Point(100, 362);
            genreRomance.Name = "genreRomance";
            genreRomance.Size = new Size(67, 25);
            genreRomance.TabIndex = 28;
            genreRomance.Text = "Romance";
            genreRomance.UseVisualStyleBackColor = false;
            // 
            // genreSciFi
            // 
            genreSciFi.Appearance = Appearance.Button;
            genreSciFi.AutoSize = true;
            genreSciFi.BackColor = Color.BlueViolet;
            genreSciFi.FlatAppearance.BorderSize = 0;
            genreSciFi.FlatStyle = FlatStyle.Flat;
            genreSciFi.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreSciFi.ForeColor = Color.White;
            genreSciFi.Location = new Point(173, 362);
            genreSciFi.Name = "genreSciFi";
            genreSciFi.Size = new Size(46, 25);
            genreSciFi.TabIndex = 29;
            genreSciFi.Text = "Sci-Fi";
            genreSciFi.UseVisualStyleBackColor = false;
            // 
            // genreThriller
            // 
            genreThriller.Appearance = Appearance.Button;
            genreThriller.AutoSize = true;
            genreThriller.BackColor = Color.BlueViolet;
            genreThriller.FlatAppearance.BorderSize = 0;
            genreThriller.FlatStyle = FlatStyle.Flat;
            genreThriller.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreThriller.ForeColor = Color.White;
            genreThriller.Location = new Point(225, 362);
            genreThriller.Name = "genreThriller";
            genreThriller.Size = new Size(54, 25);
            genreThriller.TabIndex = 30;
            genreThriller.Text = "Thriller";
            genreThriller.UseVisualStyleBackColor = false;
            // 
            // genreHorror
            // 
            genreHorror.Appearance = Appearance.Button;
            genreHorror.AutoSize = true;
            genreHorror.BackColor = Color.BlueViolet;
            genreHorror.FlatAppearance.BorderSize = 0;
            genreHorror.FlatStyle = FlatStyle.Flat;
            genreHorror.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genreHorror.ForeColor = Color.White;
            genreHorror.Location = new Point(211, 331);
            genreHorror.Name = "genreHorror";
            genreHorror.Size = new Size(52, 25);
            genreHorror.TabIndex = 26;
            genreHorror.Text = "Horror";
            genreHorror.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(35, 282);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 31;
            label7.Text = "genres:";
            // 
            // movDirector
            // 
            movDirector.Location = new Point(98, 206);
            movDirector.Name = "movDirector";
            movDirector.Size = new Size(289, 23);
            movDirector.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.BlueViolet;
            label8.Location = new Point(35, 212);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 32;
            label8.Text = "Director:";
            // 
            // movActors
            // 
            movActors.Location = new Point(87, 235);
            movActors.Name = "movActors";
            movActors.Size = new Size(300, 23);
            movActors.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.BlueViolet;
            label9.Location = new Point(35, 241);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 34;
            label9.Text = "Actors:";
            // 
            // AdminAddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(movActors);
            Controls.Add(label9);
            Controls.Add(movDirector);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(genreThriller);
            Controls.Add(genreSciFi);
            Controls.Add(genreRomance);
            Controls.Add(genreMystery);
            Controls.Add(genreHorror);
            Controls.Add(genreFantasy);
            Controls.Add(genreDrama);
            Controls.Add(genreCrime);
            Controls.Add(genreComedy);
            Controls.Add(genreAnimation);
            Controls.Add(genreAdventure);
            Controls.Add(genreAction);
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
            Load += AdminAddMovie_Load;
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
        private CheckBox genreAction;
        private CheckBox genreAdventure;
        private CheckBox genreAnimation;
        private CheckBox genreComedy;
        private CheckBox genreCrime;
        private CheckBox genreDrama;
        private CheckBox genreFantasy;
        private CheckBox genreMystery;
        private CheckBox genreRomance;
        private CheckBox genreSciFi;
        private CheckBox genreThriller;
        private CheckBox genreHorror;
        private Label label7;
        private TextBox movDirector;
        private Label label8;
        private TextBox movActors;
        private Label label9;
    }
}
