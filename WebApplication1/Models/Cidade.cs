using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cidade
    {
        public Cidade () { }

        public int cidadeId { get; set; }

        public string descricao { get; set; }

        public int estadoID { get; set; }

        public string ddd { get; set; }

        public int codigoIbge { get; set; }

        public decimal cidadeAliqIss { get; set; }

        public int cidadeKm { get; set; }
    }
}