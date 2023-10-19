using MeuSite.Models;
using MeuSite.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var conteudo = _produtoRepository.PegarTodos();
            return View(conteudo);
        }

     

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}