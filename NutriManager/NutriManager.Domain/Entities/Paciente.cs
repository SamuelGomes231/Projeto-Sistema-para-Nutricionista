using NutriManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Domain.Entities
{
    public class Paciente : BaseEntity<int>
    {
        public Paciente() { }
        public Paciente(int id, string nome, DateTime dataNascimento, string sexo, string telefone, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Telefone = telefone;
            this.Email = email;
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
