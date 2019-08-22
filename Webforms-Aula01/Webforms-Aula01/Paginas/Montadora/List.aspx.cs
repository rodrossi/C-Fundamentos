﻿using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Aula01.Paginas.Montadora
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MontadoraBLL montBLL = new MontadoraBLL();

            gvMontadora.DataSource = montBLL.Buscar();
            gvMontadora.DataBind();
        }

        protected void btnNovaMontadora_Click(object sender, EventArgs e)
        {
            Response.Redirect("add.aspx");
        }

        protected void gvMontadora_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}