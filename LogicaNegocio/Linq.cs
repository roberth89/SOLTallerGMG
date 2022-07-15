using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicaNegocio
{
    public class Linq
    {
        public void Test()
        {
            Modelo.Persona[] personasArray =
            {
                // Agregar propiedad edad en objeto
                new Modelo.Persona(){ Identificación = "01", Nombre = "Roberto", Edad = 15 },
                new Modelo.Persona(){ Identificación = "02", Nombre = "Nestor", Edad = 36 },
                new Modelo.Persona(){ Identificación = "03", Nombre = "Fernando", Edad = 23 },
                new Modelo.Persona(){ Identificación = "04", Nombre = "Ray", Edad = 68},
            };

            // Obtener a las personas jovenes
            Modelo.Persona[] personasJovenes = personasArray.Where(p => p.Edad > 12 && p.Edad < 20).ToArray();

            // Buscar por nombre a Ray
            Modelo.Persona objPersona = personasArray.Where(p => p.Nombre.ToUpper() == "Ray".ToUpper()).FirstOrDefault();

            Modelo.Persona objPersona2 = personasArray.Where(p => p.Identificación == "02").FirstOrDefault();



        }
    }
}
