using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("Evaluacion")]
    public class EvaluacionModel
    {
        [Key]
        [Column("id_evaluacion")]
        public int IdEvaluacion { get; set; }

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("sintomas")]
        public string Sintomas { get; set; }

        [Column("observaciones")]
        public string Observaciones { get; set; }

        [Column("indicaciones")]
        public string Indicaciones { get; set; }

        [Column("id_medico")]
        [ForeignKey("Medico")]
        public int IdMedico { get; set; }
        public virtual UsuarioModel Medico { get; set; }

        [Column("id_paciente")]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public virtual PacienteModel Paciente { get; set; }
    }
}
