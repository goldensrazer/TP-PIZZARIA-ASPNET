using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePizzaria.web.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pedido { get; set; }
        public string Local { get; set; }
        public int Total { get; set; }
    }
}