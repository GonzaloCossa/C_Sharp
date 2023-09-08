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

            Contacto contacto1 = new Contacto("Juan", "1111");

            celular1.Llamar(contacto1);

            Console.WriteLine("********************************************************");

            App miApp1 = new App("Instagram", 40f);
            App miApp2 = new App("WhatsApp", 20f);
            App miApp3 = new App("Minecraft", 500f);

            List<App> listaApps = new List<App>();
            listaApps.Add(miApp1);
            listaApps.Add(miApp2);
            listaApps.Add(miApp3);
            bool exito;

            foreach(App app in listaApps) 
            {
                exito = celular1 + app;

                if(exito)
                {
                    Console.WriteLine($"Exito al instalar {app.nombre}");
                }
                else
                {
                    Console.WriteLine($"No se pudo instalar {app.nombre} por falta de memoria");
                }
            }

            Console.WriteLine(celular1.ToString());
        }
    }
}