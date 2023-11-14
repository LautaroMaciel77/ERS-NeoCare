using ERS_NeoCare.Design.administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ERS_NeoCare.Model
{
    internal class AtencionService
    {


        internal AtencionService( )
        {
           
        }

        internal void buscar(string id)
        {
         

                int.TryParse(id, out int idInt);
                var context = DbContextManager.GetContext();

                var orden = context.atencion.FirstOrDefault(u => u.IdAtencion == idInt);

                if (orden != null)
                {

                    AtencionSingleton.Instance.Autenticar(orden);
                }
            

        }

        internal bool Insertar(AtencionEnfermeriaModel atencion)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Agregar la orden al contexto
                context.atencion.Add(atencion);

                // Guardar los cambios en la base de datos
                int rowsAffected = context.SaveChanges();
                AtencionSingleton.Instance.Autenticar(atencion);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O maneja de otra manera apropiada
            }
        }

        internal List<AtencionEnfermeriaModel> ObtenerAtenciones()
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Consultar la tabla de análisis y traer todos los registros
                List<AtencionEnfermeriaModel> Atenciones = context.atencion.ToList();
                foreach (var atencion in Atenciones)
                {
                    context.Entry(atencion).Reference(a => a.Medico).Load();
                    context.Entry(atencion).Reference(a => a.Paciente).Load();
                    context.Entry(atencion).Reference(a => a.Orden).Load();

                }
                return Atenciones;
            }
            catch (Exception ex)
            {
                // Maneja excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return null; // O maneja de otra manera apropiada, como lanzar una excepción
            }
        }
    }
}
