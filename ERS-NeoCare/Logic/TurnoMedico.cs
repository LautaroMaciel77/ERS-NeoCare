using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class TurnoMedico
    {
    
   
            private Presenter.PacienteService _model;

            public TurnoMedico(Presenter.PacienteService pacienteService)
            {
      
                _model = pacienteService;

            }
        public PacienteModel buscarPaciente(string dni)
        {
            PacienteModel  paciente = _model.Paciente(dni);
            return paciente;        }
            
    }
}
