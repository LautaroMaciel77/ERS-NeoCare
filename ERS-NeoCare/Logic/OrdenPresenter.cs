using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERS_NeoCare.Helper;
using System.Data;
using ERS_NeoCare.Design.Medico;

namespace ERS_NeoCare.Logic
{
    internal class OrdenPresenter
    {
        public OrdenService _service;
        private OrdenMedico _view;
        private EstadoOrden _viewEstados;


        public OrdenPresenter(OrdenMedico view, OrdenService service )
        {
            _service = service;
            _view = view;
        }
        public OrdenPresenter(EstadoOrden view, OrdenService service)
        {
            _service = service;
            _viewEstados = view;
        }
        public OrdenPresenter( OrdenService service)
        {
            _service = service;
       
        }
        public void Insertar(OrdenModel orden)
        {
            if (_service.Insertar(orden))
            {
                _view.mensaje("orden guardada");
                return;
            }
            _view.mensaje("error al guardar orden");

        }
        public List<OrdenModel> traerListaOrdenes()
        {


            List<OrdenModel> data = _service.traerOrdenes();
            return data;
        }
        public void traerOrdenes()
        {


            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(_service.traerOrdenes());
            _viewEstados.cargarOrdenes(data);
        }
        public void BuscarMedico(string searchText)
        {
            List<OrdenModel> listGeneral = _service.traerOrdenes().Where(t => t.Medico.id == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();

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
            _viewEstados.cargarOrdenes(data);
        }

        internal void cambiarEstado(int id)
        {
            _service.CambiarEstado(id);
        
        }
        internal void CargarFiltro(bool v)
        {

            List<OrdenModel> ordenes = _service.traerOrdenes().Where(t => t.Medico.id == UsuarioSingleton.Instance.UsuarioAutenticado.id && t.Estado==v).ToList();

            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenes);

            _viewEstados.cargarOrdenes(data);
        }

        internal void FiltroUrgencia(bool v)
        {
            List<OrdenModel> ordenes = _service.traerOrdenes().Where(t => t.Medico.id == UsuarioSingleton.Instance.UsuarioAutenticado.id && t.Urgencia == v).ToList();

            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenes);

            _viewEstados.cargarOrdenes(data);
        }


    }
}
