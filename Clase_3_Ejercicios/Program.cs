namespace Clase_3_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta;
            miCuenta = new Cuenta("Gonzalo Cossa", 10000.00m);
            
            miCuenta.RetirarDinero(6000.01m);

            Console.WriteLine(miCuenta.CuentaToString());

            miCuenta.IngresarDinero(16000.01m);

            Console.WriteLine(miCuenta.CuentaToString());
        }
    }
}