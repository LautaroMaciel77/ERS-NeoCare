using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class AtencionPresenter
    {
        private AtencionService _model;
        private atencion _view;
        lista_atenciones_enfermero _viewLista;
        private atencionDatos atencionDatos;
        private AtencionService atencionService;

        public AtencionPresenter(atencion view, AtencionService model)
        {
            _view = view;
            _model = model;
        }
        public AtencionPresenter(lista_atenciones_enfermero view, AtencionService model)
        {
            _viewLista = view;
            _model = model;
        }

        public AtencionPresenter(atencionDatos atencionDatos, AtencionService atencionService)
        {
            this.atencionDatos = atencionDatos;
            this.atencionService = atencionService;
        }

        public void insertar(AtencionEnfermeriaModel model)
        {
            if (_model.Insertar(model))
            {
                _view.mensaje("Exito al insertar");
                return;
            }
            _view.mensaje("error al insertar");

        }
        public void ObtenerAtenciones()
        {


            DataTable data = ConvertidorListDatatable.ConvertirAtenciones(_model.ObtenerAtenciones());
            _viewLista.CargarDatosPaciente(data);
        }

        internal void buscar(string id)
        {
            _model.buscar(id);
        }

        internal void buscarTexto(string searchText)
        {
                List<AtencionEnfermeriaModel> datos = _model.ObtenerAtenciones();

                if (int.TryParse(searchText, out int dni))
                {      
                List<AtencionEnfermeriaModel> resultadosPorDNI = datos
                    .Where(d => d.Paciente.Dni.ToString().StartsWith(searchText) || d.Medico.DNI.ToString().StartsWith(searchText))
                    .ToList();
             
                DataTable dataTablePorDNI = ConvertidorListDatatable.ConvertirAtenciones(resultadosPorDNI);

                    _viewLista.CargarDatosPaciente(dataTablePorDNI);
                }
                else
                {
                    // Realiza por nombre del paciente, nombre del médico o nombre completo sin distinción 
                    List<AtencionEnfermeriaModel> resultados = datos
                        .Where(d =>
                            d.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            d.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            (d.Paciente.Nombre + " " + d.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            d.Medico.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            d.Medico.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            (d.Medico.Nombre + " " + d.Medico.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    DataTable dataTable = ConvertidorListDatatable.ConvertirAtenciones(resultados);

                    _viewLista.CargarDatosPaciente(dataTable);
                }
            }
        }
  } 
