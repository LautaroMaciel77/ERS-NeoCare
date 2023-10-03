using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Presenter
{
    internal class AgregarPacientePresenter
    {
        private agregar_paciente _view;
        private PacienteService _model;

        public AgregarPacientePresenter( PacienteService model)
        {
         
            _model = model;
        }

        public bool IngresarPaciente(Model.PacienteService paciente)
        {
            // Llama al método de inserción del modelo y devuelve el resultado
            return _model.InsertarPaciente(paciente);
        }




    }
}
