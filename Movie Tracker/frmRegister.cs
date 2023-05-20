using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Tracker
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB41T07;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                regPassword.PasswordChar = '\0';
                regConPassword.PasswordChar = '\0';
            }
            else
            {
                regPassword.PasswordChar = '•';
                regConPassword.PasswordChar = '•';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (regUsername.Text == "" || regPassword.Text == "" || regConPassword.Text == "")
                {
                    MessageBox.Show("Username or password fields can not be empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (regPassword.Text == regConPassword.Text)
                {
                    con.Open();

                    string registerSql = "INSERT INTO TableUsers (username, user_password) VALUES ('" + regUsername.Text + "','" + regPassword.Text + "')";

                    SqlCommand sqlCom = new SqlCommand(registerSql);

                    regUsername.Text = "";
                    regPassword.Text = "";
                    regConPassword.Text = "";

                    MessageBox.Show("Your accunt has been created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Passwords does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    regPassword.Text = "";
                    regConPassword.Text = "";
                    regPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sirasinda hata olustu!" + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
