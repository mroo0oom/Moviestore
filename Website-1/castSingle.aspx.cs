using movies_project.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMDbLib.Client;
using TMDbLib.Objects.Authentication;
using TMDbLib.Objects.Credit;
using TMDbLib.Objects.General;
using TMDbLib.Objects.People;
using TMDbLib.Objects.Search;

namespace movies_project
{
    public partial class castSingle : System.Web.UI.Page
    {
        int Person_id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Person_id = Convert.ToInt32(Request.QueryString["person_id"]);


        TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            TMDbLib.Objects.People.Person person = client.GetPersonAsync(Person_id).Result;

           
            string str1 = "";
            string str2 = "";


 string date = "";
            if (person.Birthday != null)
                date = person.Birthday.Value.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
           
             string image = "";
            if (person.ProfilePath == null)
            {
                image = "https://www.w3schools.com/howto/img_avatar.png";
            }
            else
            {
                image = "https://image.tmdb.org/t/p/w185_and_h278_bestv2" + person.ProfilePath;
            }

            str1 += 
                        "<img src='"+ image+"' class='img-responsive' />";



            str2 += "<h3 style='font-family: 'Arial';'>" + person.Name + "</h3><p class='movie_option'><strong>Place_of_birth: </strong>" + person.PlaceOfBirth + "</p>" +
                "<p class='movie_option'><strong>Birthday:</strong > " + date + "</P>"+

             "</P><p class='movie_option'><strong>Biography: </strong>" +person.Biography + "</p>";
            str2 += "<a href='" + "http://www.imdb.com/name/" + person.ImdbId + "'>Go IMDB Link</a>";


            m_image.Controls.Add(new LiteralControl(str1));
            info.Controls.Add(new LiteralControl(str2));

        }
        

      

        protected void movie_btn_Click(object sender, EventArgs e)
        {

            TMDbClient client = new TMDbClient("e1b3af48ad2d28cab2fb3ac299948c08");

            TMDbLib.Objects.People.MovieCredits results = client.GetPersonMovieCreditsAsync(Person_id).Result;

            string str = "<div class='box_1'>" +
          ">" +
       "<div class='clearfix'> </div>" +
       "</div><h1>Movies casted in</h1> <div class='row'>";
            string image = "";
            if (results.Cast.Count > 0)
            {

                foreach (MovieRole result in results.Cast)
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
    }
}
