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

namespace ERS_NeoCare.Logic
{

    internal class AnalisisPresenter
    {
        private analisis _view;
        private lista_analisis_bioquimico _viewLista;
        private AnalisisService _service;
        public AnalisisPresenter(analisis view, AnalisisService service)
        {
            _view = view;
            _service = service;
        }
        public AnalisisPresenter(lista_analisis_bioquimico view, AnalisisService service)
        {
            _viewLista = view;
            _service = service;
        }

        public void Insertar(AnalisisModel analisis)
        {
            _service.Insertar(analisis);

        }

        public void TraerAnalisis()
        {
            List<AnalisisModel> analisis =_service.ObtenerAnalisis();
            DataTable data = ConvertidorListDatatable.ConvertirAnalisis(analisis);
            _viewLista.MostrarDatosPaciente(data);
        }
        internal void buscarTexto(string searchText)
        {
            List<AnalisisModel> analisis = _service.ObtenerAnalisis();
            List<AnalisisModel> datos = analisis.Where(o => o.IdUsuario == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();
            if (int.TryParse(searchText, out int dni))
            {
                // Realiza  por DNI del paciente
                List<AnalisisModel> resultadosPorDNI = datos
                    .Where(d => d.Orden.Paciente.Dni == dni || d.Orden.Medico.DNI == dni)
                    .ToList();
                DataTable dataTablePorDNI = ConvertidorListDatatable.ConvertirAnalisis(resultadosPorDNI);

                _viewLista.MostrarDatosPaciente(dataTablePorDNI);
            }
            else
            {
                // Realiza por nombre del paciente, nombre del médico o nombre completo sin distinción 
                List<AnalisisModel> resultados = datos
                    .Where(d =>
                        d.Orden.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        d.Orden.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        (d.Orden.Paciente.Nombre + " " + d.Orden.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        d.Orden.Medico.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        d.Orden.Medico.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        (d.Orden.Medico.Nombre + " " + d.Orden.Medico.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                DataTable dataTable = ConvertidorListDatatable.ConvertirAnalisis(resultados);

                _viewLista.MostrarDatosPaciente(dataTable);
            }
        }
    }
}
