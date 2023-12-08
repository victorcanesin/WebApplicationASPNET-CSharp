using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Repositories;

namespace WebApplication1
{
    public partial class Estados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EstadoRepository estados = new EstadoRepository();
            GridView1.DataSource = estados.obterTodosEstados();
            GridView1.DataBind();
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroEstados.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            var valor = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

            if (e.CommandName.ToString() == "alterarEstado")
            {
                Response.Redirect("~/CadastroEstados.aspx?estado=" + valor);
            }

            if (e.CommandName.ToString() == "excluirEstado")
            {
                EstadoRepository est = new EstadoRepository();
                est.excluirEstado(valor);
                GridView1.DataSource = null;
                GridView1.DataBind();
                GridView1.DataSource = est.obterTodosEstados();
                GridView1.DataBind();
            }
        }
    }
}