using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class editar_usuario : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
   
        private UsuarioPresenter _presenter;
        public event EventHandler actualizarTabla;

        public editar_usuario( )
        {
       
            InitializeComponent();
            cargarCampos();
            _presenter = new UsuarioPresenter(new UsuarioService(Configuracion.ConnectionString));
            ComboxProfesion.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> profesionesList = new List<string> { "administrativo", "enfermero", "medico", "bioquimico", "admin" };
            ComboxProfesion.DataSource = profesionesList;
            var profesionID = UsuarioBusqueda.Instance.UsuarioAutenticado.ProfesionID;

            
            if (profesionID >= 1 && profesionID <= profesionesList.Count)
            {
                ComboxProfesion.SelectedIndex = profesionID - 1;
            }
        }

        private void cargarCampos()
        {
            textNombre.Text = UsuarioBusqueda.Instance.UsuarioAutenticado.Nombre;
            textApellido.Text = UsuarioBusqueda.Instance.UsuarioAutenticado.Apellido;
            textMatricula.Text = UsuarioBusqueda.Instance.UsuarioAutenticado.Matricula.ToString();
            textDni.Text = UsuarioBusqueda.Instance.UsuarioAutenticado.DNI.ToString();

        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            UserControlClosed?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
              textNombre.Clear();
           textApellido.Clear();
            textMatricula.Clear();
           textDni.Clear();
            ComboxProfesion.SelectedIndex = 0;
            textContraseña.Clear();


        }

            private void textObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            UserControlClosed?.Invoke(this, EventArgs.Empty);
        }

  

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar=='0') || (e.KeyChar == '1') || (e.KeyChar == '2') || (e.KeyChar == '3') || (e.KeyChar == '4')))
            {
                e.Handled = true;

            }
     
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void radioPass_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPass.Checked)
            {
                textContraseña.Enabled = true; 
            }
            else
            {
                textContraseña.Enabled = false; 
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textApellido.Text)
            || string.IsNullOrWhiteSpace(textDni.Text) 
            || string.IsNullOrWhiteSpace(textMatricula.Text) 
            )
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si textDni contiene solo números y tiene un máximo de 8 caracteres
            if (!int.TryParse(textDni.Text, out int dni) || textDni.Text.Length > 8)
            {
                MessageBox.Show("El campo DNI debe contener solo números y tener un máximo de 8 caracteres.", "Formato de DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            if (textMatricula.Text.Length > 12)
            {
                MessageBox.Show("El campo matricula  debe contener solo números .", "Formato  incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UsuarioModel user = new UsuarioModel();
            if (radioPass.Checked)
            {

                user.Password = textContraseña.Text;
            }
            user.Nombre = textNombre.Text;
            user.Apellido = textApellido.Text;
            user.Matricula = int.Parse(textMatricula.Text);
            user.DNI = int.Parse(textDni.Text);
            bool editarUser = _presenter.EditarUsuario(user);
            if (editarUser)
            {
                MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Hubo un problema al editado el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerProfesionID(string tipoUsuario)
        {
            switch (tipoUsuario.ToLower())
            {
                case "administrativo":
                    return 1;

                case "enfermero":
                    return 2;

                case "medico":
                    return 3;

                case "bioquimico":
                    return 4;

                case "admin":
                    return 5;

                default:
                    // Manejar un caso por defecto o mostrar un mensaje de error, según sea necesario
                    return 1; // Otra opción podría ser lanzar una excepción
            }
        }

    }
}
