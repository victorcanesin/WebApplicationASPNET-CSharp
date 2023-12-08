using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Repositories;

namespace WebApplication1
{
    public partial class Paises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PaisRepository pais = new PaisRepository();
            GridView1.DataSource = pais.obterTodosPaises();
            GridView1.DataBind();
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroPais.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            var valor = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

            if (e.CommandName.ToString() == "alterarPais")
            {
                Response.Redirect("~/CadastroPais.aspx?pais=" + valor);
            }

            if (e.CommandName.ToString() == "excluirPais")
            {
                PaisRepository pais = new PaisRepository();
                pais.excluirPais(valor);
                GridView1.DataSource = null;
                GridView1.DataBind();
                GridView1.DataSource = pais.obterTodosPaises();
                GridView1.DataBind();
            }
        }
    }
}