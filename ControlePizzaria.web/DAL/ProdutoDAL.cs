using ControlePizzaria.web.Models;
using ControlePizzaria.web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlePizzaria.web.DAL
{
    public class ProdutoDAL
    {
        public static List<Produto> listaProdutos;

        public static List<Produto> ListarProdutos()
        {
            var Categorias = CategoriaDAL.ListarCategorias();
            bool inicializarLista = true;

            if (listaProdutos == null)
                listaProdutos = new List<Produto>();
            else
                inicializarLista = false;

            if (inicializarLista)
            {
                listaProdutos.Add(new Produto() { Id = 1, Nome = "Fanta", Categoria = Categorias.Find(x => x.Id == 1), Qtd = 20, Preco = 3 });
                listaProdutos.Add(new Produto() { Id = 2, Nome = "Coca Cola", Categoria = Categorias.Find(x => x.Id == 1), Qtd = 20, Preco = 4 });
                listaProdutos.Add(new Produto() { Id = 3, Nome = "Batata", Categoria = Categorias.Find(x => x.Id == 2), Qtd = 20, Preco = 10 });
                listaProdutos.Add(new Produto() { Id = 4, Nome = "Mussarela", Categoria = Categorias.Find(x => x.Id == 3), Qtd = 20, Preco = 20 });
            }

            return listaProdutos;
        }
    }
}