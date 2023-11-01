using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("Turno")]
 
    public class Turno
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("selectedDate")]
        public DateTime? SelectedDate { get; set; }

        [Column("selectedTimeRange")]
        public TimeSpan? SelectedTimeRange { get; set; }

        [Column("prioridad")]
        [MaxLength(10)]
        public string Prioridad { get; set; }

        [Column("estado")]
        [MaxLength(50)]
        public string Estado { get; set; }

        [Column("notasComentarios")]
        public string NotasComentarios { get; set; }

        [Column("medico_id")]
        [ForeignKey("Medico")]
        public int Medico_Id { get; set; }
        public virtual UsuarioModel Medico { get; set; }

        [Column("paciente_id")]
        [ForeignKey("Paciente")]
        public int Paciente_Id { get; set; }
        public virtual PacienteModel Paciente { get; set; }
    }

}
