using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class TipoAnalisisPresenter
    {
        private TipoAnalisisService service;
        private bd _view;
        public TipoAnalisisPresenter(bd view, TipoAnalisisService model)
        {
            _view=view;
             service = model;
        }

        public TipoAnalisisPresenter( TipoAnalisisService model)
        {
   
            service = model;
        }


        public void insertar(TipoAnalisModel tipo)
        {
            if (service.InsertarTipoAnalisis(tipo))
            {
                _view.MostrarMensaje("Exito al crear analisis");
                return;

            }
            _view.MostrarMensaje("Error al crear analisis");

        }

        internal List<TipoAnalisModel> ObtenerTiposAnalisis()
        {
          return  service.ObtenerTiposAnalisis();
        }
    }
}
