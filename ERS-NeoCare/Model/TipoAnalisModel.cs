using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("tipo_analisis")]
    public class TipoAnalisModel
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        [Column("descripcion")]
        public string descripcion { get; set; }
        
    }
}
