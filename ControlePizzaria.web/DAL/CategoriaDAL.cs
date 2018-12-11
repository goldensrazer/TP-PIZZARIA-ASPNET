using ControlePizzaria.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePizzaria.web.DAL
{
    public class CategoriaDAL
    {
        public static List<Categoria> listaCategorias;

        public static List<Categoria> ListarCategorias()
        {
            bool inicializarLista = true;

            if (listaCategorias == null)
                listaCategorias = new List<Categoria>();
            else
                inicializarLista = false;

            if (inicializarLista)
            {
                listaCategorias.Add(new Categoria() { Id = 1, Nome = "Pizzas" });
                listaCategorias.Add(new Categoria() { Id = 2, Nome = "Bebidas" });
                listaCategorias.Add(new Categoria() { Id = 3, Nome = "Lanches" });
                listaCategorias.Add(new Categoria() { Id = 4, Nome = "Porções" });
            }

            return listaCategorias;
        }
    }
}