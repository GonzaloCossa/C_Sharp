namespace Clase_2
{
    using System.Text;
    using SO = StringOperation.TextOperations;
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////// EJ 1 /////////////////////////////////////////

            string nombre = "Gonzalo";

            Console.WriteLine(SO.ContarLetras(nombre));

            ///////////////////////////////////////// EJ 2 /////////////////////////////////////////

            string texto = "Hola que tal buenos días";

            Console.WriteLine(SO.ContarPalabras(texto));

            ///////////////////////////////////////// EJ 3 /////////////////////////////////////////

            string palabra = "";

            Console.WriteLine(SO.ContarVocales(palabra));

            ///////////////////////////////////////// EJ 4 /////////////////////////////////////////

            string palabraDos = "Laboratorio";

            Console.WriteLine(SO.ContarConsonantes(palabraDos));

            ///////////////////////////////////////// EJ 5 /////////////////////////////////////////

            string palabraTres = "Prueba";

            Console.WriteLine(palabraTres = SO.ReemplazarCaracter(palabraTres, 'a', 'o'));

            ///////////////////////////////////////// EJ 6 /////////////////////////////////////////

            string textoDos = "12";
            int entero = 0;

            SO.ConvertirStringAEntero(textoDos, ref entero);

            Console.WriteLine(entero);

            ///////////////////////////////////////// EJ 7 /////////////////////////////////////////

            string palabraSB = "StringBuilder";

            StringBuilder sb = SO.ConvertirStringASB(palabraSB);

            Console.WriteLine(sb);

            ///////////////////////////////////////// EJ 8 /////////////////////////////////////////

            string parrafo = "Hola que tal este es un parrafo ejemplo. Espero que esta cursada sea facil. Saludos";

            StringBuilder ejOcho = SO.ConvertirParrafoASB(parrafo);

            Console.WriteLine(ejOcho);

            ///////////////////////////////////////// EJ 9 /////////////////////////////////////////

            string mensaje = "Mensaje ingresado";
            string textoTres = "Este es un texto de ejemplo";

            SO.MostrarTexto(mensaje, textoTres);

            ///////////////////////////////////////// EJ 10 /////////////////////////////////////////

            StringBuilder textoCuatro = new StringBuilder();

            textoCuatro.Append("Terminado");

            SO.MostrarTextoSB(textoCuatro);
        }
    }
}