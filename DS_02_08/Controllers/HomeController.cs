using DS_02_08.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DS_02_08.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CadastrarPessoa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarPessoa(Pessoa objPessoa)
        {
            if (ModelState.IsValid) 
            { 
                return View("Resultado", objPessoa);
            }
                return View();
        }
        public IActionResult Resultado(Pessoa objPessoa)
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastrarProduto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarProduto(Produto objProduto)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoProduto", objProduto);
            }
            return View();
        }
        public IActionResult ResultadoProduto(Produto objProduto)
        {
            return View();
        }
    }
}
