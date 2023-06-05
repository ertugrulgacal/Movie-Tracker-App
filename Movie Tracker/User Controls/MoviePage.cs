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
            GetMovieInfo();

            GetGenres();

            GetDirector();

            GetActors();

            CheckWatchedList();

            CheckWatchlist();
        }

        private void checkBox1_CheckedChanged(object sender, MouseEventArgs e)
        {
            string movieID = _id.ToString();
            try
            {
                con.Open();

                if (movieUserWatched.Checked)
                {
                    string addSql = "INSERT INTO TableWatchedList VALUES ('" + Program.userID + "','" + movieID + "')";

                    SqlCommand sqlCom = new SqlCommand(addSql, con);
                    sqlCom.ExecuteNonQuery();
                }
                else
                {
                    string deleteSql = "DELETE FROM TableWatchedList WHERE user_id='" + Program.userID + "' AND mov_id='" + movieID + "'";

                    SqlCommand sqlCom = new SqlCommand(deleteSql, con);
                    sqlCom.ExecuteNonQuery();
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

        private void checkBox2_CheckedChanged(object sender, MouseEventArgs e)
        {
            string movieID = _id.ToString();
            try
            {
                con.Open();

                if (movieUserWatchlist.Checked)
                {
                    string addSql = "INSERT INTO TableWatchList VALUES ('" + Program.userID + "','" + movieID + "')";

                    SqlCommand sqlCom = new SqlCommand(addSql, con);
                    sqlCom.ExecuteNonQuery();
                }
                else
                {
                    string deleteSql = "DELETE FROM TableWatchList WHERE user_id='" + Program.userID + "' AND mov_id='" + movieID + "'";

                    SqlCommand sqlCom = new SqlCommand(deleteSql, con);
                    sqlCom.ExecuteNonQuery();
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

        private void GetMovieInfo()
        {
            try
            {
                con.Open();
                string sqlQuery = "Select mov_title, mov_desc, mov_year, mov_length, mov_lang, mov_poster, vote_average, vote_count from TableMovie WHERE mov_id=" + _id.ToString();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    movieName.Text = sqlDR[0].ToString() + " (" + sqlDR[2].ToString() + ")";
                    movieDesc.Text = sqlDR[1].ToString();
                    moviePoster.ImageLocation = sqlDR[5].ToString();
                    movieLength.Text = sqlDR[3].ToString() + " mins         " + sqlDR[4].ToString();
                    movieRating.Text = "Rating: " + sqlDR[6].ToString();
                    movieReviewCount.Text = sqlDR[7].ToString() + " total reviews";
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

        private void CheckWatchedList()
        {
            try
            {
                con.Open();
                string sqlQuery = "Select user_id, mov_id from TableWatchedList WHERE user_id='" + Program.userID + "' AND mov_id='" + _id.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                if (sqlDR.Read() == true)
                {
                    movieUserWatched.Checked = true;
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

        private void CheckWatchlist()
        {
            try
            {
                con.Open();
                string sqlQuery = "Select user_id, mov_id from TableWatchList WHERE user_id='" + Program.userID + "' AND mov_id='" + _id.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                if (sqlDR.Read() == true)
                {
                    movieUserWatchlist.Checked = true;
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

        private void GetGenres()
        {
            try
            {
                con.Open();
                string sqlQuery = "SELECT gen_name FROM TableGenre INNER JOIN TableMovieGenre ON TableGenre.gen_id=TableMovieGenre.gen_id WHERE mov_id='" + _id.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    var label = new Label
                    {
                        Name = "labelGenre" + sqlDR[0].ToString(),
                        Text = sqlDR[0].ToString(),
                        Padding = new Padding(5),
                        Margin = new Padding(2),
                        BackColor = Color.FromArgb(116, 86, 174),
                        ForeColor = Color.White,
                        AutoSize = true,
                    };
                    flwPanelGenres.Controls.Add(label);
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

        private void GetDirector()
        {
            try
            {
                con.Open();
                string sqlQuery = "SELECT dir_name FROM TableDirector INNER JOIN TableMovieDirection ON TableDirector.dir_id=TableMovieDirection.dir_id WHERE mov_id='" + _id.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    var label = new Label
                    {
                        Name = "labelDirector" + sqlDR[0].ToString(),
                        Text = sqlDR[0].ToString(),
                        Padding = new Padding(5),
                        Margin = new Padding(2),
                        BackColor = Color.FromArgb(116, 86, 174),
                        ForeColor = Color.White,
                        AutoSize = true,
                    };
                    flwPanelDirector.Controls.Add(label);
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

        private void GetActors()
        {
            try
            {
                con.Open();
                string sqlQuery = "SELECT act_name FROM TableActor INNER JOIN TableMovieCast ON TableActor.act_id=TableMovieCast.act_id WHERE mov_id='" + _id.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    var label = new Label
                    {
                        Name = "labelActors" + sqlDR[0].ToString(),
                        Text = sqlDR[0].ToString(),
                        Padding = new Padding(5),
                        Margin = new Padding(2),
                        BackColor = Color.FromArgb(116, 86, 174),
                        ForeColor = Color.White,
                        AutoSize = true,
                    };
                    flwPanelActors.Controls.Add(label);
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
            Forms.FormPostReview form = new Forms.FormPostReview(_id);
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Forms.FormSeeReviews form = new Forms.FormSeeReviews(_id);
            form.Show();
        }
    }
}
