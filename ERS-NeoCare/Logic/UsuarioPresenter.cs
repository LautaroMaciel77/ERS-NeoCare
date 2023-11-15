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
using System.Windows.Markup;

namespace ERS_NeoCare.Logic
{
    internal class UsuarioPresenter
    {
        private agregar_usuario _view;
        private lista_usuarios _viewLista;
        private lista_baja_usuarios _viewBaja;
        private buscarPaciente _viewBuqueda;
        private UsuarioService _model;

        public UsuarioPresenter(UsuarioService model)
        {
            _model = model;
        }
        public UsuarioPresenter(buscarPaciente view, UsuarioService model)
        {
            _viewBuqueda = view;
            _model = model;
        }
        public UsuarioPresenter(lista_usuarios view, UsuarioService model)
        {
            _viewLista = view;
            _model = model;
        }
        public UsuarioPresenter(lista_baja_usuarios view, UsuarioService model)
        {
            _viewBaja = view;
            _model = model;
        }

        public bool IngresarUsuario(UsuarioModel usuario)
        {
           
            return _model.InsertarUsuario(usuario);
        }
        

        public bool EditarUsuario(UsuarioModel usuario)
        {
        
            return _model.EditarUsuario(usuario);
        }
        public void Buscar(string dni)
        {
          _model.BuscarUsuario(dni);

        }
        //funcion para obtener los usuarios sin cargar un view
        public DataTable ObtenerUsuariosGeneral()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaUsuario(_model.ObtenerDatosUsuarios("n"));
            //aca falta filtrar solo medico
            return data;
        }
        public List<UsuarioModel> ListaUsuarios()
        {
          return _model.ObtenerTodosLosUsuarios();

        }
        public void ObtenerMedicosBusqueda(string searchText)
        {


            List<UsuarioModel> datos = _model.ObtenerDatosUsuarios("n");
            List<UsuarioModel> medicosFiltrados = datos.Where(u => u.ProfesionID == 3).ToList();

            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI
                List<UsuarioModel> resultadosPorDNI = medicosFiltrados.Where(d => d.DNI == dni).ToList();
                DataTable dataTablePorDNI = ConvertidorListDatatable.ConvertirListaUsuario(resultadosPorDNI);

                _viewBuqueda.cargarLista(dataTablePorDNI);
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                List<UsuarioModel> resultados = medicosFiltrados.Where(d =>
                    d.Nombre.Contains(searchText) || d.Apellido.Contains(searchText) ||
                    (d.Nombre + " " + d.Apellido).Contains(searchText)).ToList();
                DataTable dataTable = ConvertidorListDatatable.ConvertirListaUsuario(resultados);

                _viewBuqueda.cargarLista(dataTable);
            }
        }
        public DataTable ObtenerUsuariosBusquedaGeneral(string searchText)
        {


            List<UsuarioModel> datos = _model.ObtenerDatosUsuarios("n");


            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI
                List<UsuarioModel> resultadosPorDNI = datos.Where(d => d.DNI.ToString().StartsWith(searchText)).ToList();
                DataTable dataTable = ConvertidorListDatatable.ConvertirListaUsuario(resultadosPorDNI);
     
                return dataTable;
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                List<UsuarioModel> resultados = datos.Where(d =>
            d.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
            d.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
            (d.Nombre + " " + d.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();
                DataTable dataTable =ConvertidorListDatatable.ConvertirListaUsuario(resultados);

                return dataTable;
            }
        }

        public void ObtenerUsuarios(string valorBaja)
        {

            DataTable data = ConvertidorListDatatable.ConvertirListaUsuario((_model.ObtenerDatosUsuarios(valorBaja)));
            _viewLista.MostrarDatosPaciente(data);
        }
        public void ObtenerUsuarioBaja(string valorBaja)
        {

            DataTable data = ConvertidorListDatatable.ConvertirListaUsuario(_model.ObtenerDatosUsuarios(valorBaja));
            _viewBaja.MostrarDatos(data);
        }
        public bool cambiarBaja()
        {

           return _model.CambiarEstadoBajaUsuario();
        }
     

        internal DataTable ObtenerUsuariosMedicos()
        {
            List<UsuarioModel> medicos = _model.ObtenerDatosUsuarios("n");
             List<UsuarioModel> medicosFiltrados = medicos.Where(u => u.ProfesionID == 3).ToList();

            // Convertir la lista filtrada a DataTable
            DataTable data = ConvertidorListDatatable.ConvertirListaUsuario(medicosFiltrados);

            return data;
        }
    }
}
