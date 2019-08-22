using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Business;
using Business.Model;

namespace WebForms_Aula01.Paginas.Montadora
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            MontadoraBLL montadoraBLL = new MontadoraBLL();
            MontadoraModel model = new MontadoraModel();
            model.Logo = "teste png";
            model.Nome = txtNomeMontadora.Text;

            montadoraBLL.Salvar(model);
            Response.Redirect("list.aspx");

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}