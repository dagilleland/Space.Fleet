<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipSystems.WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Space Fleet <small>Ship Systems</small></h1>
    </div>

    <div class="row">
        <div class="col-md-3">
            <h2>Engines</h2>
            <asp:CheckBox ID="IsRunning" runat="server" />
            <asp:LinkButton ID="StartEngines" runat="server" OnClick="StartEngines_Click">Start</asp:LinkButton>
            <asp:LinkButton ID="ShutDownEngines" runat="server" OnClick="ShutDownEngines_Click">Shut Down</asp:LinkButton>
            <asp:LinkButton ID="BringOnline" runat="server" OnClick="BringOnline_Click">Bring Online</asp:LinkButton>
            <asp:LinkButton ID="TakeOffline" runat="server" OnClick="TakeOffline_Click">Take Offline</asp:LinkButton>
            Power: <asp:Label ID="PowerLevel" runat="server" />
            <asp:CheckBox ID="IsOnline" runat="server" /> Online
        </div>
        <div class="col-md-3">
            <h2>Shields</h2>
        </div>
        <div class="col-md-3">
            <h2>Weapons</h2>
        </div>
        <div class="col-md-3">
            <h2>Navigation</h2>
        </div>
    </div>

</asp:Content>
