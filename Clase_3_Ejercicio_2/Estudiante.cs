using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_Ejercicio_2
{
    internal class Estudiante
    {
        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        static Estudiante()
        {
            _random = new Random();
        }

        public Estudiante(string _nombre, string _apellido, string _legajo)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._legajo = _legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial) 
        {
            this._notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial) 
        {
            this._notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            return (this._notaPrimerParcial + this._notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double nota;

            if (this._notaPrimerParcial >= 4 && this._notaSegundoParcial >= 4)
            {
                nota = _random.Next(6, 11);
            }
            else
            {
                nota = -1; 
            }

            return nota;
        }

        public string Mostrar()
        {
            double nota = this.CalcularNotaFinal();

            StringBuilder sB = new StringBuilder();
            sB.AppendLine($"Nombre: {this._nombre} - Apellido: {this._apellido} - Legajo: {this._legajo}");
            sB.AppendLine($"Nota primer parcial: {this._notaPrimerParcial} - Nota segundo parcial: {this._notaSegundoParcial}");
            sB.AppendLine($"Promedio: {this.CalcularPromedio()}");

            if(nota != -1)
            {
                sB.AppendLine($"Nota final: {nota}");
            }
            else
            {
                sB.AppendLine($"Nota final: Alumno desaprobado");
            }
            return sB.ToString();
        }
    }
}
