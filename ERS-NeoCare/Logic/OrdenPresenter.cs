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
    
    }
}
