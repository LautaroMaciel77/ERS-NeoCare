using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprmirPdf
{
    public static class ContenidoHTML
    {
            public static string ObtenerContenidoHTML()
            {
                string encabezado = "Historia Clinica";
                string contenidoHTML = $@"
            <html>
            <head>
                <title>Historia Clínica</title>
                <link rel='stylesheet' type='text/css' href='estilos.css' media='all'>
            </head>
                <body>
                    <div id=""informacion-general"">
                            <h1>{encabezado}</h1>
                            HistoriaClinicaSingleton.Instance.historiaAutenticado.campo
                            HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.campo
                            HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.campo
                            <p>Fecha actual: [Fecha Actual]</p>
                            <p>Paciente: [Nombre] [Apellido]</p>
                            <p>Domicilio: [Domicilio]</p>
                            <p>Fecha de Nacimiento: [Fecha de Nacimiento]</p>
                            <p>Sexo: [Sexo]</p>
                            <p>Obra Social: [Obra Social]</p>
                            <h3>Médico:</h3>
                            <p>Nombre: [Matrícula Médico]</p>
                            <p>Matrícula Médico: [Matrícula Médico]</p>
                            <p>Número de Historia Clínica: [Número de Historia Clínica]</p>
                            <p>Fecha de Inicio de la Historia Clínica: [Fecha de Inicio de Historia Clínica]</p>
                            <h3>Antecedentes: [Antecedentes]</h3>
                            <p>Antecedentes: [Antecedentes]</p>
                            <p>Alergias: [Alergias]</p>
                            <p>Medicamentos: [Medicamentos]</p>
                            <p>Tipo de Sangre: [Tipo de Sangre]</p>
                        </div>
                        <div id=""historial-medico"">
                            <h2>Historial de Actuaciones Médicas</h2>
                            <ul>
                                <li>[Fecha]: [Descripción de la actuación médica]</li>
                                <!-- Repetir esta estructura para cada actuación médica -->
                            </ul>
                     </div>
                </body>
            </html>";

                return contenidoHTML;
            }
    }
}

