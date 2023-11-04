using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    [Table("archivos_estudio")]
    public class ArchivoEstudio
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre_archivo")]
        public string NombreArchivo { get; set; }

        [Column("ubicacion")]
        public string Ubicacion { get; set; }

        [Column("id_historia_clinica")]
        public int IdHistoriaClinica { get; set; }

        [ForeignKey("IdHistoriaClinica")]
        public virtual HistoriaClinicaModel HistoriaClinica { get; set; }

        [Column("fecha_creacion")]
        public DateTime fecha_creacion { get; set; }

    }
}
