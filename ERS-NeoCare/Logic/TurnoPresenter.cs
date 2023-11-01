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

        public TurnoPresenter(TurnoService service, turnoAdministrativo viewAdministrativo)
        {
            _service = service;
            _viewAdministrativo = viewAdministrativo;
        }

        public TurnoPresenter(TurnoService service)
        {
            _service = service;
        
        }
        public void insertarTurno(Turno turnoModel) {
            _viewAdministrativo.Insertar(_service.insertar(turnoModel));
          

        }
        public void RecopilarTurnos()
        {

        }

        public DataTable ListaTurnos()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            return data;
        }
     
    }
}
