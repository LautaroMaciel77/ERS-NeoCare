using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ERS_NeoCare.Logic
{
    internal class EvaluacionPresenter
    {
        private evaluacion _viewEvaluacion;
        private EvaluacionService _service;
        private EvaluacionService evaluacionService;

        public EvaluacionPresenter(evaluacionDatos evaluacionDatos, EvaluacionService evaluacionService)
        {
            _service = evaluacionService;
        }

        public EvaluacionPresenter(evaluacion evaluacion, EvaluacionService service)
        {
            _viewEvaluacion = evaluacion;
            _service = service;
        }

        public EvaluacionPresenter(EvaluacionService evaluacionService)
        {
            this.evaluacionService = evaluacionService;
        }

        internal void insertar(EvaluacionModel evaluacionModel)
        {
            if (_service.insertar(evaluacionModel))
            {

                _viewEvaluacion.mostrarMensaje("Exito al crear evaluacion");
                return;
            }
            _viewEvaluacion.mostrarMensaje("Error al crear evaluacion");
        }

        internal void BuscarPorId(int id)
        {
            _service.BuscarPorId(id);
        }

        
    }

}
