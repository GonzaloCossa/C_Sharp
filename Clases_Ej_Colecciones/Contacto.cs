using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ej_Colecciones
{
    public class Contacto
    {
        private string nombre;
        private string numero;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Numero { get => numero; set => numero = value; }

        public Contacto(string nombre, string numero)
        {
            this.Nombre = nombre;
            this.Numero = numero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.Nombre} Numero: {this.Numero}");

            return sb.ToString();
        }
    }
}
