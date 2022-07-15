using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoGeneric<T>
    {
        // Array para almacenar info.
        private readonly T[] _datosElemento;
        private int _contador = 0;

        public AlmacenaObjetoGeneric(int tamanno)
        {
            // Inicializo Lista
            _datosElemento = new T[tamanno];
        }

        /// <summary>
        /// Para agregar elementos
        /// </summary>
        /// <param name="obj"></param>
        public void Agregar(T obj)
        {
            _datosElemento[_contador] = obj;
            _contador++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        public T getElemento(int posicion)
        {
            return _datosElemento[posicion];
        }

    }
}
