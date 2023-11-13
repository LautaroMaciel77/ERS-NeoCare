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
using System.Windows.Forms.DataVisualization.Charting;

namespace ERS_NeoCare.Design.administrativo
{

    public partial class Reporte : UserControl
    {
        private PacientePresenter _presenter;
        private TurnoPresenter _presenterturno;
        private UsuarioPresenter _presenterusuario;
        private List<Turno> turnos;
        private List<UsuarioModel> usuarios;

        private AnalisisPresenter _analisis;
        private OrdenPresenter _ordenPresenter;
        private List<AnalisisModel> listaAnalisis;

        private List<OrdenModel> listaOrden;
        public Reporte()
        {
            InitializeComponent();
            iniciarDatos();
        }

        private void iniciarDatos()
        {
            _presenter = new PacientePresenter(new PacienteService(Configuracion.ConnectionString));
            _presenterturno = new TurnoPresenter(new TurnoService(Configuracion.ConnectionString));
            _presenterusuario = new UsuarioPresenter(new UsuarioService(Configuracion.ConnectionString));
            _analisis = new AnalisisPresenter(new AnalisisService());
            _ordenPresenter = new OrdenPresenter(new OrdenService());
            comboBoxFiltro.Items.AddRange(new object[] { "1 mes", "2 meses", "3 meses", "1 año","Todo" });
            comboBoxFiltro.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            comboBox1.Items.AddRange(new object[] { "Analisis","Atencion" });
            comboBox1.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            turnos = _presenterturno.RecopilarTurnos();
            usuarios = _presenterusuario.ListaUsuarios();
            listaAnalisis = _analisis.listaAnalisis();
            listaOrden = _ordenPresenter.traerListaOrdenes();
            chartTurnos.Visible = false;

            panel1.Visible = false;
        
            ConfigurarGraficoBarras();
        }
        private void ConfigurarGraficoBarras()
        {
            chartTurnos.Series.Clear();
            chartTurnos.Series.Add("Turnos Atendidos");
            chartTurnos.Series["Turnos Atendidos"].ChartType = SeriesChartType.Column;
            chartTurnos.Series["Turnos Atendidos"].XValueType = ChartValueType.String;
            chartTurnos.Series["Turnos Atendidos"].IsValueShownAsLabel = true;
            chartTurnos.ChartAreas[0].AxisY.Minimum = 0;

            chartTurnos.ChartAreas[0].AxisY.Interval = 1;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // Obtener datos desde tu fuente de datos (por ejemplo, una lista de pacientes)
            List<PacienteModel> pacientes = _presenter.ObtenerListaPaciente();

            // Filtrar pacientes por género
            var data = pacientes.GroupBy(p => p.Sexo)
                                .Select(g => new { Genero = g.Key, Cantidad = g.Count() });

            // Configurar el gráfico
            chart1.Series.Clear();
            chart1.Series.Add("Cantidad de Pacientes por Género");

            foreach (var item in data)
            {
                chart1.Series["Cantidad de Pacientes por Género"].Points.AddXY(item.Genero, item.Cantidad);
            }

            // Configurar el tipo de gráfico (puedes ajustarlo según tus necesidades)
            chart1.Series["Cantidad de Pacientes por Género"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }
        private void CargarUsuariosEnComboBox()
        {


            // Verifica si comboBox1 está seleccionado
            if (comboBox1.SelectedItem != null)
            {
                // Obtiene el valor seleccionado
                string filtro = comboBox1.SelectedItem.ToString();

                // Filtra la lista de usuarios según el valor seleccionado
                if (filtro == "Analisis")
                {
                    usuarios = usuarios.Where(u => u.ProfesionID == 4).ToList();
                }
                else
                {
                    usuarios = usuarios.Where(u => u.ProfesionID == 2).ToList();
                }

                // Configura el ComboBox
                comboBoxUsuarios.DisplayMember = "Nombre"; // Propiedad del modelo que se mostrará en el ComboBox
                comboBoxUsuarios.ValueMember = "id"; // Propiedad del modelo que se utilizará como valor seleccionado
                comboBoxUsuarios.DataSource = usuarios;

                // Deselecciona comboBox1
                comboBox1.SelectedItem = null;
            }
            else
            {
                // Si comboBox1 no está seleccionado, filtra por ProfesionID == 3
                usuarios = usuarios.Where(u => u.ProfesionID == 3).ToList();

                // Configura el ComboBox
                comboBoxUsuarios.DisplayMember = "Nombre"; // Propiedad del modelo que se mostrará en el ComboBox
                comboBoxUsuarios.ValueMember = "id"; // Propiedad del modelo que se utilizará como valor seleccionado
                comboBoxUsuarios.DataSource = usuarios;
            }
        }
        private void buttonGenerarGrafico_Click_1(object sender, EventArgs e)
        {
            chartTurnos.Visible = true;

            string filtro = comboBoxFiltro.SelectedItem.ToString();

            // Llama al método para generar el gráfico
            GenerarGrafico(
                turnos,
                filtro,
                chartTurnos,
                "Turnos Atendidos",
                "Turnos No Atendidos"
            );
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            comboBox1.SelectedItem = null;
            CargarUsuariosEnComboBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chartTurnos.Visible = true;

            string filtro = comboBoxFiltro.SelectedItem.ToString();

            // Llama al método para generar el gráfico
            GenerarGrafico(
                turnos,
                filtro,
                chartTurnos,
                "Pacientes Atendidos",
                "Pacientes No Atendidos",
                t => comboBoxUsuarios.SelectedIndex != -1 && t.Medico.id == ((UsuarioModel)comboBoxUsuarios.SelectedItem).id
            );
        }
        private bool CumpleFiltroDeTiempo(DateTime fechaTurno, string filtro)
        {
            DateTime fechaLimite;

            // Calcula la fecha límite según el filtro seleccionado
            switch (filtro)
            {
                case "1 mes":
                    fechaLimite = DateTime.Now.AddMonths(-1);
                    break;
                case "2 meses":
                    fechaLimite = DateTime.Now.AddMonths(-2);
                    break;
                case "3 meses":
                    fechaLimite = DateTime.Now.AddMonths(-3);
                    break;
                case "1 año":
                    fechaLimite = DateTime.Now.AddYears(-1);
                    break;
                case "Todo": // Nuevo caso para no aplicar filtro de tiempo
                    return true;
                default:
                    // Si el filtro no coincide con ninguno de los casos anteriores, retorna false
                    return false;
            }

            // Compara la fecha del turno con la fecha límite
            return fechaTurno >= fechaLimite;
        }

        private void GenerarGrafico(List<Turno> turnos, string filtro, Chart chart, string serieAtendidos, string serieNoAtendidos, Func<Turno, bool> filtroAdicional = null)
        {
            // Filtra los turnos según el filtro de tiempo
            var turnosFiltrados = turnos.Where(t => CumpleFiltroDeTiempo(t.SelectedDate, filtro)).ToList();

            // Aplica un filtro adicional si se proporciona
            if (filtroAdicional != null)
            {
                turnosFiltrados = turnosFiltrados.Where(filtroAdicional).ToList();
            }

            // Configura el gráfico
            chart.Series.Clear();
            chart.Series.Add(serieAtendidos);
            chart.Series.Add(serieNoAtendidos);

            chart.Series[serieAtendidos].ChartType = SeriesChartType.Column;
            chart.Series[serieNoAtendidos].ChartType = SeriesChartType.Column;

            // Agrega los datos al gráfico
            Dictionary<string, int> datosGraficoAtendidos = new Dictionary<string, int>();
            Dictionary<string, int> datosGraficoNoAtendidos = new Dictionary<string, int>();

            foreach (var turno in turnosFiltrados)
            {
                string periodo = comboBoxFiltro.SelectedItem.ToString();
                int cantidadPacientes = 1; // Puedes ajustar esto según tus necesidades

                if (turno.Estado == "s")
                {
                    if (datosGraficoAtendidos.ContainsKey(periodo))
                    {
                        datosGraficoAtendidos[periodo] += cantidadPacientes;
                    }
                    else
                    {
                        datosGraficoAtendidos.Add(periodo, cantidadPacientes);
                    }
                }
                else
                {
                    if (datosGraficoNoAtendidos.ContainsKey(periodo))
                    {
                        datosGraficoNoAtendidos[periodo] += cantidadPacientes;
                    }
                    else
                    {
                        datosGraficoNoAtendidos.Add(periodo, cantidadPacientes);
                    }
                }
            }

            // Agrega los puntos al gráfico para los pacientes atendidos
            foreach (var kvp in datosGraficoAtendidos)
            {
                chart.Series[serieAtendidos].Points.AddXY(kvp.Key, kvp.Value);
            }

            // Agrega los puntos al gráfico para los pacientes no atendidos
            foreach (var kvp in datosGraficoNoAtendidos)
            {
                chart.Series[serieNoAtendidos].Points.AddXY(kvp.Key, kvp.Value);
            }
        }
        private void GenerarGraficoOrdenes(List<OrdenModel> ordenes, string filtro, string fecha, Chart chart, string serieAtendido, string serieNoAtendido)
        {
            // Filtra las órdenes según el tipo y el filtro de tiempo

            var ordenesFiltradas = ordenes.Where(o => o.TipoOrden == filtro );
            ordenesFiltradas = ordenesFiltradas.Where(t => CumpleFiltroDeTiempo(t.FechaCreacion, fecha)).ToList();
            // Configura el gráfico
            chart.Series.Clear();
            chart.Series.Add(serieAtendido);
            chart.Series.Add(serieNoAtendido);

            chart.Series[serieAtendido].ChartType = SeriesChartType.Column;
            chart.Series[serieNoAtendido].ChartType = SeriesChartType.Column;

            // Agrega los datos al gráfico
            Dictionary<string, int> datosGraficoAtendido = new Dictionary<string, int>();
            Dictionary<string, int> datosGraficoNoAtendido = new Dictionary<string, int>();

            foreach (var orden in ordenesFiltradas)
            {
                string periodo = orden.FechaCreacion.ToString("MM/yyyy");
                int cantidadOrdenes = 1; // Puedes ajustar esto según tus necesidades

                if (orden.Estado)
                {
                    if (datosGraficoAtendido.ContainsKey(periodo))
                    {
                        datosGraficoAtendido[periodo] += cantidadOrdenes;
                    }
                    else
                    {
                        datosGraficoAtendido.Add(periodo, cantidadOrdenes);
                    }
                }
                else
                {
                    if (datosGraficoNoAtendido.ContainsKey(periodo))
                    {
                        datosGraficoNoAtendido[periodo] += cantidadOrdenes;
                    }
                    else
                    {
                        datosGraficoNoAtendido.Add(periodo, cantidadOrdenes);
                    }
                }
            }

            // Agrega los puntos al gráfico para las órdenes atendidas
            foreach (var kvp in datosGraficoAtendido)
            {
                chart.Series[serieAtendido].Points.AddXY(kvp.Key, kvp.Value);
            }

            // Agrega los puntos al gráfico para las órdenes no atendidas
            foreach (var kvp in datosGraficoNoAtendido)
            {
                chart.Series[serieNoAtendido].Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            chartTurnos.Visible = true;
         

            //   string tipoOrden = comboBoxTipoOrden.SelectedItem.ToString();
            string fecha = comboBoxFiltro.SelectedItem.ToString();
            string filtro = comboBox1.SelectedItem.ToString();

            // Llama al método para generar el gráfico de órdenes
            GenerarGraficoOrdenes(
                listaOrden,
                filtro,
                fecha,
                chartTurnos,
                "Órdenes Atendidas",
                "Órdenes No Atendidas"
            );
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            CargarUsuariosEnComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
