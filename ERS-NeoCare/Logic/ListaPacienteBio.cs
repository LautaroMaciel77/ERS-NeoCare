﻿using ERS_NeoCare.Design;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ERS_NeoCare.Logic
{
    internal class listaPacienteBio
    {
        private lista_paciente_bioquimico _view;
        private OrdenService _model;

        public listaPacienteBio(lista_paciente_bioquimico view, OrdenService OrdenService)
        {
            _view = view;
            _model = OrdenService;

        }
        public void CargarDatosPaciente()
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();

            List<OrdenModel> ordenesEnf = ordenes.Where(o => o.TipoOrden == "Analisis" && o.Estado != true).ToList();
            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenesEnf);
            _view.MostrarDatosPaciente(data);
        }

        internal void Buscar(int idOrden)
        {
            _model.Buscar(idOrden);
        }

        internal void buscarTexto(string searchText)
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();
            List<OrdenModel> datos = ordenes.Where(o => o.TipoOrden == "Analisis" && o.Estado != true).ToList();
            if (int.TryParse(searchText, out int dni))
            {
                List<OrdenModel> resultadosPorDNI = datos
             .Where(d => d.Paciente.Dni.ToString().StartsWith(searchText) || d.Medico.DNI.ToString().StartsWith(searchText))
             .ToList();
                DataTable dataTablePorDNI = ConvertidorListDatatable.ConvertirOrdenes(resultadosPorDNI);

                _view.MostrarDatosPaciente(dataTablePorDNI);
            }
            else
            {
                // Realiza por nombre del paciente, nombre del médico o nombre completo sin distinción 
                List<OrdenModel> resultados = datos
                    .Where(d =>
                        d.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        d.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        (d.Paciente.Nombre + " " + d.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        d.Medico.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        d.Medico.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        (d.Medico.Nombre + " " + d.Medico.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                DataTable dataTable = ConvertidorListDatatable.ConvertirOrdenes(resultados);

                _view.MostrarDatosPaciente(dataTable);
            }
        }

        internal void FiltroUrgencia(bool v)
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();
            List<OrdenModel> datos = ordenes.Where(o => o.TipoOrden == "Atencion" && o.Estado != true && o.Urgencia == v).ToList();

            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(datos);

            _view.MostrarDatosPaciente(data);
        }
    }
}
