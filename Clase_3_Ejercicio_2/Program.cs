namespace Clase_3_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno;
            Estudiante estudianteDos;
            Estudiante estudianteTres;

            estudianteUno = new Estudiante("Gonzalo", "Cossa", "1000");
            estudianteDos = new Estudiante("Juan", "Lopez", "1001");
            estudianteTres = new Estudiante("Nacho", "Macho", "1002");

            estudianteUno.SetNotaPrimerParcial(8);
            estudianteUno.SetNotaSegundoParcial(6);

            estudianteDos.SetNotaPrimerParcial(7);
            estudianteDos.SetNotaSegundoParcial(4);

            estudianteTres.SetNotaPrimerParcial(4);
            estudianteTres.SetNotaSegundoParcial(2);

            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());
        }
    }
}