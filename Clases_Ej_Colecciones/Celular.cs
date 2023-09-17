using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ej_Colecciones
{
    public class Celular
    {
        #region Atributos

        private EMarca marca;
        private string modelo;
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;
        private Dictionary<Contacto, string> agenda;
        private List<App> apps;
        private Queue<Llamada> llamadasRealizadas;
        private string titular;
        private string numero;
        #endregion

        #region Constructores

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, Dictionary<Contacto, string> agenda, string titular, string numero, Queue<Llamada> llamadasRealizadas) : this(marca, modelo, ram, almacenamiento)
        {
            this.LlamadasRealizadas = llamadasRealizadas;
            this.Agenda = agenda;
            this.titular = titular;
            this.numero = numero;
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento): this()
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ram = ram;
            this.Almacenamiento = almacenamiento;
            this.Encendido = false;
            this.AlmacenamientoActual = 0;
        }

        public Celular()
        {
            this.Apps = new List<App>();
            this.Agenda = new Dictionary<Contacto, string>();
            this.LlamadasRealizadas = new Queue<Llamada>();
        }
        #endregion

        #region Propiedades

        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        public EMarca Marca
        {
            get => marca;
            set => marca = value;
        }

        public int Ram
        {
            get => ram;
            set => ram = value;
        }

        public double Almacenamiento
        {
            get => almacenamiento;
            set => almacenamiento = value;
        }

        public double AlmacenamientoActual
        {
            get => almacenamientoActual;
            set => almacenamientoActual = value;
        }

        public bool Encendido
        {
            get => encendido;
            set => encendido = value;
        }

        public Dictionary<Contacto, string> Agenda
        {
            get => agenda;
            set => agenda = value;
        }
        public Queue<Llamada> LlamadasRealizadas 
        { 
          get => llamadasRealizadas; 
          set => llamadasRealizadas = value; 
        }

        public List<App> Apps
        {
            get => apps;
            set => apps = value;
        }

        public string Titular 
        { 
            get => titular; 
            set => titular = value; 
        }

        public string Numero 
        { 
            get => numero; 
            set => numero = value; 
        }
        #endregion

        #region Metodos

        public string AlternarEncendido()
        {
            this.Encendido = !this.Encendido;

            return this.Encendido ? "Encendiendo..." : "Apagando...";
        }

        public void Llamar(Contacto unContacto)
        {
            if (this.encendido)
            {
                if(BuscarEnAgenda(unContacto))
                {
                    Console.WriteLine($"Llamando al numero: {unContacto.Numero}");
                    Random duracion = new Random();
                    Llamada llamadadaRealizada = new Llamada(DateTime.Now.ToString(), unContacto.Numero, duracion.Next(0, 120).ToString());  

                    this.LlamadasRealizadas.Enqueue(llamadadaRealizada);
                }
                else
                {
                    Console.WriteLine("Numero no encontrado...");
                }
            }
            else
            {
                Console.WriteLine("El celular esta apagado");
            }
        }

        private bool BuscarEnAgenda(Contacto unContacto)
        {
            return this.agenda.ContainsKey(unContacto);
        }

        private bool InstalarApp(App aplicacion)
        {
            bool exito = false;

            if (this.encendido && this != aplicacion && VerificarEspacio(aplicacion))
            {
                exito = true;
                this.apps.Add(aplicacion);
                this.almacenamientoActual += aplicacion.Size;
            }
            return exito;
        }

        private bool VerificarEspacio(App aplicacion)
        {
            return (this.almacenamientoActual + aplicacion.Size) < this.almacenamiento;
        }

        public static bool operator ==(Celular miCelular, App miApp)
        {
            return miCelular.Apps.Contains(miApp);

        }

        public static bool operator !=(Celular miCelular, App miApp)
        {
            return !(miCelular == miApp);
        }

        public static bool operator +(Celular miCelular, App miApp)
        {
            return miCelular.InstalarApp(miApp);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("************************************************");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"RAM: {this.Ram}");
            sb.AppendLine($"Almacenamiento: {this.Almacenamiento}");
            sb.AppendLine($"Aplicaciones Instaladas:");
            if (this.apps.Count > 0)
            {
                foreach (App app in this.Apps)
                {
                    sb.AppendLine($"\t{(string) app}");
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }

            sb.AppendLine("************************************************");

            return sb.ToString();
        }
        #endregion
    }
}
