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
    public partial class CadastroEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string valorEstado = Request.QueryString["estado"];

                if (!string.IsNullOrWhiteSpace(valorEstado))
                {
                    opcaoProc = "U";

                    EstadoRepository repo = new EstadoRepository();
                    Estado est = repo.obterEstado(Convert.ToInt32(valorEstado));
                    txtCodigoEstado.Text = est.estadoId.ToString();
                    txtNomeEstado.Text = est.estadoDescricao;
                    txtSiglaEstado.Text = est.estadoSigla;
                    txtCodigoPais.Text = est.paisID.ToString();
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estados.aspx");
        }

        private static string opcaoProc = "I";

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                EstadoRepository repo = new EstadoRepository();
                if (opcaoProc == "I")
                {
                    repo.incluirEstado(new Estado()
                    {
                        estadoId = Convert.ToInt32(txtCodigoEstado.Text),
                        estadoDescricao = txtNomeEstado.Text,
                        estadoSigla = txtSiglaEstado.Text,
                        estadoAliqIcms = 0,
                        paisID = Convert.ToInt32(txtCodigoPais.Text)

                    }); 
                    Response.Redirect("Estados.aspx");
                }
                else
                {
                    repo.alterarEstado(new Estado()
                    {
                        estadoId = Convert.ToInt32(txtCodigoEstado.Text),
                        estadoDescricao = txtNomeEstado.Text,
                        estadoSigla = txtSiglaEstado.Text,
                        estadoAliqIcms = 0,
                        paisID = Convert.ToInt32(txtCodigoPais.Text)

                    });
                    // Response.Redirect("Paises.aspx");
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}