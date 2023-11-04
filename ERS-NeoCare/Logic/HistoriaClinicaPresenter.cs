using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Design.Paciente;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class HistoriaClinicaPresenter
    {
        private HistoriaClinica _view;
        private HistoriaClinicaService _model;

        public HistoriaClinicaPresenter(HistoriaClinicaService model)
        {

            _model = model;
        }
        public HistoriaClinicaPresenter(HistoriaClinica view, HistoriaClinicaService model)
        {
            _view = view;
            _model = model;
        }

        public void Insertar(HistoriaClinicaModel HC, List<ArchivoEstudio> archivo)
        {
            if (_model.insertar(HC))
            {
                _view.mensaje("Exito");


            }

            _view.mensaje("ERROR");



        }

        public void Buscar()
        {
            _model.Buscar();
          //  if (HistoriaClinicaSingleton.Instance.historiaAutenticado == null)
           // {
             //   _model.Buscar();
               // return;           
           // }
            //




        }

        internal void Actualizar(HistoriaClinicaModel HC)
        {
            if (_model.Actualizar(HC))
            {
                _view.mensaje("Exito");
                return;

            }

            _view.mensaje("ERROR");


        }
    }
}
