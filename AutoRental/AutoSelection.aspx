<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AutoSelection.aspx.cs" Inherits="AutoRental.AutoSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Auto Type"></asp:Label>
    <asp:DropDownList ID="autoTypeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="1">Standard SUV</asp:ListItem>
        <asp:ListItem Value="2">Full Size SUV</asp:ListItem>
        <asp:ListItem Value="3">Luxury SUV</asp:ListItem>
        <asp:ListItem Value="4">12 Passenger Van</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblRate" runat="server" Text="Standard rate: "></asp:Label>
    <br />
    <asp:Label ID="lblDiscount" runat="server" Text="Discount: "></asp:Label>
    <br />
    <asp:Label ID="lblInsurance" runat="server" Text="Insurance: "></asp:Label>
    <br />
    <asp:Label ID="lblDailyCost" runat="server" Text="Cost Per Day: "></asp:Label>
    <br />
    <asp:Label ID="lblTotalCost" runat="server" Text="Total cost: "></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Models"></asp:Label>
    <br />
    <asp:GridView ID="modelView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ModelName" HeaderText="ModelName" ReadOnly="True" SortExpression="ModelName" />
            <asp:BoundField DataField="CargoSpace" HeaderText="CargoSpace" ReadOnly="True" SortExpression="CargoSpace" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
&nbsp;<asp:LinqDataSource ID="ModelDataSource" runat="server" ContextTypeName="AutoRental.ModelsDataContext" EntityTypeName="" Select="new (ModelName, CargoSpace)" TableName="Models">
    </asp:LinqDataSource>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Discount Category"></asp:Label>
    <br />
    <asp:RadioButtonList ID="rdoDiscount" runat="server">
        <asp:ListItem>Best Rate</asp:ListItem>
        <asp:ListItem>Govt. Employee</asp:ListItem>
        <asp:ListItem>Business</asp:ListItem>
        <asp:ListItem>Favorite</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <br />
    <asp:CheckBox ID="chkInsurance" runat="server" Text="Insurance" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Number of days"></asp:Label>
    <asp:TextBox ID="txtDays" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnCompute" runat="server" Text="Compute Cost" OnClick="btnCompute_Click" />
    <asp:Button ID="btnClear" runat="server" Text="Clear" />
</asp:Content>
