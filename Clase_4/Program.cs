using ClasesNegocios;

namespace Clase_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> agenda = new List<string>();
            agenda.Add("1111");
            agenda.Add("2222");
            agenda.Add("3333");

            Celular celular1 = new Celular(EMarca.Samsung, "J7", 4, 64, agenda);

            Console.WriteLine(celular1.AlternarEncendido());
            Console.WriteLine(celular1.AlternarEncendido());


        }
    }
}