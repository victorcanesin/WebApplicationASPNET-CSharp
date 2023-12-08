using IBM.Data.Informix;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class LoginRepository
    {
        public LoginRepository() { }

        private static string connecString = "";
        public static string connectionString { get { return connecString; } }

        public bool conect(string login, string senha)
        {
            try
            {
                connecString = $"Host=127.0.0.1;Service=1525;Server=servidor;Database=banco;User Id={login};Password={senha};";

                using (var connection = new IfxConnection(connectionString))
                {
                    connection.Open();
                }

                // FormsAuthentication.RedirectFromLoginPage(login, false);
                return true;
            }
            catch 
            {
                //  FormsAuthentication.RedirectToLoginPage();
                return false;
            }
        }
    }
}