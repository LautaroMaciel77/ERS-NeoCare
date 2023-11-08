using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
   

        [Table("orden")]
        public class OrdenModel
        {
            [Key]
            [Column("id")]
            public int Id { get; set; }

            [Column("tipo_orden")]
            public string TipoOrden { get; set; }

            [Column("urgencia")]
            public bool Urgencia { get; set; }

            [Column("Indicaciones")]
            public string Indicaciones { get; set; }

            [Column("fecha_creacion")]
            public DateTime FechaCreacion { get; set; }

            [Column("id_personal_salud")]
            public int IdPersonalSalud { get; set; }

            [ForeignKey("IdPersonalSalud")]
            public virtual UsuarioModel Medico { get; set; }

            [Column("id_paciente")]
            public int IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public virtual PacienteModel Paciente { get; set; }
        [Column("estado")]
        public bool Estado { get;  set; }
    }
    
}
