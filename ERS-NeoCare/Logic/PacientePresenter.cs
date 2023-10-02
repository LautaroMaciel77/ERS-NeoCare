using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class PacientePresenter
    {
        private lista_paciente _view;
        private PacienteService _service;

        public PacientePresenter(lista_paciente view, PacienteService pacienteService)
        {
            _view = view;
            _service = pacienteService;
        }

        public void cargarMenu()
        {
            string dni=_view.dni;
           
            PacienteModel paciente = _service.Paciente(dni);

            if (paciente != null)
            {
                _view.MostrarMenu(paciente);
            }
            else
            {
               
            }

        }
        public void insertarPaciente()
        {
            
        }

    }
}
