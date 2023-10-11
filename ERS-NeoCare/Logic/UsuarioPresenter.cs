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
        private UsuarioService _model;

        public UsuarioPresenter(UsuarioService model)
        {

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
        
            return _model.CambiarEstadoBajaUsuario(usuario.Matricula);
        }
        public UsuarioModel Buscar(string dni)
        {
            return _model.BuscarUsuario(dni);
        }
        public void ObtenerUsuario(string valorBaja)
        {

            DataTable data = _model.ObtenerDatosUsuario(valorBaja);
            _viewLista.MostrarDatosPaciente(data);
        }
        public bool cambiarBaja(UsuarioModel usuario)
        {
           return _model.CambiarEstadoBajaUsuario(usuario.Matricula);
        }
    }
}
