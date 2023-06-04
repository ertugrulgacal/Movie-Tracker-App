using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Tracker.User_Controls
{
    public partial class AdminAddMovie : UserControl
    {
        public AdminAddMovie()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB41T07;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void Poster_TextChanged(object sender, EventArgs e)
        {
            moviePoster.ImageLocation = movPoster.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveMovie();
        }

        private void SaveMovie()
        {
            try
            {
                con.Open();
                string sqlQuery = "INSERT INTO TableMovie (mov_title, mov_desc, mov_year, mov_length, mov_lang, mov_poster) VALUES ('" + movTitle.Text + "','" + movDesc.Text + "','" + int.Parse(movYear.Text) + "','" + int.Parse(movLength.Text) + "','" + movLanguage.Text + "','" + movPoster.Text + "')";
                SqlCommand sqlCom = new SqlCommand(sqlQuery, con);
                sqlCom.ExecuteNonQuery();

                MessageBox.Show("Successfully added movie", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.Hide();
            }
        }
    }
}
