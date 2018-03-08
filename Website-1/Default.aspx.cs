using System;
using System.Web.UI;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace movies_project
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            SearchContainer<SearchMovie> results = client.GetMoviePopularListAsync("en-us", 1).Result;

            string str = "<div class='row'>";
            string str1 = "<ul class='rslides' id='slider'>";
            string image = "";
            if (results.Results.Count > 0)
            {
                int i = 0;
                foreach (SearchMovie result in results.Results)
                {
                    string date = "";
                    if (result.ReleaseDate != null)
                        date = "<font style = 'font-size:27'> ("+ result.ReleaseDate.Value.Year+") </font> ";

                    if (result.PosterPath == null)
                    {
                        image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP_gfN4auNNye--K2rquUrHBCrMl4QYedWLnLT14qSdT2AWPPo";
                    }
                    else
                    {
                        image = "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + result.PosterPath;
                    }
                    if (i < 2)
                    {

                        str1 += "<li style='margin-left:10px'><div class='col-md-3'><img src='" + image+"' class='img-responsive' alt='Slider image " + result.Id + "' style='height: 300px;' /></div>" +
                              "<div class='col-md-4' > <h3 style='color: #FFF;margin:10px;font-family: 'Arial';'>" + result.Title + date+"</h3>" +
                              "<h4 style='color: red;margin:10px;font-family: 'Arial';'>Overview</h4>" +
                              "<p style='color: #FFF;'>"+ result.Overview+"</p></div>" +
                            "<div class='button'>" +
                                  "<a href='Single.aspx?movie_id=" + result.Id + "' class='hvr-shutter-out-horizontal'>Watch Now</a>" +
                                "</div>" +
                                "</li>";
                    }

                    else
                    {

                        
                  
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
                    
                    i++;
                }
            }

            str += "</div>";
            str1 += "</ul>";
            movies.Controls.Add(new LiteralControl(str));
            slide_asp.Controls.Add(new LiteralControl(str1));
        }
    }
}
