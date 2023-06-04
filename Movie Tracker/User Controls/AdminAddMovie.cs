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
        private string _id;

        public AdminAddMovie()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB41T07;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void AdminAddMovie_Load(object sender, EventArgs e)
        {

        }

        private void Poster_TextChanged(object sender, EventArgs e)
        {
            moviePoster.ImageLocation = movPoster.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveMovie();
            GetMovieID();
            SaveGenres();
        }

        private void SaveMovie()
        {
            try
            {
                con.Open();
                string sqlQuery = "INSERT INTO TableMovie (mov_title, mov_desc, mov_year, mov_length, mov_lang, mov_poster, vote_average, vote_count) VALUES ('" + movTitle.Text + "','" + movDesc.Text + "','" + int.Parse(movYear.Text) + "','" + int.Parse(movLength.Text) + "','" + movLanguage.Text + "','" + movPoster.Text + "','0','0')";
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

        private void SaveGenres()
        {
            if (genreAction.Checked)
            {
                WriteGenre(genreAction, GetGenreID(genreAction.Text));
            }
            if (genreAdventure.Checked)
            {
                WriteGenre(genreAdventure, GetGenreID(genreAdventure.Text));
            }
            if (genreAnimation.Checked)
            {
                WriteGenre(genreAnimation, GetGenreID(genreAnimation.Text));
            }
            if (genreComedy.Checked)
            {
                WriteGenre(genreComedy, GetGenreID(genreComedy.Text));
            }
            if (genreCrime.Checked)
            {
                WriteGenre(genreCrime, GetGenreID(genreCrime.Text));
            }
            if (genreDrama.Checked)
            {
                WriteGenre(genreDrama, GetGenreID(genreDrama.Text));
            }
            if (genreFantasy.Checked)
            {
                WriteGenre(genreFantasy, GetGenreID(genreFantasy.Text));
            }
            if (genreHorror.Checked)
            {
                WriteGenre(genreMystery, GetGenreID(genreMystery.Text));
            }
            if (genreMystery.Checked)
            {
                WriteGenre(genreMystery, GetGenreID(genreMystery.Text));
            }
            if (genreRomance.Checked)
            {
                WriteGenre(genreRomance, GetGenreID(genreRomance.Text));
            }
            if (genreSciFi.Checked)
            {
                WriteGenre(genreSciFi, GetGenreID(genreSciFi.Text));
            }
            if (genreThriller.Checked)
            {
                WriteGenre(genreThriller, GetGenreID(genreThriller.Text));
            }
        }

        private void WriteGenre(CheckBox checkBox, string genreID)
        {
            try
            {
                con.Open();
                string sqlQuery = "INSERT INTO TableMovieGenre (mov_id, gen_id) VALUES ('" + Int16.Parse(_id) + "','" + Int16.Parse(genreID) + "')";
                SqlCommand sqlCom = new SqlCommand(sqlQuery, con);
                sqlCom.ExecuteNonQuery();
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

        private string GetGenreID(string genreName)
        {
            try
            {
                con.Open();
                string sqlQuery = "Select gen_id from TableGenre WHERE gen_name='" + genreName + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    return sqlDR[0].ToString();
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
            return "";
        }

        private void GetMovieID()
        {
            try
            {
                con.Open();
                string sqlQuery = "Select mov_id from TableMovie WHERE mov_title='" + movTitle.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                while (sqlDR.Read())
                {
                    _id = sqlDR[0].ToString();
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
