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

namespace MovieReviewFormApp
{
    public partial class frmLogin : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-PO7LRD3\SQLEXPRESS01;Initial Catalog=MovieReviewApp;Integrated Security=True");

        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();

                string sqlQuery = "SELECT * FROM Users WHERE username= '" + txtLogUsername.Text + "' and password= '" + txtLogPassword.Text + "'";

                SqlCommand sqlCom = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader sqlDr = sqlCom.ExecuteReader();

                if (sqlDr.Read() == true)
                {
                    new frmHome().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogUsername.Text = "";
                    txtLogPassword.Text = "";
                    txtLogUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sirasinda hata olustu!" + ex.ToString());
            }
            finally
            {
                if (sqlCon != null)
                {
                    sqlCon.Close();
                }
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtLogPassword.PasswordChar = '\0';
            }
            else
            {
                txtLogPassword.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLogUsername.Text = "";
            txtLogPassword.Text = "";
            txtLogUsername.Focus();
        }
    }
}
