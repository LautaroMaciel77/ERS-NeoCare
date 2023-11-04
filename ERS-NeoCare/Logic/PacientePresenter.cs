using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Logic
{
    internal class PacientePresenter
    {
        private lista_paciente _view;
        private buscarPaciente _viewBuqueda;
        private Presenter.PacienteService _service;

        public PacientePresenter(lista_paciente view, Presenter.PacienteService pacienteService)
        {
            _view = view;
            _service = pacienteService;
        }

        public PacientePresenter(PacienteService pacienteService)
        {

            _service = pacienteService;
        }
        public PacientePresenter(buscarPaciente view, PacienteService pacienteService)
        {
            _viewBuqueda = view;
            _service = pacienteService;
        }

        public void buscarGeneral()
        {


        }

        public bool IngresarPaciente(PacienteModel paciente)
        {
            return _service.InsertarPaciente(paciente);
        }

        public void CargarDatosPaciente()
        {

            DataTable data = convertirListaPaciente(_service.ObtenerDatosPaciente());
            _view.MostrarDatosPaciente(data);
        }
        //funcion general sin estar asociado a una vista
        public DataTable CargarDatosPacienteGeneral()
        {

            DataTable data = convertirListaPaciente( _service.ObtenerDatosPaciente());
            return data;
        }

        internal void cargarPaciente(string dni)
        {
            _service.BuscarPaciente(dni);
        }
        public void ObtenerPacienteBusqueda(string searchText)
        {


            List<PacienteModel> datos = _service.ObtenerDatosPaciente();

            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI
                List<PacienteModel> resultadosPorDNI = datos.Where(d => d.Dni == dni).ToList();
                DataTable dataTablePorDNI = convertirListaPaciente(resultadosPorDNI);

                _viewBuqueda.cargarLista(dataTablePorDNI);
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                List<PacienteModel> resultados = datos.Where(d =>
                     d.Nombre.Contains(searchText) || d.Apellido.Contains(searchText) ||
                     (d.Nombre + " " + d.Apellido).Contains(searchText)).ToList();
                DataTable dataTable = convertirListaPaciente(resultados);

                _viewBuqueda.cargarLista(dataTable);
            }
        }
     

        public DataTable convertirListaPaciente(List<PacienteModel> resultados)
        {
            DataTable dataTable = new DataTable();
            // Definir las columnas en el DataTable
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("dni", typeof(int));
            dataTable.Columns.Add("nombre", typeof(string));
            dataTable.Columns.Add("apellido", typeof(string));
            dataTable.Columns.Add("domicilio", typeof(string));
            dataTable.Columns.Add("fecha_nacimiento", typeof(DateTime));
            dataTable.Columns.Add("sexo", typeof(string));
            dataTable.Columns.Add("obra_social", typeof(string));
        
            dataTable.Columns.Add("baja", typeof(string));
            dataTable.Columns.Add("condicion", typeof(string));

            // Agregar filas al DataTable
            foreach (var paciente in resultados)
            {
                dataTable.Rows.Add(paciente.Id, paciente.Dni, paciente.Nombre, paciente.Apellido, paciente.Domicilio, paciente.FechaNacimiento, paciente.Sexo, paciente.ObraSocial, paciente.Baja, paciente.Condicion);
            }
            return dataTable;
        }
    }
}
