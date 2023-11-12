using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprmirPdf
{


    public  static class ContenidoHTML
    {


        public static string ObtenerContenidoHTML()
        {
            string encabezado = "Historia Clinica";

            //Historia clinica
            string historiaNumero = HistoriaClinicaSingleton.Instance.historiaAutenticado.Id.ToString();
            string historiaFechaInicio = HistoriaClinicaSingleton.Instance.historiaAutenticado.FechaInicio.ToString("dd/MM/yyyy");

            //Medico
            string medicoNombreYAp = HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Nombre + " " +
                                    HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Apellido;
            string medicoMatricula = HistoriaClinicaSingleton.Instance.historiaAutenticado.Usuario.Matricula.ToString();
            
            //Paciente
            string pacienteNombreYAp = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Nombre + " " +
                                    HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Apellido;
            string pacienteDni = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Dni.ToString();

            string pacienteFechaNac = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.FechaNacimiento.ToString("dd/MM/yyyy");
            string pacienteSexo = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Sexo;
            string pacienteDomicilio = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.Domicilio;
            string pacienteObraSocial = HistoriaClinicaSingleton.Instance.historiaAutenticado.Paciente.ObraSocial;
            
            string pacienteTipoSangre = HistoriaClinicaSingleton.Instance.historiaAutenticado.TipoSangre;

            //Historia clinica
            string antecedentes = HistoriaClinicaSingleton.Instance.historiaAutenticado.Familiares;
            string medicamentos = HistoriaClinicaSingleton.Instance.historiaAutenticado.Medicamentos;
            string alergias = HistoriaClinicaSingleton.Instance.historiaAutenticado.Alergias;

            string contenidoHTML = $@"
            <html>
            <head>
                <title>Historia Clínica</title>
                <link rel='stylesheet' type='text/css' href='estilos.css' media='all'>
            </head>
                <body>
                    <div id=""informacion-general"">
                            <img src='logo_hospital_eloisa_torrent.jpg' alt='logo-hospital'/>
                            <h1>{encabezado}</h1>
                            <p>Fecha inicio: {historiaFechaInicio}</p>
                            <p>Nro. de HC: {historiaNumero}</p>
                            <h2>Medico</h2>
                            <p>Nombre y apellido: {medicoNombreYAp}</p>
                            <p>Matricula: {medicoMatricula}</p>
                            <h2>Paciente</h2>
                            <p>Nombre y apellido: {pacienteNombreYAp}</p>

                            <p>DNI: {pacienteDni}</p>
                            <p>Fecha de nacimiento: {pacienteFechaNac}</p>
                            <p>Sexo: {pacienteSexo}</p>
                            <p>Domicilio: {pacienteDomicilio}</p>
                            <p>Obra social: {pacienteObraSocial}</p>

                            <p>Tipo de sangre: {pacienteTipoSangre}</p>

                            
                            <h3>Antecedentes: Antecedentes medicos</h3>
                            <p>Antecedentes: {antecedentes}</p>
                            <p>Alergias: {alergias}</p>
                            <p>Medicamentos: {medicamentos}</p>
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

