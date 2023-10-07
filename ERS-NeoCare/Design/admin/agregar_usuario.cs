using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Net;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class agregar_usuario : UserControl
    {
        public event EventHandler UserControlClosed;
        private lista_paciente MainForm { get; set; }
   
        private AgregarUsuarioPresenter _presenter;
        public event EventHandler actualizarTabla;
        public agregar_usuario()
        {
            InitializeComponent();
            _presenter = new AgregarUsuarioPresenter(new UsuarioService(Configuracion.ConnectionString));
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

            // Verificar que los text no están vacíos
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textApellido.Text)
                || string.IsNullOrWhiteSpace(textDni.Text) || string.IsNullOrWhiteSpace(textBoxProfesion.Text)
                || string.IsNullOrWhiteSpace(textMatricula.Text) || string.IsNullOrWhiteSpace(textContraseña.Text)
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
            if (!int.TryParse(textBoxProfesion.Text, out int profesion) || textDni.Text.Length > 8)
            {
                MessageBox.Show("El campo profesion debe contener solo números y tener un máximo de 8 caracteres.", "Formato de profesion incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textMatricula.Text.Length > 12)
            {
                MessageBox.Show("El campo obra  debe contener solo números .", "Formato  incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
           UsuarioModel usuario = new UsuarioModel()
            {
               Nombre = textNombre.Text,
               Apellido = textApellido.Text,
               Matricula=int.Parse(textMatricula.Text),
               DNI= int.Parse(textDni.Text),
               ProfesionID = int.Parse(textBoxProfesion.Text),
               Password = textContraseña.Text,

                
            };
            bool insercionExitosa = _presenter.IngresarUsuario(usuario);
            if (insercionExitosa)
            {
                MessageBox.Show("Usuario insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Hubo un problema al insertar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizarTabla?.Invoke(this, EventArgs.Empty);


        }
        private void LimpiarCampos()
        {
              textNombre.Clear();
           textApellido.Clear();
            textMatricula.Clear();
           textDni.Clear();
            textBoxProfesion.Clear();
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
            if (textBoxProfesion.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void textBoxProfesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelProfesion_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelDni_Click(object sender, EventArgs e)
        {

        }

        private void labelMatricula_Click(object sender, EventArgs e)
        {

        }

        private void textMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
