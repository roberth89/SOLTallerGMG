using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public static class Lista
    {
        private static string[] miArrayDeNombresDePerros = new string[4] { "Laika", "Coco", "Thor", "Tobi" };

        private static List<string> personaNombres = new List<string>();

        public static string[] ListaArray()
        {
            try
            {
                //miArrayDeNombresDePerros[0] = "Laika";
                //miArrayDeNombresDePerros[1] = "Coco";
                //miArrayDeNombresDePerros[2] = "Thor";
                //miArrayDeNombresDePerros[3] = "Tobi";
                return miArrayDeNombresDePerros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<string> ListEjemplo()
        {
            try
            {
                personaNombres.Add("Nestor");
                personaNombres.Add("Hazel");
                return personaNombres;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
