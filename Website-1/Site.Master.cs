using System;
using System.Globalization;
using System.Web.UI;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;


namespace movies_project
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public static bool is_login = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void search_btn_Click(object sender, EventArgs e)
        {
            string keyUpper = search.Text.ToUpper();
            if (keyUpper != "")
            {
                TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

                SearchContainer<SearchMovie> results = client.SearchMovieAsync(keyUpper, "en-us", 1).Result;

                string str = "";
                string image = "";
                string date = "";
                if (results != null)
                {
                    foreach (SearchMovie result in results.Results)
                    {
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
                                                "<img src='" + image+ "' class='img-responsive' />" +
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
                    str += "<div class='alert alert-danger'>There is no movie mutch to " + search.Text + "</div>";
                }

                Session["result"] = new LiteralControl(str);
                Response.Redirect("~/Result.aspx");
            }
        }

        
    }
}