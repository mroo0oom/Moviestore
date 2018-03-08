using movies_project.Class;
using System;
using System.Globalization;
using System.Web.UI;
using TMDbLib.Client;
using TMDbLib.Objects.Authentication;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace movies_project
{
    public partial class Single : System.Web.UI.Page
    {
        int Movies_id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.hide.Value = Request.QueryString["movie_id"];
            Movies_id = Convert.ToInt32(this.hide.Value);


            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(this.hide.Value).Result;


            string str1 = "";
            string str2 = "";
            string str3 = "";



            str1 +=
                    "<img src='" + "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + movie.PosterPath + "' class='img-responsive' />";

            string country = "";
            if (movie.ProductionCountries.Count > 0)
                country = movie.ProductionCountries[0].Name;
            
            str2 += "<h3 style='font-family: 'Arial';'>" + movie.Title + "</h3><p class='movie_option'><strong>Country: </strong>" + country + "</p>" +
                "<p class='movie_option'><strong>Language:</strong > " + movie.OriginalLanguage + "</P>" +
            "<p class='movie_option'><strong>Spoken Language: </strong>";
            for (int i = 0; i < movie.SpokenLanguages.Count; i++)
                str2 += movie.SpokenLanguages[i].Name + ", ";
            str2 += "</P><p class='movie_option'><strong>Genres: </strong>";
            for (int i = 0; i < movie.Genres.Count; i++)
                str2 += movie.Genres[i].Name + ", ";
            try {
                str2 += "</P><p class='movie_option'><strong>Release date: </strong>" + movie.ReleaseDate.Value.ToString("D", CultureInfo.CreateSpecificCulture("en-US")) + "</p>";
            }
            catch
            {
                str2 += "</P><p class='movie_option'><strong>Release date: </strong>" +"" + "</p>";

            }
            str2 += "<p class='movie_option'><strong>Vote: </strong>" + movie.VoteAverage + "</p>";
            str2 += "<p class='movie_option'><strong>Vote Count: </strong>" + movie.VoteCount + "</p>" +
                "<a href='" + "http://www.imdb.com/title/" + movie.ImdbId + "'>Go IMDB Link</a><br/>";

            str3 += movie.Overview;

            client.SetSessionInformation(Program.Session_Id, SessionType.UserSession);
            SearchContainer<SearchMovie> results = client.AccountGetFavoriteMoviesAsync().Result;
            foreach (SearchMovie result in results.Results)
            {
                if (result.Id == Movies_id)
                    Favorit_btn.Text = "Remove From Favorite";



            }

            m_image.Controls.Add(new LiteralControl(str1));
            info.Controls.Add(new LiteralControl(str2));
            description.Controls.Add(new LiteralControl(str3));

        }

        private void castMovie()
        {

            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            TMDbLib.Objects.Movies.Credits results = client.GetMovieCreditsAsync(Movies_id).Result;


            string str = "<div class='box_1'>" +
           "<h1>Top Billed Cast</h1>" +
        "<div class='clearfix'> </div>" +
        "</div> <div class='row'>";
            int i = 0;
            if (results.Cast.Count > 0)
            {

                foreach (TMDbLib.Objects.Movies.Cast result in results.Cast)
                {
                    if (i > 5)
                        break;
                    str += "<div class='col-md-3' style='margin:10px'>" +
                                "<div class='card'>" +
                        "  <img src = '" + "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + result.ProfilePath + "' alt='Avatar' style='width:100%'>" +
                        "<div style='padding: 2px 16px;'>" +
                         "<h4><b>" + result.Name + "</b></h4>" +
                 "<p>" + result.Character + "</p>" +
                 "<a href='castSingle.aspx?person_id=" + result.Id + "'>See Detials</a>" +
               "</div></div></div>";

                    i++;
                }
            }
            Session["Credit"] = results;

            str += "</div><div class='clearfix'></div></div>" +

       "<br/><center><a class='btn1' href='Casts.aspx?'><span> </span>See All Cast and Crew</a></center>";
            movies.Controls.Add(new LiteralControl(str));

        }

        private void similarMovie()
        {
            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            SearchContainer<SearchMovie> results = client.GetMovieSimilarAsync(Movies_id, "en-us", 1).Result;

            string str = "<div class='box_1'>" +
          "<h1>similar Movies</h1>" +
       "<div class='clearfix'> </div>" +
       "</div> <div class='row'>";
            string image = "";
            if (results.Results.Count > 0)
            {

                foreach (SearchMovie result in results.Results)
                {
                    if (result.PosterPath == null)
                    {
                        image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP_gfN4auNNye--K2rquUrHBCrMl4QYedWLnLT14qSdT2AWPPo";
                    }
                    else
                    {
                        image = "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + result.PosterPath;
                    }
                    str += "<div class='col-md-3' style='margin:10px'>" +
                            "<a href='Single.aspx?movie_id=" + result.Id + "'>" +
                                "<img src='" + image + "' class='img-responsive'/>" +
                            "</a>" +
                                "<div class='caption1'>" +
                                    "<a href='Single.aspx?movie_id=" + result.Id + "'>" +
                                        "<p class='m_3' style='color: #FFF;'>" + result.Title + "</p>" +
                                    "</a>" +
                                "</div>" +
                            "</div>";
                }
            }


            str += "</div><div class='clearfix'></div></div>";
            movies.Controls.Add(new LiteralControl(str));


        }

        protected void Favorit_btn_Click(object sender, EventArgs e)
        {
            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");
            client.SetSessionInformation(Program.Session_Id, SessionType.UserSession);

            if (Favorit_btn.Text != "Remove From Favorite")
            {
                client.AccountChangeFavoriteStatusAsync(MediaType.Movie, Movies_id, true);
                Favorit_btn.Text = "Remove From Favorite";
            }
            else
            {
                client.AccountChangeFavoriteStatusAsync(MediaType.Movie, Movies_id, false);
                Favorit_btn.Text = "Add To Favorite";
            }



        }

        protected void Cast_btn_Click(object sender, EventArgs e)
        {

            castMovie();
        }

        protected void Simi_btn_Click(object sender, EventArgs e)
        {
            similarMovie();


        }

    }
}
