using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ErpHospitalar.Domain.Entities
{
    public class EstadoPaciente: EntityBase
    {
     
        public string Descricao { get; set; }
        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
