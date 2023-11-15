using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERS_NeoCare.Helper;
using System.Data;
using ERS_NeoCare.Design.Paciente;
using System.Web.Services.Description;

namespace ERS_NeoCare.Logic
{
    internal class historialPresenter
    {
     
        private HistorialService _service;
        private HistoriaClinica historiaClinica;
        private HistorialService historialService;

        public historialPresenter(HistorialService service)
        {
         
            _service = service;
        }

        public historialPresenter(HistoriaClinica historiaClinica, HistorialService historialService)
        {
            this.historiaClinica = historiaClinica;
            _service = historialService;
        }

        public void Insertar(HistorialModel historialModel)
        {

            _service.Insertar(historialModel);
        }

        public void buscar(int idPaciente)
        {

            _service.buscar(idPaciente);
        }
        public void TraerHistorial()
        {

            List<HistorialModel> historialesUsuario = _service.ObtenerHistorial()
                .Where(h => h.Paciente.Id == PacienteSingleton.Instance.pacienteAutenticado.Id)
                .ToList();
            DataTable data = ConvertidorListDatatable.ConvertirListaHistorial(historialesUsuario);
            this.historiaClinica.CargarHistorial(data);
        }

    }
}
