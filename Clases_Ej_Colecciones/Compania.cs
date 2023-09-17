using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ej_Colecciones
{
    public class Compania
    {
        private string razonSocial;
        private static DateTime fechaApertura;
        private Stack<Celular> celulares;


        static Compania()
        {
            fechaApertura = DateTime.Now;
        }

        public Compania(string razonSocial, Stack<Celular> celulares)
        {
            this.razonSocial = razonSocial;
            this.celulares = celulares;
        }

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }

        public static DateTime FechaApertura { get => fechaApertura; }

        public Stack<Celular> Celulares { get => celulares; set => celulares = value; }

        public void MostrarCompania()
        {
            Console.WriteLine($"Razon Social: {RazonSocial}\n");
            Console.WriteLine($"Fecha Apertura: {FechaApertura}\n");
            Console.WriteLine("Celulares:\n");
            foreach (Celular celular in this.celulares)
            {
                Console.WriteLine(celular.ToString());
                Console.WriteLine("Llamadas Realizadas del celular:\n");
                foreach (Llamada llamadaRealizada in celular.LlamadasRealizadas)
                {
                    Console.WriteLine($"{llamadaRealizada.Fecha} {llamadaRealizada.NumeroDestino} {llamadaRealizada.Duracion} Segs");
                }
                Console.WriteLine();
            }
        }
    }
}
