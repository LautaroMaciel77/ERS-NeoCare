using ERS_NeoCare.Design;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Presenter
{
    internal class IListaPacientePresenter
    {
        private lista_paciente _view;
        private PacienteModel _model;

        public IListaPacientePresenter(lista_paciente view)
        {
            _view = view;
            _model = new PacienteModel(Configuracion.ConnectionString); 

        }

        public void CargarDatosPaciente()
        {
            DataTable data = _model.ObtenerDatosPaciente();
            _view.MostrarDatosPaciente(data);
        }

    

      
    }
}

