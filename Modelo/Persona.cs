using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    /// <summary>
    /// hvj
    /// </summary>
    public class Persona
    {
        public string Identificación { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public decimal MontoTransaccion { get; set; }
        public string Mensaje { get; set; }

    }
}
