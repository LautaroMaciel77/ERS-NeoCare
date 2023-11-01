using ERS_NeoCare.Helper;
using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using ERS_NeoCare.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Design.administrativo
{
    public partial class buscarPaciente : UserControl
    {
        private UsuarioPresenter _presenterUsuario;
        private PacientePresenter _presenterPaciente;
        public event EventHandler CloseClick;
        public string tipoModelo;
        public buscarPaciente()
        {
            InitializeComponent();
            _presenterUsuario = new UsuarioPresenter(this, new UsuarioService(Configuracion.ConnectionString));
            _presenterPaciente = new PacientePresenter(new PacienteService(Configuracion.ConnectionString));
            panel1.Visible = false;
            labelMedicoResultado.Text = string.Empty;
            labelPacienteResultado.Text = string.Empty;
        }

        private void IniciarDatagriew(DataTable data)
        {
            DGVABusqueda.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBoxBusqueda.Text;
            if(tipoModelo == "m") {
                _presenterUsuario.ObtenerUsuariosBusqueda(searchText);
            }
            else
            {

            }
           

            // Actualiza el DataGridView con los resultados.
          
        }
        public void cargarLista(DataTable resultados)
        {
            DGVABusqueda.DataSource = resultados;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(this, EventArgs.Empty);
        }

        private void DGVABusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVABusqueda.Rows.Count > 0)
            {
                if (DGVABusqueda.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {

                    DataGridViewRow row = DGVABusqueda.Rows[e.RowIndex];
                    string dni = row.Cells["dni"].Value.ToString();
                    if(tipoModelo == "m")
                    {
                        labelMedicoResultado.Text = string.Empty;
              
                        _presenterUsuario.Buscar(dni);
                        labelMedicoResultado.Text += UsuarioSingleton.Instance.UsuarioAutenticado.Nombre + "  " + UsuarioSingleton.Instance.UsuarioAutenticado.Apellido;
                      
                    }
                    else
                    {
                        labelPacienteResultado.Text = string.Empty;
                        _presenterPaciente.cargarPaciente(dni);
                        labelPacienteResultado.Text += PacienteSingleton.Instance.pacienteAutenticado.Nombre + "  " + PacienteSingleton.Instance.pacienteAutenticado.Apellido;
                  
                    }
                   
                    panel1.Visible = false;
                 
                }
            }
        }

   

        private void iconbtn_paciente_Click(object sender, EventArgs e)
        {
            IniciarDatagriew(_presenterPaciente.CargarDatosPacienteGeneral());
            panel1.Visible = true;
            tipoModelo = "p";
            

        }

        private void iconbtn_medico_Click(object sender, EventArgs e)
        {
            IniciarDatagriew(_presenterUsuario.ObtenerUsuariosGeneral());
            panel1.Visible = true;
            tipoModelo = "m";
    
        }

        private void btn_closePanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
