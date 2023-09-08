using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSpace
{
    internal class Metodos
    {
        /// <summary>
        /// Determina si el numero pasado por parametro es o no par
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> True: Si es par | False: Si no es par</returns>
        public static bool DeterminarParidad(int numero)
        {
            return (numero % 2 == 0);
        }
    }
}

