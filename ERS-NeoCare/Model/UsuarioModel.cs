using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERS_NeoCare.Model
{
 
        [Table("personal_salud")]
        public class UsuarioModel
        {
            [Key]
            [Column("id")]
            public int id { get; set; }

            [Column("matricula")]
            public int Matricula { get; set; }

            [Column("dni")]
            public int DNI { get; set; }

            [Column("nombre")]
            [Required]
            [MaxLength(100)]
            public string Nombre { get; set; }

            [Column("apellido")]
            [MaxLength(100)]
            public string Apellido { get; set; }

            [Column("profesion_id")]
           [ForeignKey("Profesion")]
              public int ProfesionID { get; set; }

            [Column("pass")]
            [Required]
            [MaxLength(100)]
            public string Password { get; set; }

            [Column("baja")]
            public char? Baja { get; set; }

      
        public virtual Profesion Profesion { get; set; }

    }


}
