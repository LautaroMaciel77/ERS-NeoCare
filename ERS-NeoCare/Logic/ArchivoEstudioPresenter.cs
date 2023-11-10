using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Paciente;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class ArchivoEstudioPresenter
    {
        private HistoriaClinica _view;
        private analisis _viewAnalisis;
        private ArchivoEstudioService _model;

        public ArchivoEstudioPresenter(ArchivoEstudioService model)
        {

            _model = model;
        }
        public ArchivoEstudioPresenter(HistoriaClinica view, ArchivoEstudioService model)
        {
            _view = view;
            _model = model;
        }
        public ArchivoEstudioPresenter(analisis view, ArchivoEstudioService model)
        {
            _viewAnalisis = view;
            _model = model;
        }

        public void cargarArchivos()
        {
            _model.buscar(HistoriaClinicaSingleton.Instance.historiaAutenticado.Id);
            if (ArchivoEstudiosSingleton.Instance.archivosEstudio != null)
            {
                _view.cargarArchivos();
            }
        }

        internal void insertar(ArchivoEstudio archivo)
        {
            if (_model.insertar(archivo))
            {
                _view.mensaje("Archivo insertado");
                return;
            }
            _view.mensaje("error al guardar archivo");

        }
        internal bool insertarGeneral(ArchivoEstudio archivo)
        {
            return (_model.insertar(archivo));
            
           

        }
        internal void Borrar(List<ArchivoEstudio> archivosAEliminar)
        {
            if (_model.borrar(archivosAEliminar))
            {
                _view.mensaje("Archivo eliminado");
                return;
            }
            _view.mensaje("error al borrar archivo");
        }
    }
}
