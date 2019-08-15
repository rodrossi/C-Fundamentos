<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebForms_Aula01.Paginas.Montadora.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="header">
        <h1>Lista de Montadoras</h1>
        <h1>Listagem de Montadoras</h1>
    </div>
    <div class ="content">
    <table class="pure-table pure-table-bordered">
    <thead>
        <tr>
            <th>#</th>
            <th>Montadora</th>
            <th>Logo</th>
            
        </tr>
    </thead>

    <tbody>
        <tr>
            <td>1</td>
            <td>Honda</td>
            <td>LOGO1</td>
            
        </tr>

        <tr>
            <td>2</td>
            <td>Toyota</td>
            <td>LOGO2</td>
            
        </tr>

        <tr>
            <td>3</td>
            <td>Hyundai</td>
            <td>Logo3</td>
            
        </tr>
    </tbody>
</table>

        <asp:Button ID="btnNovaMontadora" runat="server" Text="Cadastar Nova"  CssClass ="pure-button pure-button-primary" OnClick="btnNovaMontadora_Click" />
        
        <asp:Button ID="btnDeleteMontadora" runat="server" Text="Deletar" CssClass ="pure-button button-error" />
        </div>
</asp:Content>
