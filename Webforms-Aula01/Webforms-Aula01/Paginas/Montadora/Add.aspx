<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebForms_Aula01.Paginas.Montadora.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="header">
        <h1>Montadora</h1>
        <h2>Cadastrar Novas Montadoras</h2>

    </div>

    <div class ="content">
        <div class="pure-form pure-form-stacked">
            <fieldset>
                <legend>Formulario de Cadastro</legend>
                 <label for="montadora">Nome da Montadora</label>
                <asp:TextBox ID="txtNomeMontadora" runat="server"/>
                <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" CssClass ="pure-button pure-button-primary" OnClick="btnCadastrar_Click"/>
                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass ="pure-button button-error" CausesValidation ="false" OnClick="btnCancelar_Click"/>
                <asp:RequiredFieldValidator ID="rfvNomeMontador" runat="server" ErrorMessage="Campo Obrigatorio" ControlToValidate ="txtNomeMontadora"></asp:RequiredFieldValidator>
                
            </fieldset>
        </div>

    </div>
</asp:Content>
