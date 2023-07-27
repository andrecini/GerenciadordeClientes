using Gerenciador_De_Clientes.Models;
using Microsoft.AspNetCore.Server.HttpSys;

namespace Gerenciador_De_Clientes.Data
{
    

    public class Repository : IRepository
    {
        private readonly Contexto _contexto;
        public Repository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Cliente> SelecionarClientes()
        {
            return _contexto.Cliente;
        }

        public IEnumerable<Cliente> SelecionarClientesPorFiltro(Filtro filtro)
        {
            IQueryable<Cliente> clientes = _contexto.Cliente;

            if (!string.IsNullOrEmpty(filtro.NomeRazaoSocial))
            {
                clientes = clientes.Where(c => c.NomeRazaoSocial.ToLower().Contains(filtro.NomeRazaoSocial.ToLower()));
            }

            if (!string.IsNullOrEmpty(filtro.Email))
            {
                clientes = clientes.Where(c => c.Email.ToLower().Contains(filtro.Email.ToLower()));
            }

            if (!string.IsNullOrEmpty(filtro.Telefone))
            {
                clientes = clientes.Where(c => c.Telefone.ToLower().Contains(filtro.Telefone.ToLower()));
            }

            if (filtro.DataCadastro.ToString("ddMMyy") != "010101")
            {
                clientes = clientes.Where(c => c.DataCadastro.Date == filtro.DataCadastro);
            }

            if (filtro.Bloqueado != 2)
            {
                clientes = clientes.Where(c => c.Bloqueado == filtro.Bloqueado);
            }

            return clientes.ToList();
        }

        public int CadastrarCliente(Cliente cliente)
        {
            _contexto.Cliente.Add(cliente);

            return _contexto.SaveChanges();
        }

        public int AtualizarCliente(Cliente cliente)
        {
            var clienteExistente = _contexto.Cliente.Find(cliente.Id);

            if (clienteExistente != null)
                clienteExistente.AlterarCliente(cliente);

            return _contexto.SaveChanges();
        }
    }
}
