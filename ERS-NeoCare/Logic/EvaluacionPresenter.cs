using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Medico;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ERS_NeoCare.Logic
{
    internal class EvaluacionPresenter
    {
        private evaluacion _viewEvaluacion;

        private Evaluaciones _viewEvaluaciones;
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
        public EvaluacionPresenter(Evaluaciones view, EvaluacionService service)
        {
            _viewEvaluaciones = view;
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

        internal void Buscar(string searchText)
        {
            List<EvaluacionModel> datos = _service.ObtenerEvaluaciones().Where(p => p.IdMedico == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();

            List<EvaluacionModel> datosFiltrados;

            if (int.TryParse(searchText, out int dni))
            {
                string dniStr = dni.ToString();
                datosFiltrados = datos
                    .Where(p => p.Paciente.Dni.ToString().Contains(dniStr) || p.Medico.DNI.ToString().Contains(dniStr))
                    .ToList();
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                datosFiltrados = datos.Where(p =>
                    p.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || p.Medico.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || p.Medico.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Medico.Nombre + " " + p.Medico.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Paciente.Nombre + " " + p.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            DataTable data = ConvertidorListDatatable.ConvertirListaEvaluacion(datosFiltrados);
            _viewEvaluaciones.cargarEvaluaciones(data);

        }
        internal void traerEvaluaciones()
        {
            List<EvaluacionModel>datosFiltrados= _service.ObtenerEvaluaciones().Where(p => p.IdMedico==UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();
            DataTable data = ConvertidorListDatatable.ConvertirListaEvaluacion(datosFiltrados);
            _viewEvaluaciones.cargarEvaluaciones(data);
        }

        internal bool VerificarExistencia()
        {
            throw new NotImplementedException();
        }
    }

}
