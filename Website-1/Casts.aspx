<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Casts.aspx.cs" MasterPageFile="~/Site.Master" Inherits="movies_project.Casts" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="container">
	<div class="container_wrap">
		<div class="content">
              <div class="movie_top">
      	         <div class="col-md-9 movie_box" ID="cast" runat="server">
                 </div>
                 <div class="clearfix"> </div>
               </div>
	    </div>
</div>
        <hr />
        <div class="container_wrap">
		<div class="content">
              <div class="movie_top">
      	         <div class="col-md-9 movie_box" ID="crew" runat="server">
                 </div>
                 <div class="clearfix"> </div>
               </div>
	    </div>
</div>
</div>

</asp:Content>