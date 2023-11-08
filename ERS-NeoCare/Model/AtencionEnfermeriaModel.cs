using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("atencion_enfermeria")]
    public class AtencionEnfermeriaModel
    {
        [Key]
        [Column("id_atencion")]
        public int IdAtencion { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("observaciones", TypeName = "TEXT")]
        public string Observaciones { get; set; }

        [Column("indicaciones", TypeName = "TEXT")]
        public string Indicaciones { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }

        [Column("id_orden")]
        public int IdOrden { get; set; }

        [ForeignKey("IdOrden")]
        public OrdenModel Orden { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public UsuarioModel Usuario { get; set; }

        [Column("id_medico")]
        public int IdMedico { get; set; }

        [ForeignKey("IdMedico")]
        public UsuarioModel Medico { get; set; }

        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        [ForeignKey("IdPaciente")]
        public PacienteModel Paciente { get; set; }
    }
}
