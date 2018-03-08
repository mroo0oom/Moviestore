using System;
using System.Web.UI;
using TMDbLib.Objects.General;

namespace movies_project
{
    public partial class Casts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            TMDbLib.Objects.Movies.Credits results =(TMDbLib.Objects.Movies.Credits)Session["Credit"];





            string str1="";// = "<h3>Cast("+results.Cast.Count+") </h3>";
            string image = "";
            if (results.Cast.Count > 0)
            {
                str1 += "<h3>Cast(" + results.Cast.Count + ") </h3>";

                foreach (TMDbLib.Objects.Movies.Cast result in results.Cast)
                {

                   
                    if (result.ProfilePath ==null)
                    {
                        image = "https://www.w3schools.com/howto/img_avatar.png";
                    }
                    else
                    {
                        image = "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + result.ProfilePath;
                    }
                    str1 += "<div class='movie movie-test movie-test-dark movie-test-left'>" +
                                "<div class='movie__images'>" +
                                    "<a href='Single.aspx?movie_id=" + result.Id + "' class='movie-beta__link'>" +
                                        "<img src='" + image + "' class='img-responsive' />" +
                                    "</a>" +
                                "</div>" +
                                "<div class='movie__info'>" +
                                    "<h4> <b>" + result.Name + "  </b><h4/>" +
                                    
                                    "<span>Character: " + result.Character + "</span><br/>" +
                                    "<a href='castSingle.aspx?person_id=" + result.Id + "'>See Detials</a>" +
                                 "</div>" +
                                "<div class='clearfix'> </div>" +
                            "</div>";
                }


            }



            string str2 = "";
             

            if (results.Crew.Count > 0)
            {
                str2 += "<br/><hr><br/><h3>Crew(" + results.Crew.Count + ") </h3>";
                foreach (Crew result in results.Crew)
                {

                    if (result.ProfilePath == null)
                    {
                        image = "https://www.w3schools.com/howto/img_avatar.png";
                    }
                    else
                    {
                        image = "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + result.ProfilePath;
                    }
                    str2 += "<div class='movie movie-test movie-test-dark movie-test-left'>" +
                                "<div class='movie__images'>" +
                                    "<a href='Single.aspx?movie_id=" + result.Id + "' class='movie-beta__link'>" +
                                        "<img src='" + image + "' class='img-responsive' />" +
                                    "</a>" +
                                "</div>" +
                                "<div class='movie__info'>" +
                                    "<a href='Single.aspx?movie_id=" + result.Id + "' class='movie__title'>" + result.Name + "  </a><br/>" +
                                    
                                    "<span>Job: " + result.Job + "</span><br/>" +
                                 "</div>" +
                                "<div class='clearfix'> </div>" +
                            "</div>";
                }


            }



            cast.Controls.Add(new LiteralControl(str1));

            crew.Controls.Add(new LiteralControl(str2));

        }
    }
}