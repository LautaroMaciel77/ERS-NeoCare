using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class Enfermero : UserControl
    {
        private menu MainForm { get; set; }

        // Declara un evento personalizado para notificar clics en los botones
        public event EventHandler enfermeroPacientesButtonClick;
        public event EventHandler enfermeroAtencionButtonClick;

        public Enfermero()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            enfermeroPacientesButtonClick?.Invoke(this, EventArgs.Empty);
        } 

        private void iconButton1_Click(object sender, EventArgs e)
        {
            enfermeroAtencionButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

