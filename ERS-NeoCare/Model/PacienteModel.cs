using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERS_NeoCare.Model
{
    [Table("Paciente")]
    public class PacienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("dni")]
        public int Dni { get; set; }

        [MaxLength(100)]
        [Column("nombre")]
        public string Nombre { get; set; }

        [MaxLength(100)]
        [Column("apellido")]
        public string Apellido { get; set; }

        [MaxLength(150)]
        [Column("domicilio")]
        public string Domicilio { get; set; }

        [Column("fecha_nacimiento", TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(10)]
        [Column("sexo")]
        public string Sexo { get; set; }

        [MaxLength(100)]
        [Column("obra_social")]
        public string ObraSocial { get; set; }



        [MaxLength(1)]
        [Column("baja")]
        public string Baja { get; set; }

        [MaxLength(100)]
        [Column("condicion")]
        public string Condicion { get; set; }


    }
}



