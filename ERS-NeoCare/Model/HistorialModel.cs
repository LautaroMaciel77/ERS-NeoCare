﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERS_NeoCare.Design.administrativo;

namespace ERS_NeoCare.Model
{
    [Table("historial")]
    public class HistorialModel
    {
        [Key]
        [Column("id_historial")]
        public int IdHistorial { get; set; }

        [Column("Tipo")]
        public string Tipo { get; set; }

        [Column("id_turno")]
        public int? IdTurno { get; set; }

        [ForeignKey("IdTurno")]
        public virtual Turno Turno { get; set; }

        [Column("id_analisis")]
        public int? IdAnalisis { get; set; }

        [ForeignKey("IdAnalisis")]
        public virtual AnalisisModel Analisis { get; set; }

        [Column("id_atencion")]
        public int? IdAtencion { get; set; }

        [ForeignKey("IdAtencion")]
        public virtual AtencionEnfermeriaModel AtencionEnfermeria { get; set; }

        [Column("id_medico")]
        public int IdMedico { get; set; }

        [ForeignKey("IdMedico")]
        public virtual UsuarioModel Medico { get; set; }

        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public virtual PacienteModel Paciente { get; set; }

        [Column("FechaCreacion")]
        public DateTime FechaCreacion { get; set; }
    }
}


