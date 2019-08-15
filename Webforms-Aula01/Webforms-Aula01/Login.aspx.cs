using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;


namespace WebForms_Aula01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        (string usuario, string senha) login;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            login.usuario = "admin";
            login.senha = "senha";

            UsuarioBLL usuarioBLL = new UsuarioBLL();

            if (usuarioBLL.Logar(txtLogin.Text, txtSenha.Text))
            {

                Session[Util.Util.SessaoUsuarioLogado] = usuarioBLL.UsuarioLogado;

                Response.Redirect("/Paginas/Principal.aspx");
            }
            else
            {
                lblMensagem.Text = "Usuario e/ou invalido";
            }

        }


    }
}
