using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        #region Atributos
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion

        #region Metodos
        static Peso()
        {
            cotzRespectoDolar = 1 / 102.65;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
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
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.getCotzRespectoDolar);
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)(Dolar)p;
        }
        #endregion
    }
}
