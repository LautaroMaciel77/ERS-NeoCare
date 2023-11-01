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

namespace ERS_NeoCare.Logic
{
    internal class ListaMedico
    {
     
            private PacientesMedico _view;
            private Presenter.PacienteService _model;

            public ListaMedico(PacientesMedico view, Presenter.PacienteService pacienteService)
            {
                _view = view;

                _model = pacienteService;

            }

            public void CargarDatosPaciente()
            {
            
                DataTable data = ConvertidorListDatatable.ConvertirListaPaciente(_model.ObtenerDatosPaciente());
                _view.MostrarDatosPaciente(data);
            }
            public void cargarMenu()
            {
                string dni = _view.userDni;

            PacienteModel paciente = _model.Paciente(dni);

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
