using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Aula01
{
    public partial class WebFormAula1 : System.Web.UI.Page
    {
      //  protected void Page_Load(object sender, EventArgs e)
      //  {
      //
      //  }
      //
      //  protected void btnCancelar_Click(object sender, EventArgs e)
      //  {
      //      LimparCampos();
      //      lblNomeCompleto.Text = string.Empty;
      //  }
      //
      //  protected void btnOK_Click(object sender, EventArgs e)
      //  {
      //      if (ValidarFormulario() == false)
      //      {
      //          lblNomeCompleto.Text = "Preencher todos os campos do Formulario";
      //          return;
      //      }
      //      lblNomeCompleto.Text = ExibirNomeCompleto(txtNome.Text,txtSobreNome.Text);
      //      LimparCampos();
      //  }
      //
      //  private string ExibirNomeCompleto(string nome, string sobrenome)
      //  {
      //      return $"{txtNome.Text} {txtSobreNome.Text}";
      //  }
      //
      //  private void LimparCampos()
      //  {
      //      txtNome.Text = string.Empty;
      //      txtSobreNome.Text = string.Empty;
      //   }
      //
      //  private bool ValidarFormulario()
      //  {
      //      bool valido = true;
      //
      //      if (txtNome.Text == string.Empty)
      //      {
      //          valido = false;  
      //      }
      //      if (txtSobreNome.Text == string.Empty)
      //      {
      //          valido = false;
      //      }
      //      return valido;
      //  }
      //
    }
}