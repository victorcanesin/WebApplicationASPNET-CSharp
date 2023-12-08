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
    public partial class CadastroPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string valorPais = Request.QueryString["pais"];

                if (!string.IsNullOrWhiteSpace(valorPais))
                {
                    opcaoProc = "U";

                    PaisRepository repo = new PaisRepository();
                    Pais pais = repo.obterPais(Convert.ToInt32(valorPais));
                    txtCodigoPais.Text = pais.paisId.ToString();
                    txtNomePais.Text = pais.paisDescricao;
                    txtSiglaPais.Text = pais.paisSigla;                 
                }
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Paises.aspx");
        }

        private static string opcaoProc = "I";

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PaisRepository repo = new PaisRepository();
                if (opcaoProc == "I")
                {
                    repo.incluirPais(new Pais()
                    {
                        paisId = Convert.ToInt32(txtCodigoPais.Text),
                        paisDescricao = txtNomePais.Text,
                        paisSigla = txtSiglaPais.Text
                    });
                    Response.Redirect("Paises.aspx");
                }
                else
                {
                    repo.alterarPais(new Pais()
                    {
                        paisId = Convert.ToInt32(txtCodigoPais.Text),
                        paisDescricao = txtNomePais.Text,
                        paisSigla = txtSiglaPais.Text
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