using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Windows.Forms;
namespace ERS_NeoCare.Design.Medico
{
    public partial class MenuAdminUsuarios : UserControl
    {
        private menu MainForm { get; set; }
        private string userDni;
        private PacienteService paciente;
        public event EventHandler closeclick;
        public event EventHandler bajaclick;
        public event EventHandler editarclick;
        public MenuAdminUsuarios( )
        {
            ;

            InitializeComponent();
        }

  

   
        private void iconVer_Click(object sender, EventArgs e)
        {
            bajaclick?.Invoke(this, EventArgs.Empty);

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            closeclick?.Invoke(this, EventArgs.Empty);
        }

        private void iconTurno_Click(object sender, EventArgs e)
        {
            editarclick?.Invoke(this, EventArgs.Empty);
        }

        private void MenuAdminUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
