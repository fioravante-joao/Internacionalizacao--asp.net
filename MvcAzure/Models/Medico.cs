using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAzure.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Modalidade { get; set; }
    }
}