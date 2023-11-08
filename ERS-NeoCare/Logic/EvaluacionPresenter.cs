using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class EvaluacionPresenter
    {
        private evaluacion _viewEvaluacion;
        private EvaluacionService _service;

        public EvaluacionPresenter(evaluacion evaluacion, EvaluacionService service)
        {
            _viewEvaluacion = evaluacion;
            _service = service;
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
    }

}
