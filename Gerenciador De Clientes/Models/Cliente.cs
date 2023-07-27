using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciador_De_Clientes.Models
{
    public class Cliente
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome ou Razão Social")]
        [Column("NomeRazaoSocial")]
        public string NomeRazaoSocial { get; set; }

        [Display(Name = "CPF/CNPJ")]
        [Column("CpfCnpj")]
        public string CpfCnpj { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }
        
        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string Telefone { get; set; }
        
        [Display(Name = "Data do Cadastro")]
        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }
        
        [Display(Name = "Bloqueado")]
        [Column("Bloqueado")]
        public int Bloqueado { get; set; }

        [Display(Name = "Tipo")]
        [Column("Tipo")]
        public int Tipo { get; set;}

        [Display(Name = "Inscrição Estadual")]
        [Column("IncricaoEstadual")]
        public string ?IncricaoEstadual { get; set; }

        [Display(Name = "Isento")]
        [Column("Isento")]
        public int Isento { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Gênero")]
        [Column("Genero")]
        public int Genero { get; set; }

        [Display(Name = "Senha")]
        [Column("Senha")]
        public string Senha { get; set; }

        public void AlterarCliente(Cliente cliente)
        {
            this.NomeRazaoSocial = cliente.NomeRazaoSocial;
            this.CpfCnpj = cliente.CpfCnpj;
            this.Email = cliente.Email;
            this.Telefone = cliente.Telefone;
            this.Bloqueado = cliente.Bloqueado;
            this.Tipo = cliente.Tipo;
            this.IncricaoEstadual = cliente.IncricaoEstadual;
            this.Isento = cliente.Isento;
            this.DataNascimento = cliente.DataNascimento;
            this.Genero = cliente.Genero;
            this.Senha = cliente.Senha;
        }
    }
}
