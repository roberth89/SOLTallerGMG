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
            personaNombres.Add("Nestor");
            personaNombres.Add("Hazel");
            return personaNombres;
        }

        public static LinkedList<int> LinkedListEjemplo()
        {
            LinkedList<int> numerosLinkedList = new LinkedList<int>();

            int[] array = new int[6] { 10, 8, 6, 4, 2, 0 };

            foreach (var itemNumero in array)
            {

                // numerosLinkedList.AddFirst(itemNumero);
                numerosLinkedList.AddLast(itemNumero);
            }

            numerosLinkedList.Remove(6);

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            numerosLinkedList.AddFirst(nodoImportante);


            // Ver desde el wathc
            return numerosLinkedList;
        }

        // Primer en entrar primero en salir
        public static Queue<int> Colas()
        {
            Queue<int> numerosCola = new Queue<int>();

            int[] array = new int[6] { 10, 8, 6, 4, 2, 0 };

            // Rellenando o agregando elementos a la cola

            foreach (int item in array)
            {
                numerosCola.Enqueue(item);
                
            }

            numerosCola.Dequeue();
            return numerosCola;
        }

        // Ejemplo de plato de filas siempre se utiliza el primer elemento.. 
        //el ultimo elmento en entrar sera el primero en salir
        public static Stack<int> Pilas()
        {
            Stack<int> numerosPila = new Stack<int>();

            int[] array = new int[6] { 10, 8, 6, 4, 2, 0 };

            // Rellenando o agregando elementos a la cola

            foreach (int item in array)
            {
                numerosPila.Push(item);

            }

            // quita el ultimo elemento en agregar
            numerosPila.Pop();

           // numerosCola.Dequeue();
            return numerosPila;
        }

        public static Dictionary<string, int> Diccionarios()
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenar el diccionario, vamos a llenarlo de forma manual, con add, o con una sintaxis parecida a los array.

            edades.Add("Roberto", 33);
            edades.Add("Juan", 18);

            // sintaxis de arrays

            edades["Maria"] = 25;
            edades["Antonio"] = 88;

            // recorrer el dicionario , 
            // 
            foreach (var item in edades)
            {
                //item.Key;
                //item.Value;
            }

            return edades;

        }
    }
}
