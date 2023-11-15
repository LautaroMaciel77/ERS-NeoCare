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
        private bool TurnoFlag;
        private DateTime fechaInicio;
        private DateTime fechaFin;
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
           
            comboBox1.Items.AddRange(new object[] { "Analisis","Atencion" });
            comboBox1.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            turnos = _presenterturno.RecopilarTurnos();
            usuarios = _presenterusuario.ListaUsuarios();
            listaAnalisis = _analisis.listaAnalisis();
            listaOrden = _ordenPresenter.traerListaOrdenes();
            chartTurnos.Visible = true;

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
                // Agregar el punto al gráfico
                var point = chart1.Series["Cantidad de Pacientes por Género"].Points.Add(item.Cantidad);

                // Mostrar la cantidad en la etiqueta de la porción
                point.Label = $"{item.Genero}: {item.Cantidad}";
            }

            // Configurar el tipo de gráfico (puedes ajustarlo según tus necesidades)
            chart1.Series["Cantidad de Pacientes por Género"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Configurar propiedad para mostrar las etiquetas
            chart1.Series["Cantidad de Pacientes por Género"]["PieLabelStyle"] = "Inside";
            chart1.Series["Cantidad de Pacientes por Género"].IsValueShownAsLabel = true;
        }

        private void buttonGenerarGrafico_Click_1(object sender, EventArgs e)
        {
            chartTurnos.Visible = true;

            string filtro = "";

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
            comboBox1.SelectedIndex = 0;
            TurnoFlag = false;
            CargarUsuariosEnComboBox();

        }
        private void CargarUsuariosEnComboBox()
        {
            List<UsuarioModel> usuariosFiltrados;
            // Concatena nombre y apellido en una nueva propiedad llamada "NombreCompleto"



            // Verifica si comboBox1 está seleccionado
            if (TurnoFlag)
            {
                // Obtiene el valor seleccionado
                string filtro = comboBox1.SelectedItem.ToString();

                // Filtra la lista de usuarios según el valor seleccionado
                if (filtro == "Analisis")
                {
                    usuariosFiltrados = usuarios.Where(u => u.ProfesionID == 4).ToList();
                }
                else
                {
                    usuariosFiltrados = usuarios.Where(u => u.ProfesionID == 2).ToList();
                }

                // Configura el ComboBox
         
                // Deselecciona comboBox1
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                // Si comboBox1 no está seleccionado, filtra por ProfesionID == 3
                usuariosFiltrados = usuarios.Where(u => u.ProfesionID == 3).ToList();

            }
  



            comboBoxUsuarios.DisplayMember = "NombreApellido"; // Propiedad del modelo que se mostrará en el ComboBox
            comboBoxUsuarios.ValueMember = "id"; // Propiedad del modelo que se utilizará como valor seleccionado
            comboBoxUsuarios.DataSource = usuariosFiltrados;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chartTurnos.Visible = true;

            string filtro = "";

            // Llama al método para generar el gráfico
            GenerarGrafico(
                turnos,
                filtro,
                chartTurnos,
                "Pacientes Atendidos",
                "Pacientes No Atendidos",
                t => comboBoxUsuarios.SelectedIndex != -1 && t.Medico.id == ((UsuarioModel)comboBoxUsuarios.SelectedItem).id
            );
            panel1.Visible = false;
        }
        private bool CumpleFiltroDeTiempo(DateTime fechaCreacion)
        {
            // Implementa la lógica de filtro de tiempo utilizando fechaInicio y fechaFin
            return fechaCreacion >= fechaInicio && fechaCreacion <= fechaFin;
        }


        private void GenerarGrafico(List<Turno> turnos, string filtro, Chart chart, string serieAtendidos, string serieNoAtendidos, Func<Turno, bool> filtroAdicional = null)
        {
            // Filtra los turnos según el filtro de tiempo
            var turnosFiltrados = turnos.Where(t => CumpleFiltroDeTiempo(t.SelectedDate)).ToList();

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

            int maximoEjeY = turnosFiltrados.Count + 1;
            chart.ChartAreas[0].AxisY.Maximum = maximoEjeY;

            // Agrega los datos al gráfico
            Dictionary<string, int> datosGraficoAtendidos = new Dictionary<string, int>();
            Dictionary<string, int> datosGraficoNoAtendidos = new Dictionary<string, int>();

            foreach (var turno in turnosFiltrados)
            {
                // Utiliza la fecha del turno para el periodo
                string periodo = turno.SelectedDate.ToString("MM/yyyy");

                int cantidadPacientes = 1; // Puedes ajustar esto según tus necesidades

                if (turno.Estado == true)
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
            var ordenesFiltradas = ordenes.Where(o => o.TipoOrden == filtro);
            ordenesFiltradas = ordenesFiltradas.Where(t => CumpleFiltroDeTiempo(t.FechaCreacion)).ToList();

            // Configura el gráfico
            chart.Series.Clear();
            chart.Series.Add(serieAtendido);
            chart.Series.Add(serieNoAtendido);

            chart.Series[serieAtendido].ChartType = SeriesChartType.Column;
            chart.Series[serieNoAtendido].ChartType = SeriesChartType.Column;

            int maximoEjeY = ordenesFiltradas.Count() + 1;
            chart.ChartAreas[0].AxisY.Maximum = maximoEjeY;

            // Agrega los datos al gráfico
            Dictionary<string, int> datosGraficoAtendido = new Dictionary<string, int>();
            Dictionary<string, int> datosGraficoNoAtendido = new Dictionary<string, int>();

            foreach (var orden in ordenesFiltradas)
            {
                // Utiliza la fecha de la orden para el periodo
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
            string fecha = "";
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
            TurnoFlag = true;
            CargarUsuariosEnComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

            fechaInicio = dateTimePickerInicio.Value;
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            fechaFin = dateTimePickerFin.Value;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
    }

