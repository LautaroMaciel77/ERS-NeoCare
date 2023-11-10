using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("analisis")]
    public class AnalisisModel
    {
        [Key]
        [Column("id_analisis")]
        public int IdAnalisis { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Column("observaciones", TypeName = "TEXT")]
        public string Observaciones { get; set; }

        [Column("id_orden")]
        public int IdOrden { get; set; }

        [ForeignKey("IdOrden")]
        public OrdenModel Orden { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public UsuarioModel Usuario { get; set; }

        [Column("tipo_analisis")]
        public string TipoAnalisis { get; set; }

        [Column("id_archivo")]
        public int IdArchivo { get; set; }

        [ForeignKey("IdArchivo")]
        public ArchivoEstudio ArchivoEstudio { get; set; }

    }
}
