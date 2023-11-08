using ERS_NeoCare.Design;
using ERS_NeoCare.Helper;
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
        private OrdenService _model;

        public ListaPacienteEnf(lista_paciente_enfermero view, OrdenService pacienteService)
        {
            _view = view;
            _model = pacienteService;

        }


        public void CargarDatosPaciente()
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();
       
            List<OrdenModel> ordenesEnf = ordenes.Where(o => o.TipoOrden == "Atencion").ToList();
            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenes);
            _view.MostrarDatosPaciente(data);
    }

 

        public void cargarMenu(Presenter.PacienteService _model)
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

