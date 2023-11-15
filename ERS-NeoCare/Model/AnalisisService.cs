using ERS_NeoCare.Design.administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ERS_NeoCare.Model
{
    internal class AnalisisService
    {
        //insertar un  analisisModel a la bd
        internal bool Insertar(AnalisisModel analisis)
        {
            try
            {
                var context = DbContextManager.GetContext();


                context.analisis.Add(analisis);

                int rowsAffected = context.SaveChanges();
                AnalisisSingleton.Instance.AutenticarAnalisis(analisis);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error general: " + ex.Message);
                return false;
            }
        }
        //traer una lista de analisisModel de la bd
        internal List<AnalisisModel> ObtenerAnalisis()
        {
            try
            {
                var context = DbContextManager.GetContext();

              
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
                return null; 
            }
        }
        //remplazar el singleton de analisis si encuentra una con el mismo id analisis
        internal AnalisisModel ObtenerYAutenticarPorId(int id)
        {
            try
            {
                var context = DbContextManager.GetContext();

               
                AnalisisModel analisisEncontrado = context.analisis.Find(id);

                context.Entry(analisisEncontrado).Reference(a => a.Orden).Load();
                context.Entry(analisisEncontrado).Reference(a => a.Usuario).Load();
                context.Entry(analisisEncontrado).Reference(a => a.ArchivoEstudio).Load();

                if (analisisEncontrado != null)
                {
                    AnalisisSingleton.Instance.AutenticarAnalisis(analisisEncontrado);
                }

                return analisisEncontrado;
            }
            catch (Exception ex)
            {
                // Manejar excepciones generales aquí.
                Console.WriteLine("Error general: " + ex.Message);
                return null; 
            }
        }
        //remplazar el singleton de analisis si encuentra una con el mismo id orden
        internal bool ObtenerYAutenticarPorIdOrden(int idOrden)
        {
            try
            {
                var context = DbContextManager.GetContext();

               
                AnalisisModel analisisEncontrado = context.analisis
                    .FirstOrDefault(a => a.Orden != null && a.Orden.Id == idOrden);
                context.Entry(analisisEncontrado).Reference(a => a.Orden).Load();
                context.Entry(analisisEncontrado).Reference(a => a.Usuario).Load();
                context.Entry(analisisEncontrado).Reference(a => a.ArchivoEstudio).Load();

                if (analisisEncontrado != null)
                {
                    AnalisisSingleton.Instance.AutenticarAnalisis(analisisEncontrado);
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
    }
}
