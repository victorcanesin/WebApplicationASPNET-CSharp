using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1
{
    public partial class Cidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CidadeRepository cidades = new CidadeRepository();
            GridView1.DataSource = cidades.obterTodasCidades();
            GridView1.DataBind();
        }
      
        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroCidade.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            var valor = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

            if (e.CommandName.ToString() == "alterarCidade")
            {
                Response.Redirect("~/CadastroCidade.aspx?cidade=" + valor);
            }

            if (e.CommandName.ToString() == "excluirCidade")
            {
                CidadeRepository cidades = new CidadeRepository();
                cidades.excluirCidade(valor);
                GridView1.DataSource = null;
                GridView1.DataBind();
                GridView1.DataSource = cidades.obterTodasCidades();
                GridView1.DataBind();
            }
        }
    }
}