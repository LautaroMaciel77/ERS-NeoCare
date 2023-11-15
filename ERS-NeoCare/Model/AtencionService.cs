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

                var atencionEncontrado = context.atencion.FirstOrDefault(u => u.IdAtencion == idInt);
            context.Entry(atencionEncontrado).Reference(a => a.Medico).Load();
            context.Entry(atencionEncontrado).Reference(a => a.Paciente).Load();
            context.Entry(atencionEncontrado).Reference(a => a.Orden).Load();
            context.Entry(atencionEncontrado).Reference(a => a.Usuario).Load();
            if (atencionEncontrado != null)
                {

                    AtencionSingleton.Instance.Autenticar(atencionEncontrado);
                }
            

        }

        internal bool BuscaryAutenticarIdOrden(int id)
        {
          try
                {
                    var context = DbContextManager.GetContext();


                    AtencionEnfermeriaModel atencionEncontrado = context.atencion
                        .FirstOrDefault(a => a.Orden != null && a.Orden.Id == id);
                context.Entry(atencionEncontrado).Reference(a => a.Medico).Load();
                context.Entry(atencionEncontrado).Reference(a => a.Paciente).Load();
                context.Entry(atencionEncontrado).Reference(a => a.Orden).Load();
                context.Entry(atencionEncontrado).Reference(a => a.Usuario).Load();

                if (atencionEncontrado != null)
                    {
                        AtencionSingleton.Instance.Autenticar(atencionEncontrado);
                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    // Manejar excepciones generales aquí.
                    Console.WriteLine("Error general: " + ex.Message);
                    return false;
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
                    context.Entry(atencion).Reference(a => a.Usuario).Load();

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
