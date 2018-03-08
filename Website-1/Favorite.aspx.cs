using movies_project.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMDbLib.Client;
using TMDbLib.Objects.Authentication;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace movies_project
{
    public partial class Favorite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            client.SetSessionInformation(Program.Session_Id, SessionType.UserSession);
            SearchContainer<SearchMovie> results = client.AccountGetFavoriteMoviesAsync().Result;
            string str = "";
            string image = "";
            if (results.Results.Count > 0)
            {
                foreach (SearchMovie result in results.Results)
                {

 string date = "";
                    if (result.ReleaseDate != null)
                        date = result.ReleaseDate.Value.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
                    if (result.PosterPath == null)
                    {
                        image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP_gfN4auNNye--K2rquUrHBCrMl4QYedWLnLT14qSdT2AWPPo";
                    }
                    else
                    {
                        image = "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + result.PosterPath;
                    }
                    str += "<div class='movie movie-test movie-test-dark movie-test-left'>" +
                                   "<div class='movie__images'>" +
                                       "<a href='Single.aspx?movie_id=" + result.Id + "' class='movie-beta__link'>" +
                                           "<img src='" + image + "' class='img-responsive' />" +
                                       "</a>" +
                                   "</div>" +
                                   "<div class='movie__info'>" +
                                       "<a href='Single.aspx?movie_id=" + result.Id + "' class='movie__title'>" + result.Title + "  </a><br/>" +
                                       "<span>Realse date: " + date + "</span><br/>" +
                                       "<span>Vote: " + result.VoteAverage + "</span><br/>" +
                                    "</div>" +
                                   "<div class='clearfix'> </div>" +
                               "</div>";
                }


            }
            else
            {
                str += "<div class='alert alert-danger'>There is no favorite movie</div>";
            }

            result.Controls.Add(new LiteralControl(str));
        }
    }
}
