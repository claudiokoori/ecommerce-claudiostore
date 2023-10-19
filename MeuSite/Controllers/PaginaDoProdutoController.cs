using MeuSite.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MeuSite.Controllers
{
    public class PaginaDoProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public PaginaDoProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index(int id) 
        {
            var produto = _produtoRepository.BuscarPorId(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto); 
        }

        public IActionResult Comprar(int id)
        {
            _produtoRepository.Comprar(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
