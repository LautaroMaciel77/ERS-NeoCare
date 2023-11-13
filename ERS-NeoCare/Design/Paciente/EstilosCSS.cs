using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprmirPdf
{
    public static class EstilosCSS
    {
        public static string ObtenerEstilosCSS()
        {
            string estilosCSS = @"
            body {
        font-family: Arial, sans-serif;
    }

    h1, h2, h3 {
        color: #000; /* Color del texto en blanco y negro */
    }

    #informacion-general, #historial-medico {
        margin-bottom: 20px;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    p {
        color: #000; /* Color del texto en blanco y negro */
    }

    /* Estilos específicos para la impresión */
    @media print {
        body {
            color: #000;
        }

        h1, h2, h3 {
            page-break-before: always;
        }

        #informacion-general, #historial-medico {
            page-break-inside: avoid;
        }

        ul {
            page-break-before: auto;
        }

        p {
            page-break-inside: avoid;
        }
    }";

            return estilosCSS;
        }
    }
}
