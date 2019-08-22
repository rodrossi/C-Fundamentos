<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebForms_Aula01.Paginas.Montadora.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="header">
        <h1>Lista de Montadoras</h1>
        <h1>Listagem de Montadoras</h1>
    </div>
    <div class ="content">
    
        <asp:GridView ID="gvMontadora" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

        <asp:Button ID="btnNovaMontadora" runat="server" Text="Cadastar Nova"  CssClass ="pure-button pure-button-primary" OnClick="btnNovaMontadora_Click" />
        
        <asp:Button ID="btnDeleteMontadora" runat="server" Text="Deletar" CssClass ="pure-button button-error" />
        </div>
</asp:Content>
