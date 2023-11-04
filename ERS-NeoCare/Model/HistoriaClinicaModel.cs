using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("historia_clinica")]
    public class HistoriaClinicaModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("fecha_inicio")]

        public DateTime FechaInicio { get; set; }

        [Column("Familiares")]
        public string Familiares { get; set; }

        [Column("alergias")]
        public string Alergias { get; set; }

        [Column("medicamentos")]
        public string Medicamentos { get; set; }

        [Column("estudios")]
        public string Estudios { get; set; }

        [Column("tipo_sangre")]
   
        public string TipoSangre { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual UsuarioModel Usuario { get; set; }

        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        [ForeignKey("IdPaciente")]
        public virtual PacienteModel Paciente { get; set; }

        public virtual List<ArchivoEstudio> ArchivosEstudio { get; set; }
    }
}
