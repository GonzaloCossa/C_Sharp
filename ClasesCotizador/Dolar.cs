namespace Billetes
{
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion

        #region Metodos
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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
        public static implicit operator Dolar(double d) 
        {   
            return new Dolar(d);
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.getCotzRespectoDolar);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.getCotzRespectoDolar);
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.getCantidad == d2.getCantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.getCantidad == ((Dolar)e.getCantidad));
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator == (Dolar d, Peso p)
        {
            return (d.getCantidad == ((Dolar)p.getCantidad));
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.getCantidad - ((Dolar)e).getCantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.getCantidad - ((Dolar)p).getCantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.getCantidad + ((Dolar)e).getCantidad);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.getCantidad + ((Dolar)p).getCantidad);
        }
        #endregion
    }
}