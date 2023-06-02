using Movie_Tracker.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Tracker.Forms
{
    public partial class FormPostReview : Form
    {
        private int _id;

        public FormPostReview()
        {
            InitializeComponent();
        }

        public FormPostReview(int id) : this()
        {
            _id = id;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB41T07;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void FormTest_Load(object sender, EventArgs e)
        {
            // Get movie info
            try
            {
                con.Open();
                string sqlQuery = "Select mov_title, mov_year, mov_poster from TableMovie WHERE mov_id=" + _id.ToString();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    reviewMovieTitle.Text = sqlDR[0].ToString() + " (" + sqlDR[1].ToString() + ")";
                    reviewMoviePoster.ImageLocation = sqlDR[2].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlQuery = "INSERT INTO TableReview (user_id, mov_id, rev_content, rev_rating) VALUES ('" + Program.userID + "','" + _id.ToString() + "','" + reviewText.Text + "','" + movieRating.Value + "')";
                SqlCommand sqlCom = new SqlCommand(sqlQuery, con);
                sqlCom.ExecuteNonQuery();

                MessageBox.Show("Successfully posted review", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
