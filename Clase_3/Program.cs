namespace Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular miCelular;

            miCelular = new Celular(false, "J7");

            miCelular.setEstaEncendido(true);
            miCelular.Llamar("44444");

            //miCelular.setEstaEncendido(true);
            //Console.WriteLine($"Modelo: {miCelular.getModelo()} Estado: {miCelular.getEstaEncendido()}");
            //miCelular.setEstaEncendido(false);

        }
    }
}