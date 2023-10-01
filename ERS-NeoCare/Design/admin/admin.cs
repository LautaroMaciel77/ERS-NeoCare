using System;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class admin : UserControl
    {
        private menu MainForm { get; set; }

        // Declara un evento personalizado para notificar clics en los botones
        public event EventHandler adminUsuariosButtonClick;
        public event EventHandler BajasAdminButtonClick;

        public admin()
        {
            InitializeComponent();
        }

        public void SetMainForm(menu mainForm)
        {
            MainForm = mainForm;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            adminUsuariosButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            BajasAdminButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

