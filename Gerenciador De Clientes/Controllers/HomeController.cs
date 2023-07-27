using AspNetCoreHero.ToastNotification.Abstractions;
using Gerenciador_De_Clientes.Data;
using Gerenciador_De_Clientes.Helper;
using Gerenciador_De_Clientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace Gerenciador_De_Clientes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;
        private readonly Contexto _contexto;
        private INotyfService _notif { get; }

        public HomeController(ILogger<HomeController> logger, Contexto contexto, INotyfService notyfService, IRepository repository)
        {
            _logger = logger;
            _contexto = contexto;
            _notif = notyfService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            var clientes = _contexto.Cliente;

            return View(clientes);
        }

        public IActionResult Filtrar(Filtro filtro)
        {
            var filtrados = _repository.SelecionarClientesPorFiltro(filtro);

            ViewBag.Filtro = filtro;
            
            return View("Index", filtrados);
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}