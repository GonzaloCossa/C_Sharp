using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    internal class TextOperations
    {
        /// <summary>
        /// Se encarga de contar la cantidad de letras que tiene una palabra pasada por parametros
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns> Retorna la cantidad de letras que tiene la palabra </returns>
        public static int ContarLetras(string palabra)
        {
            int cantLetras = 0;

            foreach(char ch in palabra) 
            {
                if(ch != ' ')
                {
                    cantLetras += 1;
                }
            }
            return cantLetras;
        }

        /// <summary>
        /// Cuanta las palabras que tiene un texto pasado por parametro
        /// </summary>
        /// <param name="texto"></param>
        /// <returns> Retorna la cantidad de palabras </returns>
        public static int ContarPalabras(string texto)
        {
            int cantPalabras = 0;
            bool enPalabra = false;

            foreach(char ch in texto)
            {
                if(char.IsWhiteSpace(ch) || char.IsSeparator(ch) || char.IsPunctuation(ch))
                {
                    enPalabra = false;
                }
                else if(!enPalabra)
                {
                    cantPalabras++;
                    enPalabra = true;
                }
            }
            return cantPalabras;
        }

        /// <summary>
        /// Valida si el caracter ingresado por parametro es o no vocal
        /// </summary>
        /// <param name="c"></param>
        /// <returns> True: Es vocal || False: No es vocal </returns>
        public static bool EsVocal(char c)
        {
            bool esVocal = false;

            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                esVocal = true;
            }

            return esVocal;
        }

        /// <summary>
        /// Se encarga de contar las vocales de una palabra pasada por parametros
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns> Retorna la cantidad de vocales encontradas en la palabra </returns>
        public static int ContarVocales(string palabra) 
        {
            int cantVocales = 0;

            if(palabra != null) 
            {
                palabra = palabra.ToLower();

                foreach(char c in palabra)
                {
                    if(EsVocal(c))
                    {
                        cantVocales += 1;
                    }
                }
            }
            return cantVocales;
        }

        /// <summary>
        /// Se encarga de contar las consonantes de una palabra pasada por parametros
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns> Retorna la cantidad de consonantes de la palabra </returns>
        public static int ContarConsonantes(string palabra)
        {
            int cantConsonantes = 0;

            if (palabra != null)
            {
                palabra = palabra.ToLower();

                foreach (char c in palabra)
                {
                    if(!EsVocal(c) && (!char.IsWhiteSpace(c) && !char.IsSeparator(c) && !char.IsPunctuation(c)))
                    {
                        cantConsonantes += 1;
                    }
                }
            }
            return cantConsonantes;
        }

        /// <summary>
        /// Se encarga de reemplazar de una palabra pasada por parametros los caracteres que coinicidad con la esperada
        /// </summary>
        /// <param name="palabra"></param>
        /// <param name="original"></param>
        /// <param name="nuevo"></param>
        /// <returns> Retorna la nueva palabra con los caracteres cambiados </returns>
        public static string ReemplazarCaracter(string palabra, char original, char nuevo)
        {   
            if(palabra != null)
            { 
                palabra = palabra.Replace(original, nuevo);
            }
            
            return palabra;
        }

        /// <summary>
        /// Se encarga de convertir un numero en formato string a int
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="numeroEntero"></param>
        /// <returns> True: Si se pudo convertir || False: Si no se pudo </returns>
        public static bool ConvertirStringAEntero(string texto, ref int numeroEntero)
        {
            bool sePudo = true;

            if(texto != null) 
            {
                try
                { 
                    numeroEntero = int.Parse(texto);
                }
                catch
                {
                    sePudo = false;
                }    
            }
            return sePudo;
        }

        /// <summary>
        /// Se encarga de guardar una string en un stringbuilder
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns> Retorna el string builder con la palabra guardada </returns>
        public static StringBuilder ConvertirStringASB(string palabra)
        {
            StringBuilder sb = new StringBuilder(palabra);

            return sb;
        }

        /// <summary>
        /// Se encarga de guardar un parrafo en formato string en un stringbuilder
        /// </summary>
        /// <param name="parrafo"></param>
        /// <returns> Retorna el string builder con las frases guardadas y separadas </returns>
        public static StringBuilder ConvertirParrafoASB(string parrafo) 
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder fraseActual = new StringBuilder();

            foreach(char caracter in parrafo)
            {
                fraseActual.Append(caracter);

                if(caracter == '.')
                {
                    sb.AppendLine(fraseActual.ToString().Trim());

                    fraseActual.Clear();
                }
            }

            if (fraseActual.Length > 0)
            {
                sb.AppendLine(fraseActual.ToString().Trim());
            }

            return sb;
        }

        /// <summary>
        /// Se encarga de mostrar un mensaje con su respectivo texto
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="texto"></param>
        public static void MostrarTexto(string mensaje, string texto)
        {
            Console.WriteLine(mensaje + ": " + texto);
        }

        /// <summary>
        /// Se encarga de mostrar un texto que se encuentra en formato string builder
        /// </summary>
        /// <param name="texto"></param>
        public static void MostrarTextoSB(StringBuilder texto)
        {
            Console.WriteLine(texto.ToString());
        }
    }
}
