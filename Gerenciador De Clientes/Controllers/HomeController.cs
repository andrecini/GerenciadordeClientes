using AspNetCoreHero.ToastNotification.Abstractions;
using Gerenciador_De_Clientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace Gerenciador_De_Clientes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto _contexto;
        public INotyfService _notifyService { get; }

        public HomeController(ILogger<HomeController> logger, Contexto contexto, INotyfService notyfService)
        {
            _logger = logger;
            _contexto = contexto;
            _notifyService = notyfService;
        }

        public IActionResult Index()
        {
            var clientes = _contexto.Cliente;

            return View(clientes);
        }

        public IActionResult Filtrar(Filtro filtro)
        {
            var filtrados = FiltrarDados(filtro);

            ViewBag.Filtro = filtro;
            
            return View("Index", filtrados);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Cadastrar(Cliente cliente)
        {
            var cadastroValido = ValidarCadastro(cliente);

            if (!cadastroValido.Valido)
            {
                _notifyService.Warning(cadastroValido.Mensagem);
                return View("Cadastro");
            }

            _contexto.Cliente.Add(cliente);

            _contexto.SaveChanges();

            _notifyService.Success("Cadastrado com Sucesso!");


            return RedirectToAction("Index");
        }

        public IActionResult EditarCliente(int id)
        {
            var cliente = _contexto.Cliente.Find(id);
            return View(cliente);
        }

        public IActionResult Editar(Cliente cliente)
        {
            var clienteExistente = _contexto.Cliente.Find(cliente.Id);

            if (clienteExistente != null)
                clienteExistente.AlterarCliente(cliente);

            _contexto.SaveChanges();

            _notifyService.Success("Atualizado com Sucesso!");

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public Validacao ValidarCadastro(Cliente cliente)
        {
            var emailJaCadastrado = EmailJaCadastrado(cliente.Email);
            var cpfCpnjJaCadastrado = CpfCpnjJaCadastrado(cliente.CpfCnpj);
            var inscricaoEstadualJaCadastrado = InscricaoEstadualJaCadastrado(cliente.IncricaoEstadual);

            if (!emailJaCadastrado.Valido)
            {
                return emailJaCadastrado;
            }
            else if (!cpfCpnjJaCadastrado.Valido)
            {
                return cpfCpnjJaCadastrado;
            }
            else if (string.IsNullOrEmpty(cliente.IncricaoEstadual) && !inscricaoEstadualJaCadastrado.Valido)
            {
                return inscricaoEstadualJaCadastrado;
            }
            else
            {
                return new Validacao
                {
                    Valido = true,
                    Mensagem = ""
                };
            }
        }

        public Validacao EmailJaCadastrado(string email)
        {
            var clienteComMesmoEmail = _contexto.Cliente.Any(c => c.Email == email);

            if (clienteComMesmoEmail)
            {
                return new Validacao
                {
                    Valido = false,
                    Mensagem = "Este e-mail já está cadastrado para outro Cliente"
                };
            }
            else
            {
                return new Validacao
                {
                    Valido = true,
                    Mensagem = ""
                };
            }
        }

        public Validacao CpfCpnjJaCadastrado(string cpfCnpj)
        {
            var clienteComMesmoCnpj = _contexto.Cliente.Any(c => c.CpfCnpj == cpfCnpj);

            if (clienteComMesmoCnpj)
            {
                return new Validacao
                {
                    Valido = false,
                    Mensagem = "Este CPF/CNPJ já está cadastrado para outro Cliente"
                };
            }
            else
            {
                return new Validacao
                {
                    Valido = true,
                    Mensagem = ""
                };
            }
        }

        public Validacao InscricaoEstadualJaCadastrado(string cpfCnpj)
        {
            var clienteComMesmoInscricao = _contexto.Cliente.Any(c => c.CpfCnpj == cpfCnpj);

            if (clienteComMesmoInscricao)
            {
                return new Validacao
                {
                    Valido = false,
                    Mensagem = "Esta Inscrição Estadual já está cadastrada para outro Cliente"
                };
            }
            else
            {
                return new Validacao
                {
                    Valido = true,
                    Mensagem = ""
                };
            }
        }       

        public IEnumerable<Cliente> FiltrarDados(Filtro filtro)
        {
            IQueryable<Cliente> consulta = _contexto.Cliente;

            if (!string.IsNullOrEmpty(filtro.NomeRazaoSocial))
            {
                consulta = consulta.Where(c => c.NomeRazaoSocial.ToLower().Contains(filtro.NomeRazaoSocial.ToLower()));
            }

            if (!string.IsNullOrEmpty(filtro.Email))
            {
                consulta = consulta.Where(c => c.Email.ToLower().Contains(filtro.Email.ToLower()));
            }

            if (!string.IsNullOrEmpty(filtro.Telefone))
            {
                consulta = consulta.Where(c => c.Telefone.ToLower().Contains(filtro.Telefone.ToLower()));
            }

            if (filtro.DataCadastro.ToString("ddMMyy") != "010101")
            {
                consulta = consulta.Where(c => c.DataCadastro.Date == filtro.DataCadastro);
            }

            if (filtro.Bloqueado != 2)
            {
                consulta = consulta.Where(c => c.Bloqueado == filtro.Bloqueado);
            }

            return consulta.ToList();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}