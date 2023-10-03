using ERS_NeoCare.Design;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ERS_NeoCare.Logic
{
    internal class listaPacienteBio
    {
        private lista_paciente_bioquimico _view;
        private Presenter.PacienteService _model;

        public listaPacienteBio(lista_paciente_bioquimico view, Presenter.PacienteService pacienteService)
        {
            _view = view;
            _model = pacienteService;

        }

        public void CargarDatosPaciente()
        {
            DataTable data = _model.ObtenerDatosPaciente();
            _view.MostrarDatosPaciente(data);
        }
        public void cargarMenu()
        {
            string dni = _view.userDni;

            Model.PacienteService paciente = _model.Paciente(dni);

            if (paciente != null)
            {
                _view.MostrarMenu(paciente);
            }
            else
            {

            }




        }
    }
}
