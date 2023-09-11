using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocios
{
    public class App
    {
        public string nombre;
        public double size;

        public App(string nombre, double size)
        {
            this.nombre = nombre;
            this.size = size;
        }

        public static explicit operator string(App app) 
        {
            return $"{app.nombre} ({app.size} GB)";
        }
        
        public static implicit operator double(App app) 
        {
            return app.size;
        }
    }
}
