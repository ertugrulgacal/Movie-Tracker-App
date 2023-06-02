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

namespace Movie_Tracker.Forms
{
    public partial class FormSeeReviews : Form
    {
        private int _id;

        public FormSeeReviews()
        {
            InitializeComponent();
        }
        public FormSeeReviews(int id) : this()
        {
            _id = id;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB41T07;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void FormTest_Load(object sender, EventArgs e)
        {
            // Get movie information
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

            // Get reviews
            try
            {
                con.Open();
                string sqlQuery = "SELECT username, rev_content FROM TableReview INNER JOIN TableUser ON TableUser.user_id=TableReview.user_id WHERE TableReview.mov_id=" + _id.ToString();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                int usernameX = 172;
                int usernameY = 50;
                int usernameWidth = 480;
                int usernameHeight = 20;
                int reviewX = usernameX;
                int reviewY = 66;
                int reviewWidth = 490;
                int reviewHeight = 123;
                int i = 0;

                while (sqlDR.Read())
                {
                    string username = sqlDR[0].ToString();
                    string revContent = sqlDR[1].ToString();

                    var reviewUsername = new Label
                    {
                        Name = "username" + i.ToString(),
                        Text = username,
                        Size = new Size(usernameWidth, usernameHeight),
                        Location = new Point(usernameX, usernameY),
                        Font = new Font(new FontFamily("Nirmala UI"), 11, FontStyle.Italic, GraphicsUnit.Pixel),
                        BackColor = System.Drawing.Color.Transparent
                    };

                    var reviewText = new RichTextBox
                    {
                        Name = "review" + i.ToString(),
                        Text = revContent,
                        Size = new Size(reviewWidth, reviewHeight),
                        Location = new Point(reviewX, reviewY),
                        Font = new Font(new FontFamily("Nirmala UI"), 9, FontStyle.Regular, GraphicsUnit.Pixel),
                        BackColor = Color.Gainsboro,
                        ReadOnly = true
                    };

                    this.Controls.Add(reviewUsername);
                    this.Controls.Add(reviewText);

                    usernameY += usernameHeight + reviewHeight + 20;
                    reviewY += usernameHeight + reviewHeight + 20;
                    i++;
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
