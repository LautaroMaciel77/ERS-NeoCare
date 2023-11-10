using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    internal class HistoriaClinicaService
    {
        private string connectionString;
        private List<ArchivoEstudio> archivosInformacion = new List<ArchivoEstudio>();
        public HistoriaClinicaService(string connectionString)
        {
            this.connectionString = connectionString;
        }
        internal bool insertar(HistoriaClinicaModel historiaPaciente)
        {
            {
                bool insercionHistoriaClinicaExitosa = false;
               
                var context = DbContextManager.GetContext();
                
                    var hc = new HistoriaClinicaModel
                    {
                        Familiares = historiaPaciente.Familiares,
                        Alergias = historiaPaciente.Alergias,
                        Medicamentos = historiaPaciente.Medicamentos,
                        Estudios = historiaPaciente.Estudios,
                        TipoSangre = historiaPaciente.TipoSangre,
                        IdUsuario = historiaPaciente.IdUsuario,
                        IdPaciente = historiaPaciente.IdPaciente,
                        FechaInicio = DateTime.Now,
                    };

                    context.HistoriaClinica.Add(hc);
                    context.SaveChanges();

                    // Verificar si la inserción de Historia Clínica fue exitosa
                 
                

                // Devolver verdadero solo si la inserción de Historia Clínica fue exitosa
                // y si la inserción de archivos fue exitosa o si no se proporcionaron archivos
                return insercionHistoriaClinicaExitosa ;
            }
        }
        internal bool Actualizar(HistoriaClinicaModel historiaPaciente)
        {
            bool actualizacionHistoriaClinicaExitosa = false;
          
            var context = DbContextManager.GetContext();

            // Obtener la Historia Clínica existente por su Id o como sea que la identifiques
            var hcExistente = context.HistoriaClinica.FirstOrDefault(hc => hc.Id == HistoriaClinicaSingleton.Instance.historiaAutenticado.Id);

            if (hcExistente != null)
            {
                // Actualizar las propiedades de la Historia Clínica existente
                hcExistente.Familiares = historiaPaciente.Familiares;
                hcExistente.Alergias = historiaPaciente.Alergias;
                hcExistente.Medicamentos = historiaPaciente.Medicamentos;
                hcExistente.Estudios = historiaPaciente.Estudios;
                hcExistente.TipoSangre = historiaPaciente.TipoSangre;
                hcExistente.IdUsuario = historiaPaciente.IdUsuario;
                hcExistente.IdPaciente = historiaPaciente.IdPaciente;


                context.SaveChanges();

                // Verificar si la actualización de la Historia Clínica fue exitosa
                actualizacionHistoriaClinicaExitosa = true;

                // Actualizar archivos relacionados si se proporcionan

                // Devolver verdadero solo si la actualización de la Historia Clínica fue exitosa
                // y si la actualización de archivos fue exitosa o si no se proporcionaron archivos
                return actualizacionHistoriaClinicaExitosa;
            }
            return false;
        }

        internal void  Buscar( )
        {

            HistoriaClinicaSingleton.Instance.Desautenticarhistoria();

            var context = DbContextManager.GetContext();
            int id = PacienteSingleton.Instance.pacienteAutenticado.Id;
            var hc = context.HistoriaClinica.FirstOrDefault(h => h.IdPaciente == PacienteSingleton.Instance.pacienteAutenticado.Id);

            if (hc != null)
            {
                context.Entry(hc).Reference(h => h.Paciente).Load();
                context.Entry(hc).Reference(h => h.Usuario).Load();
                HistoriaClinicaSingleton.Instance.Autenticarhistoria(hc);
            }
        }

        internal void desvincular()
        {
            

        }
    }
}
