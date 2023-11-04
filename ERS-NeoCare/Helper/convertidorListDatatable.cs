using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Helper
{
    public static class ConvertidorListDatatable
    {
        public static DataTable ConvertirListaUsuario(List<UsuarioModel> usuariosConBaja)
        {
            DataTable dataTable = new DataTable();
            if (usuariosConBaja != null)
            {
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("Matricula", typeof(int));
                dataTable.Columns.Add("DNI", typeof(int));
                dataTable.Columns.Add("Nombre", typeof(string));
                dataTable.Columns.Add("Apellido", typeof(string));
                dataTable.Columns.Add("ProfesionID", typeof(int));

                foreach (var usuario in usuariosConBaja)
                {
                    dataTable.Rows.Add(usuario.id, usuario.Matricula, usuario.DNI, usuario.Nombre, usuario.Apellido, usuario.ProfesionID);
                }
            }
            return dataTable;
        }

        public static DataTable ConvertirListaPaciente(List<PacienteModel> resultados)
        {
            DataTable dataTable = new DataTable();
            // Definir las columnas en el DataTable
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("dni", typeof(int));
            dataTable.Columns.Add("nombre", typeof(string));
            dataTable.Columns.Add("apellido", typeof(string));
            dataTable.Columns.Add("domicilio", typeof(string));
            dataTable.Columns.Add("fecha_nacimiento", typeof(DateTime));
            dataTable.Columns.Add("sexo", typeof(string));
            dataTable.Columns.Add("obra_social", typeof(string));
     
            dataTable.Columns.Add("baja", typeof(string));
            dataTable.Columns.Add("condicion", typeof(string));

            // Agregar filas al DataTable
            foreach (var paciente in resultados)
            {
                dataTable.Rows.Add(paciente.Id, paciente.Dni, paciente.Nombre, paciente.Apellido, paciente.Domicilio, paciente.FechaNacimiento, paciente.Sexo, paciente.ObraSocial, paciente.Baja, paciente.Condicion);
            }
            return dataTable;
        }
        public static DataTable ConvertirListaTurno(List<Turno> turnos)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("SelectedDate", typeof(DateTime));
            dataTable.Columns.Add("SelectedTimeRange", typeof(TimeSpan));
            dataTable.Columns.Add("Prioridad", typeof(string));
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("MedicoId", typeof(int));
            dataTable.Columns.Add("PacienteId", typeof(int));

            foreach (var turno in turnos)
            {
                dataTable.Rows.Add(
                    turno.Id,
                    turno.SelectedDate,
                    turno.SelectedTimeRange,
                    turno.Prioridad,
                    turno.Estado,
                    turno.Medico_Id,
                    turno.Paciente_Id
                );
            }

            return dataTable;
        }
    }
}
