using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotzRespectoDolar;

        #endregion

        #region Metodos
        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }
        
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double getCantidad
        {
            get
            {
                return cantidad;
            }
        }

        public static double getCotzRespectoDolar
        {
            get
            {
                return cotzRespectoDolar;
            }
        }
        #endregion

        #region Sobrecarga Implicita
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.getCotzRespectoDolar);
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)(Dolar)e;
        }
        #endregion

        #region Sobrecarga Operadores
        #endregion
    }
}
