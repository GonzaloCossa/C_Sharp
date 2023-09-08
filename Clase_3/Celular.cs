using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    internal class Celular
    {
        private bool _estaEncendido;
        private string _modelo;
        private static string _sistemaOperativo;

        static Celular()
        {
            _sistemaOperativo = "Android 2.5";
        }

        public Celular()
        {
            
        }

        public Celular(bool estaEncendido, string modelo) // Sobrecarga de un constructor
        {
            this._estaEncendido = estaEncendido;
            this._modelo = modelo;
        }

        public bool getEstaEncendido()
        {
            return this._estaEncendido;
        }
        public string getModelo()
        {
            return this._modelo;
        }

        public void setEstaEncendido(bool value)
        {
            this._estaEncendido = value;
        }
        public void setModelo(string value)
        {
            this._modelo = value;
        }

        public void Llamar(string numero)
        {
            if(this._estaEncendido) 
            {
                Console.WriteLine($"Estoy llamando al numero: {numero}");
            }
            else
            {
                Console.WriteLine("Debería prender el celular");
            }
        }
    }
}
