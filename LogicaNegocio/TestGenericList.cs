using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class TestGenericList
    {

        public void PruebaListasGenericas()
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Hola Mundo");


            GenericList<Modelo.Persona> list3 = new GenericList<Modelo.Persona>();
            list3.Add(new Modelo.Persona { Nombre = "Roberto" });

        }
    }
}
