using System;

namespace Ahorcado
{
    class Program
    {

        static void Main(string[] args)
        {            
            static void Mostrar(string s)
            {
                Console.WriteLine(s);
            }

            int intentos = 10;
            string []palabras = { "gota", "ropero", "fuente", "pendulo", "mermelada", "jarro", "almohadilla", "cinturon", "bala", "oro" };
            Mostrar("Juego el ahorcado, tiene "+ intentos + " intentos");

            var azar = new Random();
            int indice =  azar.Next(0, 9);
            string palabra = palabras[indice];
            string jugada = "";
            for (int i = 0; i < palabra.Length; i++)
            {              
                jugada += '_';
            }

            //Mostrar(palabra);            

            while (intentos > 0 && palabra != jugada)
            {
                Mostrar(jugada + ", " + intentos + " intentos restantes");
                string ingreso = Console.ReadLine().Trim();

                if (ingreso == palabra) 
                {
                    jugada = palabra;
                    break;
                }
                else if (!string.IsNullOrWhiteSpace(ingreso))
                {
                    string letras = ingreso.Substring(0, 1);
                    char letra = letras[0];
                    char[] letras_palabra = palabra.ToCharArray();
                    char[] letras_jugada = jugada.ToCharArray();
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (letras_palabra[i] == letra)
                        {
                            letras_jugada[i] = letras_palabra[i];
                        }
                    }
                    jugada = new string(letras_jugada);
                    intentos--;
                }                
            }

            Mostrar(jugada);
            Mostrar("Juego terminado");
            if (jugada == palabra)
            {
                Mostrar("Ganaste");
            }
            else 
            {
                Mostrar("Se acabaron los intentos :(");
            }
        }
    }
}
