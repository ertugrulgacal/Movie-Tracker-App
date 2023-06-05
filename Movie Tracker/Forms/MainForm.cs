using Movie_Tracker.User_Controls;
using System.Runtime.InteropServices;

namespace Movie_Tracker;

public partial class MainForm : Form
{
    private Button currentButton;
    //private Form activeForm;
    private bool _actorsIsEnabled = false;

    public MainForm()
    {
        InitializeComponent();
        this.Text = string.Empty;
        this.ControlBox = false;
        this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }
    public void addUserControl(UserControl userControl)
    {
        userControl.Dock = DockStyle.Fill;
        panelDesktopPane.Controls.Clear();
        panelDesktopPane.Controls.Add(userControl);
        userControl.BringToFront();
    }

    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void ActivateButton(object btnSender)
    {
        if (btnSender != null)
        {
            if (currentButton != (Button)btnSender)
            {
                DeactivateButton();
                Color color = Color.DarkViolet;
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new Font("Nirmala UI", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }
    }

    private void DeactivateButton()
    {
        foreach (Control previousBtn in panelMenu.Controls)
        {
            if (previousBtn.GetType() == typeof(Button))
            {
                previousBtn.BackColor = Color.BlueViolet;
                previousBtn.ForeColor = Color.White;
                previousBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }
    }

    /*private void OpenChildForm(Form childForm, object btnSender)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }
        ActivateButton(btnSender);
        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        this.panelDesktopPane.Controls.Add(childForm);
        this.panelDesktopPane.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        menuTitle.Text = childForm.Text;
    }*/

    private void button1_Click(object sender, EventArgs e)
    {
        //OpenChildForm(new Forms.FormTest(), sender);
        ListMovies uc = new ListMovies();
        addUserControl(uc);
        menuTitle.Text = "HOME";
        _actorsIsEnabled = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        //OpenChildForm(new Forms.FormTest(), sender);
        ListWatched uc = new ListWatched();
        addUserControl(uc);
        menuTitle.Text = "HISTORY";
        _actorsIsEnabled = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        //OpenChildForm(new Forms.FormTest(), sender);
        listWatchlist uc = new listWatchlist();
        addUserControl(uc);
        menuTitle.Text = "WATCHLIST";
        _actorsIsEnabled = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        ListActors uc = new ListActors(" ");
        addUserControl(uc);
        menuTitle.Text = "ACTORS";
        _actorsIsEnabled = uc.Enabled;
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (Program.userID == "1")
        {
            AdminAddMovie uc = new AdminAddMovie();
            addUserControl(uc);
            menuTitle.Text = "ADMIN";
            _actorsIsEnabled = false;
        }
        else
        {
            MessageBox.Show("You have to be an admin to use that feature!", "Error", MessageBoxButtons.OK);
        }

    }

    private void ExecuteSearch()
    {
        if (_actorsIsEnabled)
        {
            ListActors uc = new ListActors(searchBar.Text);
            addUserControl(uc);
        }
        else
        {
            ListSearchedMovies uc = new ListSearchedMovies(searchBar.Text, sortOptions.Text);
            addUserControl(uc);
            menuTitle.Text = "SEARCH";
        }
    }

    private void searchBar_TextChanged(object sender, EventArgs e)
    {
        ExecuteSearch();
    }

    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnFullscreen_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        else
        {
            this.WindowState = FormWindowState.Normal;
        }
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState |= FormWindowState.Minimized;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        sortOptions.Text = "Popularity";

        if (!String.Equals(Program.userID, "1"))
        {
            //button5.Visible = false;
        }
    }

    private void sortOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
        ExecuteSearch();
    }
}
