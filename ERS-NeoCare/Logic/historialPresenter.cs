using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class historialPresenter
    {
     
        private HistorialService _service;

        public historialPresenter(HistorialService service)
        {
         
            _service = service;
        }


        public void Insertar(HistorialModel historialModel)
        {

            _service.Insertar(historialModel);
        }
        public void TraerHistorial()
        {
            List<HistorialModel> historiales = _service.ObtenerHistorial();

            // Filtrar la lista según el id_paciente
            List<HistorialModel> historialesDelPaciente = historiales.Where(h => h.IdPaciente == PacienteSingleton.Instance.pacienteAutenticado.Id).ToList();
        }

    }
}
