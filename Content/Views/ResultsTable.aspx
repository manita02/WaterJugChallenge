<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultsTable.aspx.cs" Inherits="WaterJugChallenge.ResultsTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .gridview-container {
            width: 100%;
        }
    </style>
    <br />
    <asp:Label ID="lbx" runat="server" Text="Total volume of jug X entered: "></asp:Label><br />
    <asp:Label ID="lby" runat="server" Text="Total volume of jug Y entered: "></asp:Label><br />
    <asp:Label ID="lbz" runat="server" Text="Z measurement entered: "></asp:Label><br />
    <br />

    <asp:GridView ID="table" runat="server" CssClass="gridview-container" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Explicacion" HeaderText="Explanation" />
            <asp:BoundField DataField="VolumenJug1" HeaderText="Current Volume of Jug X" />
            <asp:BoundField DataField="VolumenJug2" HeaderText="Current Volume of Jug Y" />
        </Columns>
    </asp:GridView>

    <br />
    <asp:Label ID="lbSolution" runat="server" Text="Final solution: "></asp:Label>


</asp:Content>
