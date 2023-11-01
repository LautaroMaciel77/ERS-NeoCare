using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class TurnoPresenter
    {

        public TurnoService _service;
        public turnoAdministrativo _viewAdministrativo;
        public ListaTurnosAdministrativo _viewlista;
        public TurnoPresenter(turnoAdministrativo view, TurnoService service)
        {
            _service = service;
            _viewAdministrativo = view;
        }

        public TurnoPresenter(ListaTurnosAdministrativo view, TurnoService service)
        {
            _service = service;
            _viewlista = view;
        }
        public TurnoPresenter(TurnoService service)
        {
            _service = service;
        
        }
        public void insertarTurno(Turno turnoModel) {
            _viewAdministrativo.Insertar(_service.insertar(turnoModel));
          

        }
        public List<Turno> RecopilarTurnos()
        {
            return _service.ObtenerDatos();
        }

        public void ListaTurnos()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            _viewlista.cargarDatos(data);
        }

        internal void ObtenerTurnoEstado(string v)
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerTurnoEstado(v));
            _viewlista.cargarDatos(data);
        }
    }
}
