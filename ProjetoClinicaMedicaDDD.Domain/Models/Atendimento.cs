using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoClinicaMedica.Domain.Models
{
    public class Atendimento
    {
        public int IdAtendimento { get; set; }
        public DateTime DataAtentimento { get; set; }
        public string Local { get; set; }
        public string Observacoes { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
    }
}
