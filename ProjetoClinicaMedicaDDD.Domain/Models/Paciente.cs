using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoClinicaMedica.Domain
{
    public class Paciente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int IdPaciente { get; set; }
    }
}
