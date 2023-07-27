using Gerenciador_De_Clientes.Models;

namespace Gerenciador_De_Clientes.Data
{
    public interface IRepository
    {
        IEnumerable<Cliente> SelecionarClientes();

        IEnumerable<Cliente> SelecionarClientesPorFiltro(Filtro filtro);

        int CadastrarCliente(Cliente cliente);

        int AtualizarCliente(Cliente cliente);
    }
}
