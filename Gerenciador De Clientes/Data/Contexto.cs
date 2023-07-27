using Gerenciador_De_Clientes.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador_De_Clientes.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
