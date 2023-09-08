using System.Text;

namespace ClasesNegocios
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
        private List<string> agenda;
        private List<string> apps;
        #endregion

        #region Constructores

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, List<string> agenda): this(marca, modelo, ram, almacenamiento)
        {           
            this.Agenda = agenda;
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
            this.Apps = new List<string>();
            this.Agenda = new List<string>();
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

        public List<string> Agenda 
        { 
            get => agenda; 
            set => agenda = value; 
        }

        public List<string> Apps 
        {
            get => apps; 
            set => apps = value; 
        }
        #endregion

        #region Metodos

        public string AlternarEncendido()
        {
            this.Encendido = !this.Encendido;

            return this.Encendido ? "Encendiendo..." : "Apagando...";
        }

        public void Llamar(string numero)
        {
            if(this.encendido)
            {
                if(BuscarEnAgenda(numero))
                {
                    Console.WriteLine($"Llamando al numero: {numero}");
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

        public void Llamar(Contacto unContacto)
        {
            if (this.encendido)
            {
                if (BuscarEnAgenda(unContacto.numero))
                {
                    Console.WriteLine($"Llamando al numero: {unContacto.nombre}");
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

        private bool BuscarEnAgenda(string numeroIngresado)
        {
            return this.agenda.Contains(numeroIngresado);
        }

        private bool InstalarApp(App aplicacion)
        {
            bool exito = false;

            if(this.encendido && this != aplicacion && VerificarEspacio(aplicacion.size))
            {
                exito = true;
                this.apps.Add(aplicacion.nombre);
                this.almacenamientoActual += aplicacion.size;
            }
            return exito;
        }

        private bool VerificarEspacio(double nuevoSize)
        {
            return (this.almacenamientoActual + nuevoSize) < this.almacenamiento;
        }

        public static bool operator ==(Celular miCelular, App miApp)
        {
            return miCelular.Apps.Contains(miApp.nombre);

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
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"RAM: {this.Ram}");
            sb.AppendLine($"Almacenamiento: {this.Almacenamiento}");
            sb.AppendLine($"Aplicaciones Instaladas:");
            if(this.apps.Count > 0) 
            {
                foreach(string app in this.Apps ) 
                {
                    sb.AppendLine($"\t{app}");
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