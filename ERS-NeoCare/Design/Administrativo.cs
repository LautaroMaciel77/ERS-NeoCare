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
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();
            RellenarGrid();
        }

        private void RellenarGrid()
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes.Add(new Paciente("40323123", "Santiago", "Juarez", new DateTime(1999, 10, 5), "ambulatorio"));
            pacientes.Add(new Paciente("42645655", "Melisa", "Toledo", new DateTime(2010, 6, 3), "internado"));
            pacientes.Add(new Paciente("46008867", "Santiago", "Ledesma", new DateTime(2018, 1, 12), "ambulatorio"));
            pacientes.Add(new Paciente("44334534", "Bianca", "Miguel", new DateTime(2018, 4, 16), "internado"));
            pacientes.Add(new Paciente("46555343", "Silvia", "Chavez", new DateTime(2030, 6, 13), "internado"));
            pacientes.Add(new Paciente("47546790", "Jose", "Noriega", new DateTime(2000, 11, 6), "ambulatorio"));

            foreach (Paciente p in pacientes) {
                int rowIndex = DGVAdministrativo.Rows.Add();
                DataGridViewRow row = DGVAdministrativo.Rows[rowIndex];
                row.Cells[1].Value = p.DNI;
                row.Cells[2].Value = p.Nombre;
                row.Cells[3].Value = p.Apellido;
                row.Cells[4].Value = p.FechaNacimiento.ToString("MM/dd/yyyy"); 
                row.Cells[5].Value = p.Condicion;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administrativo_Load(object sender, EventArgs e)
        {

        }
    }
}
