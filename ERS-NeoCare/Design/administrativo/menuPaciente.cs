using ERS_NeoCare.Model;
using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class menuPaciente : UserControl
    {
        public event EventHandler closeclick;
        public event EventHandler verclick;
        public menuPaciente()
        {
            InitializeComponent();
        }

   
        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            closeclick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            verclick?.Invoke(this, EventArgs.Empty);
        }
    }
}
