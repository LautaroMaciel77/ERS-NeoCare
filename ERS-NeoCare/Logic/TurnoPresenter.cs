using ERS_NeoCare.Design;
using ERS_NeoCare.Design.administrativo;
using ERS_NeoCare.Helper;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Logic
{
    internal class TurnoPresenter
    {

        public TurnoService _service;
        private PacientesMedico _viewMedico;
        public turnoAdministrativo _viewAdministrativo;
        public ListaTurnosAdministrativo _viewlista;

        public ListaDeTurnos _viewlistaTurnos;

        public TurnoPresenter(turnoAdministrativo view, TurnoService service)
        {
            _service = service;
            _viewAdministrativo = view;
        }
        public TurnoPresenter(PacientesMedico view, TurnoService service)
        {
            _service = service;
            _viewMedico = view;
        }

        public TurnoPresenter(ListaTurnosAdministrativo view, TurnoService service)
        {
            _service = service;
            _viewlista = view;
        }
        public TurnoPresenter(ListaDeTurnos view, TurnoService service)
        {
            _service = service;
            _viewlistaTurnos = view;
        }
        public TurnoPresenter(TurnoService service)
        {
            _service = service;

        }



        public void insertarTurno(Turno turnoModel)
        {
            _viewAdministrativo.Insertar(_service.Insertar(turnoModel));


        }
        public void BuscarYAuntenticar(int id)
        {

            _service.AutenticarTurnoPorId(id);

        }
        public void CargarPacientePorTurno()
        {
            List<Turno> listaTurnos = _service.ObtenerDatos();
            List<PacienteModel> listaPacientes = listaTurnos.Select(t => t.Paciente).ToList();
            DataTable data = ConvertidorListDatatable.ConvertirListaPaciente(listaPacientes);
            _viewMedico.MostrarDatosPaciente(data);
        }
        public void CargarPacienteMedico()
        {
            List<Turno> listaTurnos = _service.ObtenerDatos();
           
            List<Turno> turnosMedico = listaTurnos.Where(t => (t.Medico_Id == UsuarioSingleton.Instance.UsuarioAutenticado.id) &&( t.Estado=false)).ToList();
         
            DataTable data = ConvertidorListDatatable.ConvertirListaTurnoMedico(turnosMedico);
            _viewMedico.MostrarDatosPaciente(data);
        }
        public void CargarPacienteAtendidos()
        {
            List<Turno> listaTurnos = _service.ObtenerDatos();

            List<Turno> turnosMedico = listaTurnos.Where(t => (t.Medico_Id == UsuarioSingleton.Instance.UsuarioAutenticado.id) && (t.Estado = true)).ToList();

            DataTable data = ConvertidorListDatatable.ConvertirListaTurnoMedico(turnosMedico);
            _viewMedico.MostrarDatosPaciente(data);
        }
        public void BuscarPacienteAtendido(string searchText)
        {
            List<Turno> listGeneral = _service.ObtenerDatos().Where(t => t.Medico_Id == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();

            List<Turno> listfiltrada;
            if (int.TryParse(searchText, out int dni))
            {
                string dniStr = dni.ToString();
                listfiltrada = listGeneral
                    .Where(p => p.Paciente.Dni.ToString().Contains(dniStr))
                    .ToList();
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                listfiltrada = listGeneral.Where(p =>
                    p.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Paciente.Nombre + " " + p.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }


            DataTable data = ConvertidorListDatatable.ConvertirListaTurnoMedico(listfiltrada);
            _viewlistaTurnos.MostrarDatosPaciente(data);
        }

        public void BuscarPacienteMedico(string searchText)
        {
            List<Turno> listGeneral = _service.ObtenerDatos().Where(t => t.Medico_Id == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();

            List<Turno> listfiltrada;
            if (int.TryParse(searchText, out int dni))
            {
                string dniStr = dni.ToString();
                listfiltrada = listGeneral
                    .Where(p => p.Paciente.Dni.ToString().Contains(dniStr))
                    .ToList();
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                listfiltrada = listGeneral.Where(p =>
                    p.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Paciente.Nombre + " " + p.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }


            DataTable data = ConvertidorListDatatable.ConvertirListaTurnoMedico(listfiltrada);
            _viewMedico.MostrarDatosPaciente(data);
        }

        public void BuscarTurnoListaTurnoAdm(string searchText)
        {

            List<Turno> listGeneral = _service.ObtenerDatos();

            List<Turno> listfiltrada;
            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI
                string dniStr = dni.ToString();
                listfiltrada = listGeneral
                    .Where(p => p.Paciente.Dni.ToString().Contains(dniStr))
                    .ToList();
            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo
                listfiltrada = listGeneral.Where(p =>
                    p.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (p.Paciente.Nombre + " " + p.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }


            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(listfiltrada);
            _viewlista.cargarDatos(data);

        }
        public List<Turno> BuscarTurno(string searchText)
        {
            List<Turno> listGeneral = _service.ObtenerDatos();

            if (int.TryParse(searchText, out int dni))
            {
                // Realiza la búsqueda por DNI en turnos
                listGeneral.Where(t => t.Paciente.Dni == dni).ToList();

            }
            else
            {
                // Realiza la búsqueda por nombre, apellido o nombre completo en turnos
                listGeneral.Where(t =>
                   t.Paciente.Nombre.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   t.Paciente.Apellido.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   (t.Paciente.Nombre + " " + t.Paciente.Apellido).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            }
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(listGeneral);
            return listGeneral;
        }
        internal bool TurnoAtendido(int id)
        {
            var context = DbContextManager.GetContext();

            // Verificar si existe un turno con la ID y está atendido
            var turnoAtendido = context.turnos.Any(t => t.Id == id && t.Estado == true);

            return turnoAtendido;
        }

        public List<Turno> RecopilarTurnos()
        {
            return _service.ObtenerDatos();
        }
        public void ListaTurnos()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            _viewlista.cargarDatos(data);
        }
  

        public DataTable ListaTurnosGeneral()
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerDatos());
            return data;
        }

        internal void ObtenerTurnoEstado(bool v)
        {
            DataTable data = ConvertidorListDatatable.ConvertirListaTurno(_service.ObtenerTurnoEstado(v));
            _viewlista.cargarDatos(data);
        }

        internal void cambiarEstado(int id)
        {
            _service.CambiarEstado(id);
            _viewMedico.mensaje("estado cambiado");
        }
        internal void CargarFiltro(bool v)
        {

            List<Turno> turnos = _service.ObtenerTurnoEstado(v).Where(t => t.Medico_Id == UsuarioSingleton.Instance.UsuarioAutenticado.id).ToList();
            
            DataTable data = ConvertidorListDatatable.ConvertirListaTurnoMedico(turnos);

            _viewMedico.MostrarDatosPaciente(data);
        }

    }
}
