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
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class PacientePresenter
    {
        private lista_paciente _view;
        private Presenter.PacienteService _service;

        public PacientePresenter(lista_paciente view, Presenter.PacienteService pacienteService)
        {
            _view = view;
            _service = pacienteService;
        }
        public PacientePresenter(Presenter.PacienteService pacienteService)
        {
       
            _service = pacienteService;
        }

        public void cargarMenu()
        {
         

        }
        public bool IngresarPaciente(PacienteModel paciente)
        {
            return _service.InsertarPaciente(paciente);
        }

        public void CargarDatosPaciente()
        {
         
            DataTable data = _service.ObtenerDatosPaciente();
            _view.MostrarDatosPaciente(data);
        }

        internal void cargarPaciente(string dni)
        {
            _service.BuscarPaciente(dni);
        }
    }
}
