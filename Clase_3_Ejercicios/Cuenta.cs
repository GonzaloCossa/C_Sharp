using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_Ejercicios
{
    internal class Cuenta
    {
        private string _titular;
        private decimal _cantidad;

        public Cuenta() 
        {

        }

        public Cuenta(string _titular, decimal _cantidad)
        {
            this._titular = _titular;
            this._cantidad = _cantidad;
        }

        public string getTitular()
        { 
            return _titular; 
        }

        public decimal getCantidad()
        {
            return _cantidad;
        }

        public string CuentaToString()
        { 
            return $"Titular de la Cuenta: {this._titular} \nCantidad de Dinero en la Cuenta: {this._cantidad}\n"; 
        }

        public void IngresarDinero(decimal value)
        {
            if(value > 0)
            {
                this._cantidad += value;
            }
        }

        public void RetirarDinero(decimal value)
        {
            if (value > 0)
            {
                this._cantidad -= value;
            }
        }
    }
}
