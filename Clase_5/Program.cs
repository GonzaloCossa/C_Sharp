using System.Numerics;

namespace Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////// VECTORES / ARRAY UNIDIMENSIONALES //////////////////////////////////
            /*
            int[] edades = { 20, 18, 54, 33, 21 };
            int[] edadesDos = new int[5];

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }

            foreach (int numero in edades)
            {
                Console.WriteLine(numero);
            }
             /*

            ////////////////////////////////// MATRIZ / ARRAY BIDIMENSIONAL //////////////////////////////////////
            /*
            int[,] matriz = new int[3, 2] { { 5, 9 }, { 8, 8 }, { 3, 7 } };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine(matriz[i, 1]);
            }
             */

            /////////////////////////////////////////////// LISTAS //////////////////////////////////////////////
            /*
            List<int> numeros = new List<int>();

            numeros.Add(2);
            numeros.Add(4);
            numeros.Add(3);
            numeros.Add(6);
            numeros.Add(3);
            numeros.Add(5);
            numeros.Add(6);

            Console.WriteLine(numeros.Contains(2));
            Console.WriteLine(numeros.IndexOf(3));

            numeros.Remove(3);

            Console.WriteLine(numeros.Count);

            numeros.Sort();

            foreach (int numero in numeros) Console.WriteLine(numero);

            numeros.Clear();

            foreach (int numero in numeros) Console.WriteLine(numero);

            Console.WriteLine(numeros.Count);
             */

            ///////////////////////////////////////// PILAS O STACK ////////////////////////////////////////////
            /*
            Stack<int> pila = new Stack<int>();
            List<int> eliminados = new List<int>();

            pila.Push(5);
            pila.Push(3);
            pila.Push(6);               
            pila.Push(1);
            pila.Push(9);
            pila.Push(2);

            foreach(int numero in pila) 
            { 
                Console.WriteLine(numero); 
            }

            int ultimo = pila.Peek();

            Console.WriteLine(ultimo);

            bool contiene = pila.Contains(100);

            Console.WriteLine(contiene);

            int eliminado = pila.Pop();

            Console.WriteLine(eliminado);

            for(int i = 0; i < 3; i++)
            {
                eliminados.Add(pila.Pop());
            }

            Console.WriteLine();

            foreach (int numero in eliminados)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();

            Stack<int> pilaEliminados = new Stack<int>(eliminados);

            foreach (int numero in pilaEliminados)
            {
                Console.WriteLine(numero);
            }
            */

            ///////////////////////////////////////// COLAS O QUEUE ////////////////////////////////////////////
            /*
            Queue<string> colaNombres = new Queue<string>();

            colaNombres.Enqueue("Giovanni");
            colaNombres.Enqueue("Mario");
            colaNombres.Enqueue("Ale");
            colaNombres.Enqueue("Luis");
            colaNombres.Enqueue("German");

            string primero = colaNombres.Peek();

            Console.WriteLine(primero);

            foreach(string nombre in colaNombres) 
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine(colaNombres.Dequeue());
            */

            ///////////////////////////////////////// DICCIONARIOS ////////////////////////////////////////////
            
            Dictionary<string, int> diccionarioPersonas = new Dictionary<string, int>();

            diccionarioPersonas["Mario"] = 35;
            diccionarioPersonas["Gionvanni"] = 23;
            diccionarioPersonas["Alejandro"] = 29;
            diccionarioPersonas["Luis"] = 19;

            /*
            Console.WriteLine(diccionarioPersonas["Alejandro"]);
            Console.WriteLine(diccionarioPersonas.ContainsKey("Alejandro"));

            List<string> claves = new List<string>();

            foreach(string clave in diccionarioPersonas.Keys)
            {
                Console.WriteLine(clave);
            }
            
            foreach(int value in diccionarioPersonas.Values)
            {
                Console.WriteLine(value);
            }
            */

            foreach(KeyValuePair<string, int> keyValuePair in diccionarioPersonas)
            {
                if(keyValuePair.Value > 25)
                {
                    Console.WriteLine($"Key: {keyValuePair.Key} Value: {keyValuePair.Value}");
                }
            }
        }
    }
}