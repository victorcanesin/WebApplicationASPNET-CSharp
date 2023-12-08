using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Repositories;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) == false && string.IsNullOrWhiteSpace(txtSenha.Text) == false)
            {
                LoginRepository login = new LoginRepository();
                bool retornoLogin = login.conect(txtLogin.Text, txtSenha.Text);

                if (retornoLogin == true)
                {
                    FormsAuthentication.RedirectFromLoginPage(txtLogin.Text, false);
                    Response.Redirect("Home.aspx", false);
                }
                else
                {                    
                    lblMensagem.Text = "Usuário ou senha inválidos!";
                }
            }
        }
    }
}