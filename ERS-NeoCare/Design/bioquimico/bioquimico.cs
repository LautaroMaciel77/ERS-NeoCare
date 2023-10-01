using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class Bioquimico : UserControl
    {
        private menu MainForm { get; set; }

        // Declara un evento personalizado para notificar clics en los botones
        public event EventHandler ListaAnalisisButtonClick;
        public event EventHandler ListaPacienteButtonClick;

        public Bioquimico()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ListaPacienteButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ListaAnalisisButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

