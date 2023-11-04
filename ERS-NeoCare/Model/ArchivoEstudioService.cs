using ERS_NeoCare.dbconexion;
using ERS_NeoCare.Design.Paciente;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class ArchivoEstudioService
    {
        private string _connectionString;

        public ArchivoEstudioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void buscar(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var archivos = context.archivosEstudios.Where(a => a.IdHistoriaClinica == id).ToList();

                if (archivos != null)
                {
                    ArchivoEstudiosSingleton.Instance.AutenticarArchivos(archivos);


                }

            }
        }
        internal bool insertar(ArchivoEstudio archivo)
        {
            using (var context = new ApplicationDbContext())
            {
                bool actualizacionArchivosExitosa = false;

                try
                {
                    if (archivo != null)
                    {
                        archivo.IdHistoriaClinica = HistoriaClinicaSingleton.Instance.historiaAutenticado.Id;
                        archivo.fecha_creacion = DateTime.Now;
                        context.archivosEstudios.Add(archivo);
                        context.SaveChanges();
                        actualizacionArchivosExitosa = true;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción, registrarla o realizar cualquier otra acción necesaria.
                    // Por ejemplo, puedes agregar un registro de errores aquí.
                }

                return actualizacionArchivosExitosa;
            }
        }

        internal bool borrar(List<ArchivoEstudio> archivosAEliminar)
        {
            if (archivosAEliminar != null && archivosAEliminar.Any())
            {
                try
                {
                    var context = DbContextManager.GetContext();

                    foreach (var archivoAEliminar in archivosAEliminar)
                    {
                        // Verifica si el archivo existe en el contexto antes de intentar eliminarlo
                        var archivoExistente = context.archivosEstudios.Find(archivoAEliminar.Id);
                        if (archivoExistente != null)
                        {
                            context.archivosEstudios.Remove(archivoExistente);
                        }
                    }

                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir durante la eliminación
                    Console.WriteLine("Error al eliminar archivos: " + ex.Message);
                    return false; // Indica que hubo un error durante la eliminación
                }
            }

            return false;
        }
    }
}
