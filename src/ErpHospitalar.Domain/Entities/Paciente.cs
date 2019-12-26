using ErpHospitalar.Domain.Enuns;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpHospitalar.Domain.Entities
{
    public class Paciente:EntityBase
    {
        public Paciente()
        {
            this.Ativo = true;
        }

        [ForeignKey("EstadoPaciente")]
        [Display(Name = "Estado do Paciente")]
        public Guid EstadoPacienteId { get; set; }

        public virtual EstadoPaciente EstadoPaciente { get; set; }
        public string  Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInternacao { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public string Cpf { get; set; }

        public TipoPaciente  TipoPaciente { get; set; }
        public Sexo Sexo { get; set; }
        public string Rg { get; set; }
        public string RgOrgao { get; set; }
        public string  RgDataEmissao { get; set; }

    }
}
