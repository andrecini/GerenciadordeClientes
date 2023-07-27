using AspNetCoreHero.ToastNotification.Abstractions;
using Gerenciador_De_Clientes.Controllers;
using Gerenciador_De_Clientes.Data;
using Gerenciador_De_Clientes.Models;

namespace Gerenciador_De_Clientes.Helper
{
    public class DataHelper
    {
        private readonly Contexto _contexto;

        public DataHelper(Contexto contexto)
        {
            _contexto = contexto;
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
    }
}
