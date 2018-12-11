using ControlePizzaria.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePizzaria.web.DAL
{
    public class ClientesDAL
    {
        public static List<Clientes> listaClientes;

        public static List<Clientes> ListarClientes()
        {
            bool inicializarLista = true;

            if (listaClientes == null)
                listaClientes = new List<Clientes>();
            else
                inicializarLista = false;

            if (inicializarLista)
            {
                listaClientes.Add(new Clientes() { Id = 1, Nome = "Andre",Tel ="13991332442",End ="Rua tal",Numr = 150,Compl = "casa",Bairro="Gonzaga",Cidade="Santos" });
                listaClientes.Add(new Clientes() { Id = 2, Nome = "Marcia",Tel = "13991332442", End = "Rua tal", Numr = 150, Compl = "casa", Bairro = "Gonzaga", Cidade = "Santos" });
                listaClientes.Add(new Clientes() { Id = 3, Nome = "Ricardo" ,Tel = "13991332442", End = "Rua tal", Numr = 150, Compl = "casa", Bairro = "Gonzaga", Cidade = "Santos" });
                listaClientes.Add(new Clientes() { Id = 4, Nome = "Junior" ,Tel = "13991332442", End = "Rua tal", Numr = 150, Compl = "casa", Bairro = "Gonzaga", Cidade = "Santos" });
            }

            return listaClientes;
        }
    }
}
