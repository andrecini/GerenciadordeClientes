using AspNetCoreHero.ToastNotification.Abstractions;
using Gerenciador_De_Clientes.Data;
using Gerenciador_De_Clientes.Helper;
using Gerenciador_De_Clientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_De_Clientes.Controllers
{
    public class GerenciamentoController : Controller
    {
        private readonly ILogger<GerenciamentoController> _logger;
        private readonly IRepository _repository;
        private readonly Contexto _contexto;
        private INotyfService _notif { get; }

        public GerenciamentoController(ILogger<GerenciamentoController> logger, Contexto contexto, INotyfService notyfService, IRepository repository)
        {
            _logger = logger;
            _contexto = contexto;
            _notif = notyfService;
            _repository = repository;
        }

        public IActionResult CadastrarCliente()
        {
            return View();
        }

        public IActionResult Cadastrar(Cliente cliente)
        {
            var cadastroValido = new DataHelper(_contexto).ValidarCadastro(cliente);

            if (!cadastroValido.Valido)
            {
                _notif.Warning(cadastroValido.Mensagem);
                return View("CadastrarCliente");
            }

            var cadastrado = _repository.CadastrarCliente(cliente);

            _notif.Success("Cadastrado com Sucesso!");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult EditarCliente(int id)
        {
            var cliente = _contexto.Cliente.Find(id);
            return View(cliente);
        }

        public IActionResult Editar(Cliente cliente)
        {
            var editado = _repository.AtualizarCliente(cliente);

            _notif.Success("Atualizado com Sucesso!");

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Bloquear([FromBody]int id)
        {
            var cliente = _contexto.Cliente.Find(id);
            cliente.Bloqueado = cliente.Bloqueado == 1 ? 0 : 1;            

            var editado = _repository.AtualizarCliente(cliente);

            return RedirectToAction("Index", "Home");
        }
    }
}
