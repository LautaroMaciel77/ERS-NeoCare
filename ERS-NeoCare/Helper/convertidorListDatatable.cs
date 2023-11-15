using ERS_NeoCare.Design;
using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare.Helper
{
    public static class ConvertidorListDatatable
    {
                //SI VAS A CAMBIAR EL DISEÑO QUE COINCIDAN CON ESTO SI ROMPISTE VOLVE A LA VERSION QUE FUNCIONABA NO SUBAS DESACOMODADO o ROTO MANDA UN MENSAJE CON LO Q QUERES
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
                dataTable.Columns.Add("Estado", typeof(bool)); // Cambiar tipo de columna a Image
                dataTable.Columns.Add("MedicoId", typeof(int));
                dataTable.Columns.Add("PacienteId", typeof(int));
                dataTable.Columns.Add("NombrePaciente", typeof(string));
                dataTable.Columns.Add("NombreMedico", typeof(string));


            foreach (var turno in turnos)
                {


          
                    dataTable.Rows.Add(
                        turno.Id,
                        turno.SelectedDate,
                        turno.SelectedTimeRange,
                        turno.Prioridad,
                        turno.Estado, // Almacenar la imagen en lugar de "s" o "n"
                        turno.Medico_Id,
                        turno.Paciente_Id,
                        turno.Paciente.Nombre+" "+turno.Paciente.Apellido,
                        turno.Medico.Nombre + " " + turno.Medico.Apellido

                    );
                }

                return dataTable;
            }
        public static DataTable ConvertirListaTurnoMedico(List<Turno> turnos)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));

            dataTable.Columns.Add("SelectedTimeRange", typeof(TimeSpan));
            dataTable.Columns.Add("SelectedDate", typeof(DateTime));
     
            dataTable.Columns.Add("PacienteDni", typeof(int));
            dataTable.Columns.Add("NombrePaciente", typeof(string));
            dataTable.Columns.Add("Prioridad", typeof(string));
            dataTable.Columns.Add("Estado", typeof(bool));  // Cambiar tipo de columna a Image
       
        



            foreach (var turno in turnos)
            {

             
                dataTable.Rows.Add(
                    turno.Id,
            
                    turno.SelectedTimeRange,
                    turno.SelectedDate,
        
                    turno.Paciente.Dni,
                  turno.Paciente.Nombre + " " + turno.Paciente.Apellido,
                    turno.Prioridad,
                    turno.Estado // Almacenar la imagen en lugar de "s" o "n"
             
             

                );
            }

            return dataTable;
        }


        internal static DataTable ConvertirOrdenes(List<OrdenModel> ordenes)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));

           
          
            dataTable.Columns.Add("fecha_creacion", typeof(DateTime)); 
            dataTable.Columns.Add("Medico", typeof(string)); 
            dataTable.Columns.Add("Paciente", typeof(string)); 
            dataTable.Columns.Add("dni_paciente", typeof(int)); 
            dataTable.Columns.Add("dni_medico", typeof(int));
            dataTable.Columns.Add("urgencia", typeof(bool)); 
            dataTable.Columns.Add("estado", typeof(bool)); 
            foreach (var orden in ordenes)
            {
              
                DataRow row = dataTable.NewRow();

              
                row["Id"] = orden.Id;
               
                row["fecha_creacion"] = orden.FechaCreacion; // Usar el nombre de propiedad mapeada
                row["Medico"] = orden.Medico.Nombre + " " + orden.Medico.Apellido; 
                row["Paciente"] = orden.Paciente.Nombre + " " + orden.Paciente.Apellido;
                row["dni_paciente"] = orden.Paciente.Dni; 
                row["dni_medico"] = orden.Medico.DNI; 
                row["urgencia"] = orden.Urgencia; 
                row["estado"] = orden.Estado;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        internal static DataTable ConvertirAtenciones(List<AtencionEnfermeriaModel> atenciones)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("fecha", typeof(string));

            dataTable.Columns.Add("Medico", typeof(string)); // Mantener el nombre en mayúsculas
            dataTable.Columns.Add("dni_medico", typeof(int));
            dataTable.Columns.Add("Paciente", typeof(string)); 
            dataTable.Columns.Add("dni_paciente", typeof(int)); 
    
            dataTable.Columns.Add("usuario", typeof(string));
          

            foreach (var orden in atenciones)
            {
            
                DataRow row = dataTable.NewRow();

           
                row["Id"] = orden.IdAtencion;
             
               
         
                row["fecha"] = orden.Fecha; // Usar el nombre de propiedad mapeada     
                row["Medico"] = orden.Orden.Medico.Nombre + " " + orden.Orden.Medico.Apellido; 
                row["Paciente"] = orden.Paciente.Nombre + " " + orden.Paciente.Apellido;
                row["dni_paciente"] = orden.Paciente.Dni; 
                row["dni_medico"] = orden.Orden.Medico.DNI;
                row["usuario"] = orden.Usuario.Nombre + " " + orden.Usuario.Apellido;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        internal static DataTable ConvertirAnalisis(List<AnalisisModel> analisis)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("fecha", typeof(string));

            dataTable.Columns.Add("Medico", typeof(string)); // Mantener el nombre en mayúsculas
            dataTable.Columns.Add("Paciente", typeof(string)); 
            dataTable.Columns.Add("dni_paciente", typeof(int));
            dataTable.Columns.Add("dni_medico", typeof(int)); 


            foreach (var orden in analisis)
            {
                // Crear una nueva fila en el DataTable
                DataRow row = dataTable.NewRow();

               
                row["Id"] = orden.IdAnalisis;



                row["fecha"] = orden.Fecha; // Usar el nombre de propiedad mapeada     
                row["Medico"] = orden.Usuario.Nombre + " " + orden.Usuario.Apellido; 
                row["Paciente"] = orden.Orden.Paciente.Nombre + " " + orden.Orden.Paciente.Apellido;
                row["dni_paciente"] = orden.Orden.Paciente.Dni; 
                row["dni_medico"] = orden.Orden.Medico.DNI;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public static DataTable ConvertirListaHistorial(List<HistorialModel> historiales)
        {
            DataTable dataTable = new DataTable();
            if (historiales != null)
            {
                dataTable.Columns.Add("id_historial", typeof(int));
                dataTable.Columns.Add("Tipo", typeof(string));

                dataTable.Columns.Add("fecha", typeof(DateTime));
                dataTable.Columns.Add("id_atencion", typeof(int));
                dataTable.Columns.Add("id_paciente", typeof(int));
                dataTable.Columns.Add("id_medico", typeof(int));
                dataTable.Columns.Add("id_evaluacion", typeof(int));
                dataTable.Columns.Add("id_analisis", typeof(int));

                foreach (var historial in historiales)
                {
                    dataTable.Rows.Add(
                        historial.IdHistorial,
                        historial.Tipo,
             
                        historial.fecha,
                        historial.IdAtencion,
                        historial.IdPaciente,
                        historial.IdMedico,
                        historial.IdEvaluacion,
                        historial.IdAnalisis 
                    );
                }
            }
            return dataTable;
        }
        public static DataTable ConvertirListaEvaluacion(List<EvaluacionModel> evaluaciones)
        {
            DataTable dataTable = new DataTable();
            if (evaluaciones != null)
            {
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("fecha_creacion", typeof(DateTime));
                dataTable.Columns.Add("Medico", typeof(string)); 
                dataTable.Columns.Add("Paciente", typeof(string));
                dataTable.Columns.Add("dni_paciente", typeof(int));
                dataTable.Columns.Add("dni_medico", typeof(int));
                foreach (var evaluacion in evaluaciones)
                {
                    dataTable.Rows.Add(
                        evaluacion.IdEvaluacion,
                        evaluacion.FechaCreacion,
                        evaluacion.Medico.Nombre + " " + evaluacion.Medico.Apellido,
                        evaluacion.Paciente.Nombre+" "+evaluacion.Paciente.Apellido,
          
                        evaluacion.Paciente.Dni,
         
                        evaluacion.Medico.DNI
                    );
                }
            }
            return dataTable;
        }
    }

}
