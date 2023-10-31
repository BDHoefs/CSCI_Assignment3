<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="AutoRental.Administrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="modelView" runat="server" AutoGenerateColumns="False" DataKeyNames="ModelID">
        <Columns>
            <asp:BoundField DataField="ModelID" HeaderText="ModelID" InsertVisible="False" ReadOnly="True" SortExpression="ModelID" />
            <asp:BoundField DataField="ModelName" HeaderText="ModelName" SortExpression="ModelName" />
            <asp:BoundField DataField="AutoTypeID" HeaderText="AutoTypeID" SortExpression="AutoTypeID" />
            <asp:BoundField DataField="CargoSpace" HeaderText="CargoSpace" SortExpression="CargoSpace" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
</asp:GridView>
Model Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
<br />
Auto Type ID:<asp:TextBox ID="txtAutoType" runat="server"></asp:TextBox>
<br />
Cargo Space:
<asp:TextBox ID="txtCargoSpace" runat="server"></asp:TextBox>
<br />
<asp:Button ID="btnInsert" runat="server" Height="26px" Text="Insert" OnClick="btnInsert_Click" />
<asp:Button ID="Button2" runat="server" Text="Delete Selected" OnClick="Button2_Click" />
&nbsp;<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="AutoRental.ModelsDataContext" EntityTypeName="" TableName="Models">
</asp:LinqDataSource>
</asp:Content>
