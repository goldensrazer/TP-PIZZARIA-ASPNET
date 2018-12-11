using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlePizzaria.web.DAL;
using ControlePizzaria.web.Models;


namespace ControlePizzaria.web.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Categoria()
        {
            ViewBag.Categoria = CategoriaDAL.ListarCategorias();
            return View();
        }


        public ActionResult ObterCategoria(int id)
        {
            return Json(CategoriaDAL.ListarCategorias().Find(x => x.Id == id));
        }

        public ActionResult ExcluirCategoria(int id)
        {
            var ret = false;
            var categoria = CategoriaDAL.ListarCategorias().Find(x => x.Id == id);

            if (categoria != null)
            {
                CategoriaDAL.ListarCategorias().Remove(categoria);
                ret = true;
            }

            return Json(ret);
        }

        public ActionResult SalvarCategoria(Categoria categoria)
        {
            var categoriaBD = CategoriaDAL.ListarCategorias().Find(x => x.Id == categoria.Id);

            if (categoriaBD == null)
            {
                categoriaBD = categoria;
                categoriaBD.Id = CategoriaDAL.ListarCategorias().Max(x => x.Id) + 1;
                CategoriaDAL.ListarCategorias().Add(categoriaBD);
            }
            else
            {
                categoriaBD.Nome = categoria.Nome;
            }

            return Json(categoriaBD);
        }

        //Parte produtos
        public ActionResult Produto()
        {
            ViewBag.Produto = ProdutoDAL.ListarProdutos();
            ViewBag.Categorias = CategoriaDAL.ListarCategorias();
            return View();
        }

        public ActionResult ObterProduto(int id)
        {
            return Json(ProdutoDAL.ListarProdutos().Find(x => x.Id == id));
        }

        public ActionResult ExcluirProduto(int id)
        {
            var ret = false;
            var Produto = ProdutoDAL.ListarProdutos().Find(x => x.Id == id);

            if (Produto != null)
            {
                ProdutoDAL.ListarProdutos().Remove(Produto);
                ret = true;
            }

            return Json(ret);
        }

        public ActionResult SalvarProduto(Produto Produto)
        {
            var ProdutoBD = ProdutoDAL.ListarProdutos().Find(x => x.Id == Produto.Id);

            if (ProdutoBD == null)
            {
                ProdutoBD = Produto;
                ProdutoBD.Id = ProdutoDAL.ListarProdutos().Max(x => x.Id) + 1;
                ProdutoDAL.ListarProdutos().Add(ProdutoBD);
            }
            else
            {
                ProdutoBD.Nome = Produto.Nome;
                ProdutoBD.Categoria = CategoriaDAL.ListarCategorias().Find(x => x.Id == Produto.Categoria.Id);
                ProdutoBD.Preco = Produto.Preco;
                ProdutoBD.Qtd = Produto.Qtd;
            }

            return Json(ProdutoBD);
        }


        //CLientes
        public ActionResult Clientes()
        {
            ViewBag.Clientes = ClientesDAL.ListarClientes();
            return View();
        }

        public ActionResult ObterClientes(int id)
        {
            return Json(ClientesDAL.ListarClientes().Find(x => x.Id == id));
        }

        public ActionResult ExcluirClientes(int id)
        {
            var ret = false;
            var Clientes = ClientesDAL.ListarClientes().Find(x => x.Id == id);

            if (Clientes != null)
            {
                ClientesDAL.ListarClientes().Remove(Clientes);
                ret = true;
            }

            return Json(ret);
        }

        public ActionResult SalvarClientes(Clientes Clientes)
        {
            var ClientesBD = ClientesDAL.ListarClientes().Find(x => x.Id == Clientes.Id);

            if (ClientesBD == null)
            {
                ClientesBD = Clientes;
                ClientesBD.Id = ClientesDAL.ListarClientes().Max(x => x.Id) + 1;
                ClientesDAL.ListarClientes().Add(ClientesBD);
            }
            else
            {
                ClientesBD.Nome = Clientes.Nome;
                ClientesBD.Tel = Clientes.Tel;
                ClientesBD.End = Clientes.End;
                ClientesBD.Numr = Clientes.Numr;
                ClientesBD.Compl = Clientes.Compl;
                ClientesBD.Bairro = Clientes.Bairro;
                ClientesBD.Cidade = Clientes.Cidade;

            }

            return Json(ClientesBD);
        }

        //Pedidos
        public ActionResult Pedidos()
        {
            ViewBag.Pedidos = PedidosDAL.ListarPedidos();
            ViewBag.Produtos = ProdutoDAL.ListarProdutos();
            ViewBag.Clientes = ClientesDAL.ListarClientes();
            return View();
        }

        public ActionResult ObterPedidos(int id)
        {
            return Json(PedidosDAL.ListarPedidos().Find(x => x.Id == id));
        }

        public ActionResult ExcluirPedidos(int id)
        {
            var ret = false;
            var Pedidos = PedidosDAL.ListarPedidos().Find(x => x.Id == id);

            if (Pedidos != null)
            {
                PedidosDAL.ListarPedidos().Remove(Pedidos);
                ret = true;
            }

            return Json(ret);
        }

        public ActionResult SalvarPedidos(Pedidos Pedidos)
        {
            var PedidosBD = PedidosDAL.ListarPedidos().Find(x => x.Id == Pedidos.Id);

            if (PedidosBD == null)
            {
                PedidosBD = Pedidos;
                PedidosBD.Id = PedidosDAL.ListarPedidos().Max(x => x.Id) + 1;
                PedidosDAL.ListarPedidos().Add(PedidosBD);
            }
            else
            {
                PedidosBD.Nome = Pedidos.Nome;
                PedidosBD.Pedido = Pedidos.Pedido;
                PedidosBD.Total = Pedidos.Total;
                PedidosBD.Local = Pedidos.Local;
            }

            return Json(PedidosBD);
        }
    }
}