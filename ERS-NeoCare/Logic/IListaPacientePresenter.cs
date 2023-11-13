using ERS_NeoCare.Design;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ERS_NeoCare.Presenter
{
    internal class IListaPacientePresenter
    {
        private lista_paciente _view;
        private OrdenService _service;

        public IListaPacientePresenter(lista_paciente view)
        {
            _view = view;
            _service = new OrdenService(); 

        }

        public void CargarDatosPaciente()
        {
            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(_service.traerOrdenes().Where(t => t.Estado !=true).ToList());
            _view.MostrarDatosPaciente(data);
        }
        public void BuscarMedico(string searchText)
        {
            List<OrdenModel> listGeneral = _service.traerOrdenes().Where(t => t.Estado != true).ToList();

            List<OrdenModel> listfiltrada;
            if (int.TryParse(searchText, out int dni))
            {
                string dniStr = dni.ToString();
                listfiltrada = listGeneral
                    .Where(p => p.Paciente.Dni.ToString().Contains(dniStr))
                    .ToList();
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                listfiltrada = listGeneral.Where(p =>
                    p.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Paciente.Nombre + " " + p.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }


            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(listfiltrada);
            _view.MostrarDatosPaciente(data);
        }

    
        internal void CargarFiltro(bool v)
        {

            List<OrdenModel> ordenes = _service.traerOrdenes().Where(t => t.Medico.id == UsuarioSingleton.Instance.UsuarioAutenticado.id && t.Estado == v).ToList();

            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenes);

            _view.MostrarDatosPaciente(data);
        }

        internal void FiltroUrgencia(bool v)
        {
            List<OrdenModel> ordenes = _service.traerOrdenes().Where(t => t.Medico.id == UsuarioSingleton.Instance.UsuarioAutenticado.id && t.Urgencia == v).ToList();

            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenes);

            _view.MostrarDatosPaciente(data);
        }



    }
}

