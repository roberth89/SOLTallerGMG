using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicaNegocio
{
    public class Lambda
    {
        public int LambdaSuma()
        {           
            Func<int, int, int> suma = (a, b) => a + b;
            int resultado = suma(2,6);
            return resultado;
        }

        public int LambdaMayorFuncionalidad()
        {
            Func<int, int, int> mayor = (a, b) =>
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }

            };
            int result = mayor(2, 6);
            return result;
        }

        public IEnumerable<int> ObtenerPares()
        {
            var colas = LogicaNegocio.Lista.Colas().ToArray();
            //Vamos a poner System.Linq;
            // Si el residuo es cero, 
            Func<int, bool> GetPares = (numero) => numero % 2 == 0;
            // Where es de Linq
            var pares = colas.Where(GetPares);

            // Desventaja no vas a poder reutilizarlo debes copiarlo una y otra vez.
            var paresSinEncapsular = colas.Where((numero) => numero % 2 == 0);

            return pares;

            // Podriamos crear una clase estatica que tengas todas estas funcionalidades.
        }

        // Validar si explico este, ya que lleva delegados.
        public void test()
        {
            var colas = LogicaNegocio.Lista.Colas().ToList();
            Action<int> imprimirConsola = (pNumero) => Console.WriteLine(pNumero);

            Action<List<int>> mostrar = (pColas) =>
            {
                foreach (var itemCola in pColas)
                {
                    imprimirConsola(itemCola);
                }
            };
            mostrar(colas);
        }
    }
}
