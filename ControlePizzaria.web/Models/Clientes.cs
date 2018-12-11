using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePizzaria.web.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tel { get; set; }
        public string End { get; set; }
        public int Numr { get; set; }
        public string Compl { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}