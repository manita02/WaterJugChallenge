<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WaterJugChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">WATER JUG CHALLENGUE</h1>
            <p class="lead">Application that solve the classic Water Jug Riddle. </p>
            <!--<p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>-->
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Description</h2>
                <p>
                    The challenge involves using two jugs with different capacities (X gallons and Y gallons) to measure exactly Z gallons of water. 
                </p>
                
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">UI Interface</h2>
                <p>
                    This application have a user interface (UI) that displays the state changes of each jug (Empty, Full, or Partially Full) as it progresses towards the solution.
                </p>
                <p>
                    <!--<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>-->
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Start the Challenge</h2>
                <p>
                    Click on the following button to start. 
                </p>
                <p>
                    <asp:Button ID="btnStarChallengue" runat="server" Text="STAR CHALLENGUE" OnClick="btnStarChallengue_Click" />
                </p>
            </section>
        </div>
    </main>

</asp:Content>
