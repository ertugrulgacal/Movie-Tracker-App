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
                string sqlQuery = "SELECT username, rev_content, rev_rating FROM TableReview INNER JOIN TableUser ON TableUser.user_id=TableReview.user_id WHERE TableReview.mov_id=" + _id.ToString();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                int usernameX = 203;
                int usernameY = 50;
                int usernameWidth = 100;
                int usernameHeight = 20;
                int reviewX = 172;
                int reviewY = 66;
                int reviewWidth = 475;
                int reviewHeight = 123;
                int numberX = 172;
                int numberY = usernameY;
                int numberWidth = 35;
                int numberHeight = usernameHeight;
                int i = 0;

                while (sqlDR.Read())
                {
                    string username = sqlDR[0].ToString();
                    string revContent = sqlDR[1].ToString();
                    string revRating = sqlDR[2].ToString() + "/10";

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

                    var reviewRating = new Label
                    {
                        Name = "rating" + i.ToString(),
                        Text = revRating,
                        Size = new Size(numberWidth, numberHeight),
                        Location = new Point(numberX, numberY),
                        Font = new Font(new FontFamily("Nirmala UI"), 11, FontStyle.Regular, GraphicsUnit.Pixel),
                        BackColor = System.Drawing.Color.Transparent
                    };

                    var reviewUsername = new Label
                    {
                        Name = "username" + i.ToString(),
                        Text = username,
                        Size = new Size(usernameWidth, usernameHeight),
                        Location = new Point(usernameX, usernameY),
                        Font = new Font(new FontFamily("Nirmala UI"), 11, FontStyle.Italic, GraphicsUnit.Pixel),
                        BackColor = System.Drawing.Color.Transparent
                    };              
                    
                    this.Controls.Add(reviewText);
                    this.Controls.Add(reviewRating);
                    this.Controls.Add(reviewUsername);

                    usernameY += usernameHeight + reviewHeight + 20;
                    reviewY += usernameHeight + reviewHeight + 20;
                    numberY = usernameY;
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
