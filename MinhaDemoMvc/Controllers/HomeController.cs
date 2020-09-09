using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index()
        {
            var filme = new Filme
            {
                Titulo = "007",
                DataLacamento = DateTime.Now,
                Genero = "Ação",
                Avaliacao = 10,
                Valor = 20000
            };



            return RedirectToAction("Privacy", filme);
            //return View();
        }

        [Route("privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var item in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(item.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
