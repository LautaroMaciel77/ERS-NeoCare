﻿using ERS_NeoCare.Design;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class ListaPacienteEnf
    {
        private lista_paciente_enfermero _view;
        private OrdenService _model;

        public ListaPacienteEnf(lista_paciente_enfermero view, OrdenService pacienteService)
        {
            _view = view;
            _model = pacienteService;

        }


        public void CargarDatosPaciente()
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();
       
            List<OrdenModel> ordenesEnf = ordenes.Where(o => o.TipoOrden == "Atencion").ToList();
            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenesEnf);
            _view.MostrarDatosPaciente(data);
    }
        public void BuscarOrden()
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();

            List<OrdenModel> ordenesEnf = ordenes.Where(o => o.TipoOrden == "Atencion").ToList();
            DataTable data = ConvertidorListDatatable.ConvertirOrdenes(ordenesEnf);
            _view.MostrarDatosPaciente(data);
        }

        internal void Buscar(string idOrden)
        {
            _model.Buscar(idOrden);
        }

        internal void buscarTexto(string searchText)
        {
            List<OrdenModel> ordenes = _model.traerOrdenes();
            List<OrdenModel> datos = ordenes.Where(o => o.TipoOrden == "Atencion").ToList();
            if (int.TryParse(searchText, out int dni))
            {
                // Realiza  por DNI del paciente
                List<OrdenModel> resultadosPorDNI = datos
                    .Where(d => d.Paciente.Dni == dni || d.Medico.DNI == dni)
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
    }
}


