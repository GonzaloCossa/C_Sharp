using System.Text;
using System.Threading.Channels;

namespace Clases_Ej_Colecciones
{
    public class App
    {
        #region Atributos
        private string nombre;
        private double size;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public double Size { get => size; set => size = value; }
        #endregion

        #region Constructores
        public App(string nombre, double size)
        {
            this.Nombre = nombre;
            this.Size = size;
        }
        #endregion

        #region Sobrecarga
        public static explicit operator string(App app)
        {
            return $"{app.Nombre} {app.Size} GB";
        }

        public static implicit operator double(App app)
        {
            return app.Size;
        }
        #endregion

        #region Metodo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.Nombre} Tamaño: {this.Size} GB");
            
            return sb.ToString();
        }
        #endregion

    }
}