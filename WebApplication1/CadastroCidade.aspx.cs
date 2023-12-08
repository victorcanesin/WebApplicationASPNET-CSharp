using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1
{
    public partial class CadastroCidade : System.Web.UI.Page
    {
        IEnumerable<Estado> Estados;

        private static string opcaoProc = "I";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                EstadoRepository EstRepo = new EstadoRepository();
                Estados = EstRepo.obterTodosEstados();

                foreach (Estado estado in Estados)
                {
                    ListItem item = new ListItem(estado.estadoDescricao, estado.estadoId.ToString());
                    cbbEstados.Items.Add(item);
                }

                string valorCidade = Request.QueryString["cidade"];

                if (!string.IsNullOrWhiteSpace(valorCidade))
                {
                    opcaoProc = "U";

                    CidadeRepository repo = new CidadeRepository();
                    Cidade cidade = repo.obterCidade(Convert.ToInt32(valorCidade));
                    txtCodigoCidade.Text = cidade.cidadeId.ToString();
                    txtNomeCidade.Text = cidade.descricao;
                    txtDdd.Text = cidade.ddd;
                    txtCodigoIbge.Text = cidade.codigoIbge.ToString();
                    cbbEstados.SelectedValue = cidade.estadoID.ToString();
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cidades.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CidadeRepository repo = new CidadeRepository();
                if (opcaoProc == "I")
                {
                    repo.incluirCidade(new Cidade() { cidadeId = Convert.ToInt32(txtCodigoCidade.Text), descricao = txtNomeCidade.Text, ddd = txtDdd.Text,
                        codigoIbge = Convert.ToInt32(txtCodigoIbge.Text), estadoID = Convert.ToInt32(cbbEstados.SelectedValue) });
                    Response.Redirect("Cidades.aspx");
                }
                else
                {
                    repo.alterarCidade(new Cidade()
                    {
                        cidadeId = Convert.ToInt32(txtCodigoCidade.Text),
                        descricao = txtNomeCidade.Text,
                        ddd = txtDdd.Text,
                        codigoIbge = Convert.ToInt32(txtCodigoIbge.Text),
                        estadoID = Convert.ToInt32(cbbEstados.SelectedValue)
                    }); ;
                   // Response.Redirect("Cidades.aspx");
                }
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}