using Clases_Ej_Colecciones;

namespace Ejercicio_Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Celular> celus = new List<Celular>();

            Celular celular1 = new Celular(EMarca.Samsung, "A10", 8, 256);
            Celular celular2 = new Celular(EMarca.Apple, "14 Pro Max", 16, 64);
            Celular celular3 = new Celular(EMarca.Xiaomi, "Redmi Note 11", 32, 128);

            celus.Add(celular1);
            celus.Add(celular2);
            celus.Add(celular3);

            celular1.AlternarEncendido();
            celular2.AlternarEncendido();
            celular3.AlternarEncendido();

            Contacto contacto1 = new Contacto("Cane", "54 11 8918 1592");
            Contacto contacto2 = new Contacto("Gonza", "54 11 4189 2169");
            Contacto contacto3 = new Contacto("Cazz", "54 11 1898 1238");
            Contacto contacto4 = new Contacto("Botta", "54 11 5438 5384");
            Contacto contacto5 = new Contacto("Peker", "54 11 1592 7551");
            Contacto contacto6 = new Contacto("Yao", "54 11 1896 6548");

            celular1.Agenda.Add(contacto1, DateTime.Now.ToString());
            celular1.Agenda.Add(contacto2, DateTime.Now.ToString());
            celular1.Agenda.Add(contacto3, DateTime.Now.ToString());

            celular2.Agenda.Add(contacto4, DateTime.Now.ToString());
            celular2.Agenda.Add(contacto5, DateTime.Now.ToString());
            celular2.Agenda.Add(contacto6, DateTime.Now.ToString());

            celular3.Agenda.Add(contacto1, DateTime.Now.ToString());
            celular3.Agenda.Add(contacto3, DateTime.Now.ToString());
            celular3.Agenda.Add(contacto6, DateTime.Now.ToString());

            App app1 = new App("Instagram", 20);
            App app2 = new App("Facebook", 40);
            App app3 = new App("Call Of Duty", 750);

            List<App> listaApps = new List<App>
            {
                app1,
                app2,
                app3
            };

            foreach(Celular celular in celus)
            {
                bool exito;
                foreach (App aplicacion in listaApps)
                {
                    exito = celular + aplicacion;
                    if (exito)
                    {
                        Console.WriteLine($"Exito al instalar {aplicacion.Nombre}");
                    }
                    else
                    {
                        Console.WriteLine($"No se pudo instalar {aplicacion.Nombre} por falta de memoria");
                    }
                }
                Console.WriteLine();
            }

            celular1.Llamar(contacto1);
            celular1.Llamar(contacto6);
            celular1.Llamar(contacto3);

            Console.WriteLine();

            celular2.Llamar(contacto2);
            celular2.Llamar(contacto5);
            celular2.Llamar(contacto1);

            Console.WriteLine();

            celular3.Llamar(contacto2);
            celular3.Llamar(contacto1);
            celular3.Llamar(contacto6);

            Console.WriteLine();

            Stack<Celular> celulares = new Stack<Celular>();
            celulares.Push(celular1);
            celulares.Push(celular2);
            celulares.Push(celular3);

            Compania compania = new Compania("Movistar", celulares);

            compania.MostrarCompania();
        }
    }
}