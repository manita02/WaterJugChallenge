<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Jug.aspx.cs" Inherits="WaterJugChallenge.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>

            <h2>Enter the requested values:</h2>
            <div>
                <asp:Label ID="lblJugX" runat="server" Text="Total volume of jug x:" AssociatedControlID="txtVolumeX"></asp:Label>
                <asp:TextBox ID="txtVolumeX" runat="server" CssClass="form-control" placeholder="type an integer"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblJugY" runat="server" Text="Total volume of jug Y:" AssociatedControlID="txtVolumeY"></asp:Label>
                <asp:TextBox ID="txtVolumeY" runat="server" CssClass="form-control" placeholder="type an integer"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="lblZ" runat="server" Text="Amount of water to measure between the two jugs (Z):" AssociatedControlID="txtVolumeZ"></asp:Label>
                <asp:TextBox ID="txtVolumeZ" runat="server" CssClass="form-control" placeholder="type an integer"></asp:TextBox>
            </div>
            <br/ >
            <asp:Label ID="lblJugInfo" runat="server"></asp:Label>
            <asp:Button ID="btnShowResults" runat="server" Text="FILL JUGS" OnClick="btnShowResults_Click" />

        </div>
</asp:Content>
