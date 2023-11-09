using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class AnalisisService
    {
        internal bool Insertar(AnalisisModel analisis)
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Agregar el análisis al contexto
                context.analisis.Add(analisis);

                // Guardar los cambios en la base de datos
                int rowsAffected = context.SaveChanges();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return false; // O manejar de otra manera apropiada
            }
        }
        internal List<AnalisisModel> ObtenerAnalisis()
        {
            try
            {
                var context = DbContextManager.GetContext();

                // Consultar la tabla de análisis y traer todos los registros
                List<AnalisisModel> analisis = context.analisis.ToList();

                foreach (var analisisItem in analisis)
                {
                    context.Entry(analisisItem).Reference(a => a.Orden).Load();
                    context.Entry(analisisItem).Reference(a => a.Usuario).Load();
                    context.Entry(analisisItem).Reference(a => a.ArchivoEstudio).Load();
                }

                return analisis;
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return null; // O manejar de otra manera apropiada, como lanzar una excepción
            }
        }
    }
}
