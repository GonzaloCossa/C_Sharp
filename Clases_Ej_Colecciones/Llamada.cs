using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ej_Colecciones
{
    public class Llamada
    {
        #region Atributos
        private string fecha;
        private string numeroDestino;
        private string duracion;
        #endregion

        #region Propiedades
        public string Fecha { get => fecha; set => fecha = value; }
        public string NumeroDestino { get => numeroDestino; set => numeroDestino = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        #endregion

        #region Metodos
        public Llamada(string fecha, string numeroDestino, string duracion)
        {
            this.fecha = fecha;
            this.numeroDestino = numeroDestino;
            this.duracion = duracion;
        }
        #endregion
    }
}
