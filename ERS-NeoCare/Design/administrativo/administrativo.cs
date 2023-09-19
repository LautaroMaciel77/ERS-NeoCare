using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class administrativo : UserControl
    {
        private menu MainForm { get; set; }

        // Declara un evento personalizado para notificar clics en los botones
        public event EventHandler OpcionesButtonClick;

        public administrativo()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Realiza las acciones necesarias cuando se hace clic en un botón
            // Puedes modificar el panelOpciones aquí
            OpcionesButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // Realiza las acciones necesarias cuando se hace clic en otro botón
            // Puedes modificar el panelOpciones aquí
            OpcionesButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

