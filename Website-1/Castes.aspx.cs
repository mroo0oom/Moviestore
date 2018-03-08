using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movies_project
{
    public partial class Castes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string UpperName = b.ID.ToUpper();
            string LowerName = b.ID.ToLower();
            SqlDataSource1.SelectCommand = "select * from Movie inner join Director on Movie.Director_Id = Director.Director_Id where Movie_Name Like '" + UpperName + "%' OR  Movie_Name Like '" + LowerName + "%'";
            DataSourceSelectArguments s = new DataSourceSelectArguments();

            DataView dv = (DataView)SqlDataSource1.Select(s);

            string str = "";

            if (dv.Count > 0)
            {
                for (int i = 0; i < dv.Count; i++)
                {
                    var year = DateTime.Parse(dv[i][4].ToString()).Year;
                    var month = DateTime.Parse(dv[i][4].ToString()).Month;
                    var day = DateTime.Parse(dv[i][4].ToString()).Day;

                    DateTime date = new DateTime(year, month, day);

                    str += "<div class='movie movie-test movie-test-dark movie-test-left'>" +
                                "<div class='movie__images'>" +
                                    "<a href='Single.aspx?movie_id="+ dv[i][0] +"' class='movie-beta__link'>" +
                                        "<img src='" + dv[0][5] + "' class='img-responsive' />"+
                                    "</a>" +
                                "</div>" +
                                "<div class='movie__info'>" +
                                    "<a href='Single.aspx?movie_id="+ dv[i][0] +"' class='movie__title'>" + dv[i][1] + "  </a><br/>" +
                                    "<span>Realse date: " + date.ToString("D", CultureInfo.CreateSpecificCulture("en-US")) + "</span><br/>" +
                                    "<span>Directed by: " + dv[i][12] + "</span><br/>" +
                                 "</div>" +
                                "<div class='clearfix'> </div>" +
                            "</div>";
                }
            }
            else
            {
                str += "<div class='alert alert-danger'>There is no movie mutch to " + b.ID.ToUpper() +"</div>";
            }

            movies.Controls.Add(new LiteralControl(str));
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string UpperName = b.Text.ToUpper();
            string LowerName = b.Text.ToLower();
            SqlDataSource2.SelectCommand = "select * from Actor where Actor_Name Like '" + UpperName + "%' OR  Actor_Name Like '" + LowerName + "%'";
            DataSourceSelectArguments s = new DataSourceSelectArguments();

            DataView dv = (DataView)SqlDataSource2.Select(s);

            string str = "";

            if (dv.Count > 0)
            {
                for (int i = 0; i < dv.Count; i++)
                {
                    str += "<div class='movie movie-test movie-test-dark movie-test-left'>" +
                                "<div class='movie__images'>" +
                                    "<a href='Actor.aspx>actor_id="+ dv[i][0] +"' class='movie-beta__link'>" +
                                        "<img src='"+ dv[i][2] +"' class='img-responsive' />" +
                                    "</a>" +
                                "</div>" +
                                "<div class='movie__info'>" +
                                    "<span class='movie__title'>" + dv[i][1] + "  </span><br/>" +
                                    "<a href='Actor.aspx?actor_id=" + dv[i][0] + "' class='movie__title'>More</a><br/>" +
                                 "</div>" +
                                "<div class='clearfix'> </div>" +
                            "</div>";

                }
            }
            else
            {
                str += "<div class='alert alert-danger'>There is no actor mutch to " + b.Text.ToUpper() + "</div>";
            }

            crew.Controls.Add(new LiteralControl(str));
        }

        protected void Director_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string UpperName = b.Text.ToUpper();
            string LowerName = b.Text.ToLower();
            SqlDataSource3.SelectCommand = "select * from Director inner join Movie on Director.Director_Id = Movie.Director_Id where Director_Name Like '" + UpperName + "%' OR  Director_Name Like '" + LowerName + "%'";
            DataSourceSelectArguments s = new DataSourceSelectArguments();

            DataView dv = (DataView)SqlDataSource3.Select(s);

            string str = "";

            if (dv.Count > 0)
            {
                for (int i = 0; i < dv.Count; i++)
                {
                    str += "<div class='movie movie-test movie-test-dark movie-test-left'>" +
                                "<div class='movie__images'>" +
                                    "<a href='Single.aspx?movie_id=" + dv[i][5] + "' class='movie-beta__link'>" +
                                        "<img src='"+ dv[i][2] +"' class='img-responsive' />" +
                                    "</a>" +
                                "</div>" +
                                "<div class='movie__info'>" +
                                    "<span class='movie__title'>" + dv[i][1] + "  </span><br/>" +
                                    "<a href='Single.aspx?movie_id="+ dv[i][5] +"' class='movie__title'>" + dv[i][6] + "</a><br/>" +
                                 "</div>" +
                                "<div class='clearfix'> </div>" +
                            "</div>";
                }
            }
            else
            {
                str += "<div class='alert alert-danger'>There is no actor mutch to " + b.Text.ToUpper() + "</div>";
            }

            direcor.Controls.Add(new LiteralControl(str));
        }
    }
}