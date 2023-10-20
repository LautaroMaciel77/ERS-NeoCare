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
    public class TurnoModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("selectedDate")]
        public DateTime? SelectedDate { get; set; }

        [Column("selectedTimeRange")]
        public TimeSpan SelectedTimeRange { get; set; }

        [Column("dni")]
        public string Dni { get; set; }

        [Column("profesion_id")]
        public int? ProfesionId { get; set; }

        [Column("prioridad")]
        public string Prioridad { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        [Column("notasComentarios")]
        public string NotasComentarios { get; set; }

        // Propiedad de navegación para la relación con la tabla Profesion
        public Profesion Profesion { get; set; }
    }

}
