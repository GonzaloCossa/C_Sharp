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
            this.agenda = agenda;
        }
        
        public Celular(EMarca marca, string modelo, int ram, double almacenamiento): this()
        {
            this.marca = marca;
            this.modelo = modelo;    
            this.ram = ram;
            this.almacenamiento = almacenamiento;
            this.encendido = false;
            this.almacenamientoActual = 0;
        }

        public Celular()
        {
            this.apps = new List<string>();
            this.agenda = new List<string>();
        }
        #endregion

        #region Metodos
        public string AlternarEncendido()
        {
            this.encendido = !this.encendido;

            return this.encendido ? "Encendiendo..." : "Apagando...";
        }
        #endregion
    }
}