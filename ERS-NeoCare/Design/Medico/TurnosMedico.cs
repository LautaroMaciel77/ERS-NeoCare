
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERS_NeoCare.Design
{
    public partial class TurnosMedico : UserControl
    {
        private DateTime select;
        private string dni;
        private string rangoHora;
  
        public TurnosMedico(object value)
        {
            InitializeComponent();
           
            
        }

        public TurnosMedico()
        {
        }


        private void iconAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxIndicaciones.Text))
            {
                MessageBox.Show("El campo indicaciones no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
          
           

        }

        private void textboxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void radioBio_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioEnfermero_CheckedChanged(object sender, EventArgs e)
        {
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TurnosMedico_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelTipoOrden_Click(object sender, EventArgs e)
        {

        }
    }
}
