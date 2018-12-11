using ControlePizzaria.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControlePizzaria.web.DAL;
namespace ControlePizzaria.web.DAL
{
    public class PedidosDAL
    {
        public static List<Pedidos> listaPedidos;

        public static List<Pedidos> ListarPedidos()
        {   
            bool inicializarLista = true;

            if (listaPedidos == null)
                listaPedidos = new List<Pedidos>();
            else
                inicializarLista = false;

            if (inicializarLista)
            {
                listaPedidos.Add(new Pedidos() { Id = 1, Nome = "Carlos",Pedido = "Fanta-Coca Cola-Batata-Mussarela-", Total=10,Local= "Rua tal Nº150 - Bairro:Gonzaga - Cidade:Santos - Complemento: casa" });
               
            }

            return listaPedidos;
        }
    }
}
