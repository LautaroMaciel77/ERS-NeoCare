﻿using ERS_NeoCare.Design;
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
                dataTable.Columns.Add("Estado", typeof(Image)); // Cambiar tipo de columna a Image
                dataTable.Columns.Add("MedicoId", typeof(int));
                dataTable.Columns.Add("PacienteId", typeof(int));
                dataTable.Columns.Add("NombrePaciente", typeof(string));


            foreach (var turno in turnos)
                {


                Image estadoImage = (turno.Estado == "s") ? Properties.Resources.check_box_FILL : Properties.Resources.check_box_blank;

                    dataTable.Rows.Add(
                        turno.Id,
                        turno.SelectedDate,
                        turno.SelectedTimeRange,
                        turno.Prioridad,
                        estadoImage, // Almacenar la imagen en lugar de "s" o "n"
                        turno.Medico_Id,
                        turno.Paciente_Id,
                        turno.Paciente.Nombre
        
                    );
                }

                return dataTable;
            }
        
  

        internal static DataTable ConvertirOrdenes(List<OrdenModel> ordenes)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));

           
          
            dataTable.Columns.Add("fecha_creacion", typeof(DateTime)); // Usar el nombre de columna mapeado
            dataTable.Columns.Add("Medico", typeof(string)); // Mantener el nombre en mayúsculas
            dataTable.Columns.Add("Paciente", typeof(string)); // Mantener el nombre en mayúsculas
            dataTable.Columns.Add("dni_paciente", typeof(int)); // Usar el nombre de columna mapeado
            dataTable.Columns.Add("dni_medico", typeof(int)); // Usar el nombre de columna mapeado

            dataTable.Columns.Add("urgencia", typeof(bool)); // Usar el nombre de columna mapeado
            dataTable.Columns.Add("estado", typeof(bool)); // Usar el nombre de columna mapeado
            foreach (var orden in ordenes)
            {
                // Crear una nueva fila en el DataTable
                DataRow row = dataTable.NewRow();

                // Asignar valores de las propiedades a las columnas correspondientes
                row["Id"] = orden.Id;
               
                row["fecha_creacion"] = orden.FechaCreacion; // Usar el nombre de propiedad mapeada
                row["Medico"] = orden.Medico.Nombre + " " + orden.Medico.Apellido; // Usar el nombre de propiedad mapeada
                row["Paciente"] = orden.Paciente.Nombre + " " + orden.Paciente.Apellido;
                row["dni_paciente"] = orden.Paciente.Dni; // Usar el nombre de propiedad mapeada
                row["dni_medico"] = orden.Medico.DNI; // Usar el nombre de propiedad mapeada
                row["urgencia"] = orden.Urgencia; // Usar el nombre de propiedad mapeada
                row["estado"] = orden.Estado; // Usar el nombre de propiedad mapeada4
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
            dataTable.Columns.Add("Paciente", typeof(string)); // Mantener el nombre en mayúsculas
            dataTable.Columns.Add("dni_paciente", typeof(int)); // Usar el nombre de columna mapeado
            dataTable.Columns.Add("dni_medico", typeof(int)); // Usar el nombre de columna mapeado


            foreach (var orden in atenciones)
            {
                // Crear una nueva fila en el DataTable
                DataRow row = dataTable.NewRow();

                // Asignar valores de las propiedades a las columnas correspondientes
                row["Id"] = orden.IdAtencion;
             
               
         
                row["fecha"] = orden.Fecha; // Usar el nombre de propiedad mapeada     
                row["Medico"] = orden.Medico.Nombre + " " + orden.Medico.Apellido; // Usar el nombre de propiedad mapeada
                row["Paciente"] = orden.Paciente.Nombre + " " + orden.Paciente.Apellido;
                row["dni_paciente"] = orden.Paciente.Dni; // Usar el nombre de propiedad mapeada
                row["dni_medico"] = orden.Medico.DNI; // Usar el nombre de propiedad mapeada
             
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
            dataTable.Columns.Add("Paciente", typeof(string)); // Mantener el nombre en mayúsculas
            dataTable.Columns.Add("dni_paciente", typeof(int)); // Usar el nombre de columna mapeado
            dataTable.Columns.Add("dni_medico", typeof(int)); // Usar el nombre de columna mapeado


            foreach (var orden in analisis)
            {
                // Crear una nueva fila en el DataTable
                DataRow row = dataTable.NewRow();

                // Asignar valores de las propiedades a las columnas correspondientes
                row["Id"] = orden.IdAnalisis;



                row["fecha"] = orden.Fecha; // Usar el nombre de propiedad mapeada     
                row["Medico"] = orden.Usuario.Nombre + " " + orden.Usuario.Apellido; // Usar el nombre de propiedad mapeada
                row["Paciente"] = orden.Orden.Paciente.Nombre + " " + orden.Orden.Paciente.Apellido;
                row["dni_paciente"] = orden.Orden.Paciente.Dni; // Usar el nombre de propiedad mapeada
                row["dni_medico"] = orden.Orden.Medico.DNI; // Usar el nombre de propiedad mapeada

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
