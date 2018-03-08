<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Castes.aspx.cs" MasterPageFile="~/Site.Master" Inherits="movies_project.Movie" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="container">
	<div class="container_wrap">
		
	      <div class="content">

	   	   <h2 class="m_3">Search for a movie</h2>
              <asp:Button ID="a" runat="server" OnClick="Button_Click" type="button" Text="A" class="char" />
              <asp:Button ID="b" runat="server" OnClick="Button_Click" type="button" Text="B" class="char" />
              <asp:Button ID="c" runat="server" OnClick="Button_Click" type="button" Text="C" class="char" />
              <asp:Button ID="d" runat="server" OnClick="Button_Click" type="button" Text="D" class="char" />
              <asp:Button ID="e" runat="server" OnClick="Button_Click" type="button" Text="E" class="char" />
              <asp:Button ID="f" runat="server" OnClick="Button_Click" type="button" Text="F" class="char" />
              <asp:Button ID="g" runat="server" OnClick="Button_Click" type="button" Text="G" class="char" />
              <asp:Button ID="h" runat="server" OnClick="Button_Click" type="button" Text="H" class="char" />
              <asp:Button ID="i" runat="server" OnClick="Button_Click" type="button" Text="I" class="char" />
              <asp:Button ID="j" runat="server" OnClick="Button_Click" type="button" Text="J" class="char" />
              <asp:Button ID="k" runat="server" OnClick="Button_Click" type="button" Text="K" class="char" />
              <asp:Button ID="l" runat="server" OnClick="Button_Click" type="button" Text="L" class="char" />
              <asp:Button ID="m" runat="server" OnClick="Button_Click" type="button" Text="M" class="char" />
              <asp:Button ID="n" runat="server" OnClick="Button_Click" type="button" Text="N" class="char" />
              <asp:Button ID="o" runat="server" OnClick="Button_Click" type="button" Text="O" class="char" />
              <asp:Button ID="p" runat="server" OnClick="Button_Click" type="button" Text="P" class="char" />
              <asp:Button ID="q" runat="server" OnClick="Button_Click" type="button" Text="Q" class="char" />
              <asp:Button ID="r" runat="server" OnClick="Button_Click" type="button" Text="R" class="char" />
              <asp:Button ID="s" runat="server" OnClick="Button_Click" type="button" Text="S" class="char" />
              <asp:Button ID="t" runat="server" OnClick="Button_Click" type="button" Text="T" class="char" />
              <asp:Button ID="u" runat="server" OnClick="Button_Click" type="button" Text="U" class="char" />
              <asp:Button ID="v" runat="server" OnClick="Button_Click" type="button" Text="V" class="char" />
              <asp:Button ID="w" runat="server" OnClick="Button_Click" type="button" Text="W" class="char" />
              <asp:Button ID="x" runat="server" OnClick="Button_Click" type="button" Text="X" class="char" />
              <asp:Button ID="y" runat="server" OnClick="Button_Click" type="button" Text="Y" class="char" />
              <asp:Button ID="z" runat="server" OnClick="Button_Click" type="button" Text="X" class="char" />
              <hr />
              <div class="movie_top">
      	         <div class="col-md-9 movie_box" ID="movies" runat="server">
                 </div>
                 <div class="clearfix"> </div>
               </div>
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"></asp:SqlDataSource>
		  

        <h2>Search for an actor</h2>
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="A" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="B" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="C" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="D" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="E" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="F" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="G" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="H" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="I" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="J" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="K" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="L" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="M" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="N" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="O" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="P" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="Q" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="R" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="S" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="T" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="U" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="V" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="W" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="X" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="Y" class="char" />
              <asp:Button runat="server" OnClick="Btn_Click" type="button" Text="X" class="char" />

              <hr />

      	       <div class="movie_top">
      	         <div class="col-md-9 movie_box" ID="crew" runat="server">
                 </div>
                 <div class="clearfix"> </div>
               </div>
               <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"></asp:SqlDataSource>

              <h2>Search for a director</h2>
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="A" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="B" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="C" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="D" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="E" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="F" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="G" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="H" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="I" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="J" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="K" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="L" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="M" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="N" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="O" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="P" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="Q" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="R" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="S" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="T" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="U" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="V" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="W" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="X" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="Y" class="char" />
              <asp:Button runat="server" OnClick="Director_Click" type="button" Text="X" class="char" />

              <hr />

      	       <div class="movie_top">
      	         <div class="col-md-9 movie_box" ID="direcor" runat="server">
                 </div>
                 <div class="clearfix"> </div>
               </div>
               <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"></asp:SqlDataSource>
		  </div>
</div>
</div>

</asp:Content>