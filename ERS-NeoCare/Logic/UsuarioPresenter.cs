using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Llama al método de inserción del modelo y devuelve el resultado
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
            DataTable data = convertirListaUsuario(_model.ObtenerDatosUsuarios("n"));
            return data;
        }
        public void ObtenerUsuariosBusqueda(string searchText)
        {
          
        
            List<UsuarioModel> datos = _model.ObtenerDatosUsuarios("n");

            // Realiza la búsqueda en la lista.
            List<UsuarioModel> resultados = datos.Where(d =>
             d.Nombre.Contains(searchText) || d.Apellido.Contains(searchText) ||
             (d.Nombre + " " + d.Apellido).Contains(searchText)).ToList();
            DataTable dataTable = convertirListaUsuario(resultados);

            _viewBuqueda.cargarLista(dataTable);
        }

        public void ObtenerUsuarios(string valorBaja)
        {

            DataTable data = convertirListaUsuario(_model.ObtenerDatosUsuarios(valorBaja));
            _viewLista.MostrarDatosPaciente(data);
        }
        public void ObtenerUsuarioBaja(string valorBaja)
        {

            DataTable data = convertirListaUsuario(_model.ObtenerDatosUsuarios(valorBaja));
            _viewBaja.MostrarDatos(data);
        }
        public bool cambiarBaja()
        {

           return _model.CambiarEstadoBajaUsuario();
        }
        public DataTable convertirListaUsuario(List<UsuarioModel> usuariosConBaja)
        {
            DataTable dataTable = new DataTable();
            if (usuariosConBaja != null)
            {
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("Matricula", typeof(int));
                dataTable.Columns.Add("DNI", typeof(int));
                dataTable.Columns.Add("Nombre", typeof(string));
                dataTable.Columns.Add("Apellido", typeof(string));
                dataTable.Columns.Add("ProfesionID", typeof(int));

                foreach (var usuario in usuariosConBaja)
                {
                    dataTable.Rows.Add(usuario.id, usuario.Matricula, usuario.DNI, usuario.Nombre, usuario.Apellido, usuario.ProfesionID);
                }
                
            }
            return dataTable;

        }
    }
}
