using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.Model
{
    public class TurnoModel
    {
        public DateTime selectedDate { get; set; }
        public string selectedTimeRange { get; set; }
        public string dni { get; set; }

        public TurnoModel(string dni)
        {
            this.dni = dni;
        }

        public List<string> GetTimeRanges()
        {
            int intervaloEnMinutos = 30;
            int totalHoras = 24;
            int totalBloques = (totalHoras * 60) / intervaloEnMinutos;

            List<string> bloquesDeHorario = new List<string>();

            for (int i = 0; i < totalBloques; i++)
            {
                TimeSpan bloqueInicio = TimeSpan.FromMinutes(i * intervaloEnMinutos);
                TimeSpan bloqueFin = TimeSpan.FromMinutes((i + 1) * intervaloEnMinutos);

                bloquesDeHorario.Add($"{bloqueInicio:hh\\:mm} - {bloqueFin:hh\\:mm}");
            }

            return bloquesDeHorario;
        }

        public void SetSelectedDate(DateTime date)
        {
            selectedDate = date;
        }

        public void SetSelectedTimeRange(string timeRange)
        {
            selectedTimeRange = timeRange;
        }

        public void AddAppointment()
        {
          
        }
    }
}


