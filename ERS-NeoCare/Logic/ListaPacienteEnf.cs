using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class ListaPacienteEnf
    {
        private lista_paciente_enfermero _view;
        private Presenter.PacienteService _model;

             public ListaPacienteEnf(lista_paciente_enfermero view, Presenter.PacienteService pacienteService)
             {
                _view = view;
                _model = pacienteService;

             }

    public void CargarDatosPaciente()
    {
        DataTable data = _model.ObtenerDatosPaciente();
        _view.MostrarDatosPaciente(data);
    }

        public Presenter.PacienteService Get_model()
        {
            return _model;
        }

        public void cargarMenu(Presenter.PacienteService _model)
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

