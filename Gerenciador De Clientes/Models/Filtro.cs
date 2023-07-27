using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Gerenciador_De_Clientes.Models
{
    public class Filtro
    {
        public string NomeRazaoSocial { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Bloqueado { get; set; }
    }
}
