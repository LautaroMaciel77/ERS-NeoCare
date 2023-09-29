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
    public partial class Bioquimico : UserControl
    {
        private menu MainForm { get; set; }

        // Declara un evento personalizado para notificar clics en los botones
        public event EventHandler OpcionesButtonClick;
        public event EventHandler TurnoAdminButtonClick;

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
            OpcionesButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TurnoAdminButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

