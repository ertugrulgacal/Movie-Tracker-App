namespace Movie_Tracker;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panelMenu = new Panel();
        button5 = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        panelLogo = new Panel();
        pictureBox1 = new PictureBox();
        label2 = new Label();
        panelTitleBar = new Panel();
        label1 = new Label();
        sortOptions = new ComboBox();
        searchBar = new TextBox();
        btnFullscreen = new Button();
        btnMinimize = new Button();
        btnClose = new Button();
        menuTitle = new Label();
        panelDesktopPane = new Panel();
        panelMenu.SuspendLayout();
        panelLogo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panelTitleBar.SuspendLayout();
        SuspendLayout();
        // 
        // panelMenu
        // 
        panelMenu.BackColor = Color.FromArgb(116, 86, 174);
        panelMenu.Controls.Add(button5);
        panelMenu.Controls.Add(button4);
        panelMenu.Controls.Add(button3);
        panelMenu.Controls.Add(button2);
        panelMenu.Controls.Add(button1);
        panelMenu.Controls.Add(panelLogo);
        panelMenu.Dock = DockStyle.Left;
        panelMenu.Location = new Point(0, 0);
        panelMenu.Name = "panelMenu";
        panelMenu.Size = new Size(220, 505);
        panelMenu.TabIndex = 0;
        // 
        // button5
        // 
        button5.Dock = DockStyle.Top;
        button5.FlatAppearance.BorderSize = 0;
        button5.FlatStyle = FlatStyle.Flat;
        button5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        button5.ForeColor = Color.White;
        button5.Image = Properties.Resources.icons8_Administrator_Male_26px;
        button5.ImageAlign = ContentAlignment.MiddleLeft;
        button5.Location = new Point(0, 320);
        button5.Name = "button5";
        button5.Padding = new Padding(11, 0, 0, 0);
        button5.Size = new Size(220, 60);
        button5.TabIndex = 5;
        button5.Text = "         Admin";
        button5.TextAlign = ContentAlignment.MiddleLeft;
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.Dock = DockStyle.Top;
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        button4.ForeColor = Color.White;
        button4.Image = Properties.Resources.icons8_user_groups_26px;
        button4.ImageAlign = ContentAlignment.MiddleLeft;
        button4.Location = new Point(0, 260);
        button4.Name = "button4";
        button4.Padding = new Padding(11, 0, 0, 0);
        button4.Size = new Size(220, 60);
        button4.TabIndex = 4;
        button4.Text = "         Actors";
        button4.TextAlign = ContentAlignment.MiddleLeft;
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.Dock = DockStyle.Top;
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        button3.ForeColor = Color.White;
        button3.Image = Properties.Resources.icons8_list_26px;
        button3.ImageAlign = ContentAlignment.MiddleLeft;
        button3.Location = new Point(0, 200);
        button3.Name = "button3";
        button3.Padding = new Padding(11, 0, 0, 0);
        button3.Size = new Size(220, 60);
        button3.TabIndex = 3;
        button3.Text = "         Watchlist";
        button3.TextAlign = ContentAlignment.MiddleLeft;
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Top;
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        button2.ForeColor = Color.White;
        button2.Image = Properties.Resources.icons8_tv_show_26px;
        button2.ImageAlign = ContentAlignment.MiddleLeft;
        button2.Location = new Point(0, 140);
        button2.Name = "button2";
        button2.Padding = new Padding(11, 0, 0, 0);
        button2.Size = new Size(220, 60);
        button2.TabIndex = 2;
        button2.Text = "         History";
        button2.TextAlign = ContentAlignment.MiddleLeft;
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Dock = DockStyle.Top;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Image = Properties.Resources.icons8_home_26px;
        button1.ImageAlign = ContentAlignment.MiddleLeft;
        button1.Location = new Point(0, 80);
        button1.Name = "button1";
        button1.Padding = new Padding(11, 0, 0, 0);
        button1.Size = new Size(220, 60);
        button1.TabIndex = 1;
        button1.Text = "         Home";
        button1.TextAlign = ContentAlignment.MiddleLeft;
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // panelLogo
        // 
        panelLogo.BackColor = Color.FromArgb(116, 86, 174);
        panelLogo.Controls.Add(pictureBox1);
        panelLogo.Controls.Add(label2);
        panelLogo.Dock = DockStyle.Top;
        panelLogo.Location = new Point(0, 0);
        panelLogo.Name = "panelLogo";
        panelLogo.Size = new Size(220, 80);
        panelLogo.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.BackgroundImageLayout = ImageLayout.None;
        pictureBox1.Image = Properties.Resources.icons8_clapperboard_40px1;
        pictureBox1.Location = new Point(11, 20);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(43, 40);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(53, 25);
        label2.Name = "label2";
        label2.Size = new Size(121, 30);
        label2.TabIndex = 0;
        label2.Text = "Movie App";
        // 
        // panelTitleBar
        // 
        panelTitleBar.BackColor = Color.FromArgb(116, 86, 174);
        panelTitleBar.Controls.Add(label1);
        panelTitleBar.Controls.Add(sortOptions);
        panelTitleBar.Controls.Add(searchBar);
        panelTitleBar.Controls.Add(btnFullscreen);
        panelTitleBar.Controls.Add(btnMinimize);
        panelTitleBar.Controls.Add(btnClose);
        panelTitleBar.Controls.Add(menuTitle);
        panelTitleBar.Dock = DockStyle.Top;
        panelTitleBar.ForeColor = Color.White;
        panelTitleBar.Location = new Point(220, 0);
        panelTitleBar.Name = "panelTitleBar";
        panelTitleBar.Size = new Size(700, 80);
        panelTitleBar.TabIndex = 1;
        panelTitleBar.MouseDown += panelTitleBar_MouseDown;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(286, 50);
        label1.Name = "label1";
        label1.Size = new Size(47, 15);
        label1.TabIndex = 6;
        label1.Text = "Sort By:";
        // 
        // sortOptions
        // 
        sortOptions.FormattingEnabled = true;
        sortOptions.Items.AddRange(new object[] { "Popularity", "Rating", "Year", "Name", "Length" });
        sortOptions.Location = new Point(339, 47);
        sortOptions.Name = "sortOptions";
        sortOptions.Size = new Size(121, 23);
        sortOptions.TabIndex = 5;
        sortOptions.SelectedIndexChanged += sortOptions_SelectedIndexChanged;
        // 
        // searchBar
        // 
        searchBar.ForeColor = SystemColors.ControlDarkDark;
        searchBar.Location = new Point(482, 48);
        searchBar.Name = "searchBar";
        searchBar.PlaceholderText = "Search for a movie";
        searchBar.Size = new Size(206, 23);
        searchBar.TabIndex = 4;
        searchBar.TextChanged += searchBar_TextChanged;
        // 
        // btnFullscreen
        // 
        btnFullscreen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnFullscreen.FlatAppearance.BorderSize = 0;
        btnFullscreen.FlatStyle = FlatStyle.Flat;
        btnFullscreen.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnFullscreen.Location = new Point(631, 3);
        btnFullscreen.Name = "btnFullscreen";
        btnFullscreen.Size = new Size(30, 30);
        btnFullscreen.TabIndex = 3;
        btnFullscreen.Text = "O";
        btnFullscreen.UseVisualStyleBackColor = true;
        btnFullscreen.Click += btnFullscreen_Click;
        // 
        // btnMinimize
        // 
        btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnMinimize.FlatAppearance.BorderSize = 0;
        btnMinimize.FlatStyle = FlatStyle.Flat;
        btnMinimize.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnMinimize.Location = new Point(595, 3);
        btnMinimize.Name = "btnMinimize";
        btnMinimize.Size = new Size(30, 30);
        btnMinimize.TabIndex = 2;
        btnMinimize.Text = "O";
        btnMinimize.UseVisualStyleBackColor = true;
        btnMinimize.Click += btnMinimize_Click;
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnClose.Location = new Point(667, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(30, 30);
        btnClose.TabIndex = 1;
        btnClose.Text = "O";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // menuTitle
        // 
        menuTitle.Anchor = AnchorStyles.Left;
        menuTitle.AutoSize = true;
        menuTitle.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        menuTitle.Location = new Point(15, 40);
        menuTitle.Name = "menuTitle";
        menuTitle.Size = new Size(72, 28);
        menuTitle.TabIndex = 0;
        menuTitle.Text = "HOME";
        // 
        // panelDesktopPane
        // 
        panelDesktopPane.Dock = DockStyle.Fill;
        panelDesktopPane.Location = new Point(220, 80);
        panelDesktopPane.Name = "panelDesktopPane";
        panelDesktopPane.Size = new Size(700, 425);
        panelDesktopPane.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(920, 505);
        Controls.Add(panelDesktopPane);
        Controls.Add(panelTitleBar);
        Controls.Add(panelMenu);
        Name = "MainForm";
        Text = "Form1";
        Load += MainForm_Load;
        panelMenu.ResumeLayout(false);
        panelLogo.ResumeLayout(false);
        panelLogo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panelTitleBar.ResumeLayout(false);
        panelTitleBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panelMenu;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private Button button1;
    private Panel panelLogo;
    private Panel panelTitleBar;
    private Label label2;
    private Label menuTitle;
    private Panel panelDesktopPane;
    private Button btnFullscreen;
    private Button btnMinimize;
    private Button btnClose;
    private TextBox searchBar;
    private PictureBox pictureBox1;
    private Label label1;
    private ComboBox sortOptions;
}
