using Pecadus.MVC4.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Pecadus.MVC4.Controllers
{
    public class CarrinhoController : Controller
    {
        public ActionResult Index()
        {
            var produtos = new List<ProdutoModel>
            {
                new ProdutoModel {
                    Id = 1,
                    Descricao = "George Orwell"
                },
                new ProdutoModel {
                    Id = 2,
                    Descricao = "J.R.R. Tolkien"
                }
            };

            return View(produtos);
        }
    }
}