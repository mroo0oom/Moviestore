<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MasterPageFile="~/Site.Master" Inherits="movies_project.Default" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <script src="assets/js/responsiveslides.min.js"></script>
    <script src="assets/js/script.js"></script>
    <script>
        $(function () {
            $("#slider").responsiveSlides({
                auto: true,
                nav: true,
                speed: 500,
                namespace: "callbacks",
                pager: true,
            });
        });
    </script>
</asp:Content>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="container">
	<div class="container_wrap">
        <div class="slider" style='background-color:rgba(68,110,82,0.50);'>
	        <div ID="slide_asp" runat="server" class="callbacks_container">

	        </div>
        </div>
      <div class="content">
      	<div class="box_1">
      	 <h1 class="m_2">Popular Movies</h1>
		<div class="clearfix"> </div>
		</div>

		<div ID="movies" runat="server" class="container">
	    </div>
          </div>
      </div>
 </div>

</asp:Content>