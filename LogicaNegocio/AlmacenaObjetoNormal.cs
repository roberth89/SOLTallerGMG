using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoNormal
    {
        // Array para almacenar info.
        private readonly Object[] _datosElemento;
        private int _contador = 0;

        public AlmacenaObjetoNormal(int tamanno)
        {
            // Inicializo Lista
            _datosElemento = new Object[tamanno];
        }

        /// <summary>
        /// Para agregar elementos
        /// </summary>
        /// <param name="obj"></param>
        public void Agregar(Object obj)
        {
            _datosElemento[_contador] = obj;
            _contador++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        public Object getElemento(int posicion)
        {
            return _datosElemento[posicion];
        }


    }
}
