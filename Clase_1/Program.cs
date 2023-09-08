namespace Clase_1
{
    internal class Program
    {
        static void Main()
        {
            string nombreIngresado;
            int edad;

            try 
            {
                Console.Write("Ingrese su nombre: ");
                nombreIngresado = Console.ReadLine();

                Console.Write("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine($"Tu nombre es {nombreIngresado} y tu edad es {edad}");
            }
            catch
            {
                Console.WriteLine("\nError....");
            }
            finally
            {
                Console.WriteLine("\nFin del programa");            
            }
        }
    }
}