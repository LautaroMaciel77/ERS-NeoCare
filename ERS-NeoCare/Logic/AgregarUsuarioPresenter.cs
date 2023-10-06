using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class AgregarUsuarioPresenter
    {
        private agregar_usuario _view;
        private UsuarioService _model;

        public AgregarUsuarioPresenter(UsuarioService model)
        {

            _model = model;
        }

        public bool IngresarUsuario(UsuarioModel usuario)
        {
            // Llama al método de inserción del modelo y devuelve el resultado
            return _model.InsertarUsuario(usuario);
        }
    }
}
