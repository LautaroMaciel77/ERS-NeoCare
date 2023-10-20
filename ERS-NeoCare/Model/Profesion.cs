using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{

    
        [Table("profesion")]
    public class Profesion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("tipo_profesion")]
        public string TipoProfesion { get; set; }


    } 
    
}
