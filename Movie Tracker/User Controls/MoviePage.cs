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

namespace Movie_Tracker.User_Controls
{
    public partial class MoviePage : UserControl
    {
        private int _id;

        public MoviePage()
        {
            InitializeComponent();
        }

        public MoviePage(int id) : this()
        {
            _id = id;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB41T07;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void FormTest_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlQuery = "Select mov_title, mov_desc, mov_year, mov_length, mov_lang, mov_poster, vote_average, vote_count from TableMovie WHERE mov_id=" + _id.ToString();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                //string movId = sqlDR[0].ToString();
                //string imageLoc = sqlDR[1].ToString();

                while (sqlDR.Read())
                {
                    movieName.Text = sqlDR[0].ToString() + " (" + sqlDR[2].ToString() + ")";
                    movieDesc.Text = sqlDR[1].ToString();
                    moviePoster.ImageLocation = sqlDR[5].ToString();
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

    }
}
