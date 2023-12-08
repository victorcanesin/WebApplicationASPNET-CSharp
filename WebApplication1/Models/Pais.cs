using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pais
    {
        public Pais() { }

        public int paisId { get; set; }

        public string paisDescricao { get; set;}

        public string paisSigla { get; set;}
    }
}