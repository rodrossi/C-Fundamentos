using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Aula01
{
    public partial class Aula_Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lstEmails.Items.Add(txtEmail.Text);
            ddlEmails.Items.Add(txtEmail.Text);
            txtEmail.Text = string.Empty;
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            lstEmails.Items.RemoveAt(lstEmails.SelectionMode.GetHashCode());
        }

        protected void ddlEmails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}