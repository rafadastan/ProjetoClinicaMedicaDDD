using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoClinicaMedica.Domain.Models
{
    public class Medico
    {
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string especializacao { get; set; }
        public int IdMedico { get; set; }
    }
}
