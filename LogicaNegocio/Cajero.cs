using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class Cajero
    {

        public enum TipoCuenta
        {
            Ahorro = 0,
            Corriente = 1,
        }

        private decimal _dineroActual = 10000;

        /// <summary>
        /// Ejemplo de una variable
        /// </summary>

        private int _contador = 0;

        /// <summary>
        /// Ejemplo de una constante
        /// </summary>
        private const int MAXIMO = 5;


        public Cajero()
        {

        }

        /// <summary>
        /// Propiedades para acceder a la variables.
        /// </summary>
        public decimal DineroActual
        {
            get { return _dineroActual; }
            // set { _dineroActual = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="montoRetiro"></param>
        /// <param name="mensaje">Un parámetro por referencia tiene por objetivo modificar el contenido de una variable
        /// que se le envía a un procedimiento. Si por medio de un parámetro por valor llega un dato a un procedimiento, 
        /// por un parámetro por referencia se retorna y sale un dato de un procedimiento.</param>
        /// <returns></returns>
        public decimal RetirarDinero(decimal montoRetiro, ref string mensaje)
        {
            try
            {
                // Si Monto Retiro es MAtor al dinero actial
                if (montoRetiro > DineroActual)
                {
                    mensaje = "El monto de Retiro: "
                            + montoRetiro
                            + ", es Mayor al diponible :( ! "
                            + DineroActual;
                    return DineroActual;
                }
                else
                {
                    // Acumulador.          
                    _dineroActual -= montoRetiro;
                    mensaje = "CUIDE SU DINERO !!! tiene disponible: " + _dineroActual;
                    return DineroActual;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
