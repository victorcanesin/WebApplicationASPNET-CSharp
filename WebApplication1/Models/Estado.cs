using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Estado
    {
        public Estado() { }

        public int estadoId { get; set; }

        public string estadoDescricao { get; set; }

        public string  estadoSigla { get; set;}

        public decimal estadoAliqIcms {  get; set; }

        public int paisID { get; set; }

        public int estadoSitCfo { get; set; }
    }
}