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
    public partial class frmRegister : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-PO7LRD3\SQLEXPRESS01;Initial Catalog=MovieReviewApp;Integrated Security=True");

        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtRegUsername.Text=="" || txtRegPassword.Text=="" || txtRegComPassword.Text=="")
                {
                    MessageBox.Show("Username or password fields can not be empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else if(txtRegPassword.Text==txtRegComPassword.Text){
                    sqlCon.Open();
                    string sqlQuery = "INSERT INTO Users VALUES('" + txtRegUsername.Text + "', '" + txtRegPassword.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                    sqlCommand.ExecuteNonQuery();
                    txtRegUsername.Text = "";
                    txtRegPassword.Text = "";
                    txtRegComPassword.Text = "";

                    MessageBox.Show("Your accunt has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegPassword.Text = "";
                    txtRegComPassword.Text = "";
                    txtRegPassword.Focus();
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
                txtRegPassword.PasswordChar = '\0';
                txtRegComPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegPassword.PasswordChar = '•';
                txtRegComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRegUsername.Text = "";
            txtRegPassword.Text = "";
            txtRegComPassword.Text = "";
            txtRegUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
