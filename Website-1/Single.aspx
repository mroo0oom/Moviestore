<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Single.aspx.cs" MasterPageFile="~/Site.Master" Inherits="movies_project.Single" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
<style type="text/css">
        .Empty
        {
            background: url("../assets/images/Empty.gif") no-repeat right top;
        }
        .Empty:hover
        {
            background: url("../assets/images/Filled.gif") no-repeat right top;
        }
        .Filled
        {
            background: url("../assets/images/Filled.gif") no-repeat right top;
        }
    </style>
    

    <style>
.card {
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    transition: 0.3s;
    
}

.card:hover {
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
}

</style>

</asp:Content>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="ContentPlaceHolder1">
<div class="container">
	<div class="container_wrap">
		
		<asp:HiddenField ID="hide" runat="server"/>
        <asp:HiddenField ID="cathide" runat="server"/>
       
        
       
	   <div class="content">
      	   <div class="movie_top">
      	         <div class="col-md-9 movie_box">
                        <div class="grid images_3_of_2">
                        	<div ID="m_image"  runat="server">
                                
                            </div>
                         </div>
                        <div class="desc1 span_3_of_2" >
                            <div ID="info" runat="server"></div>
                            <br />
                <asp:Button ID="Favorit_btn" Text="Add To Favorite" CssClass="simptip-position-bottom btn btn-danger" OnClick="Favorit_btn_Click" runat="server" />
                <asp:Button ID="Simi_btn" Text="See Similar Movies" CssClass="simptip-position-bottom btn btn-danger" OnClick="Simi_btn_Click" runat="server" />
                <asp:Button ID="Cast_btn" Text="See Casts" CssClass="simptip-position-bottom btn btn-danger" OnClick="Cast_btn_Click" runat="server" />
                        	<br />
                         </div>
                        <div class="clearfix"> </div>
                       <br />
                       <strong>Overview:</strong>
                        <p class="m_4" ID="description" runat="server">

                        </p>
                    </div>
                 </div>
              
                            
		<div ID="cast" runat="server" class="container"></div>
						

		<div ID="movies" runat="server" class="container"></div>
                     </div>



                  </div>
           </div>
    
		
</asp:Content>