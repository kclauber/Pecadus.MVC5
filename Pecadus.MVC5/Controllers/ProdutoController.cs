using Pecadus.MVC4.Models;
using System.Web.Mvc;

namespace Pecadus.MVC4.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutoModel produto = new ProdutoModel()
            {
                Id = 1,
                Descricao = "George Orwell"
            };

            return View(produto);
        }
    }
}