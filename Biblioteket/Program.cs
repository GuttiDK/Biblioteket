using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Biblioteket;

namespace Biblioteket
{

    class Program
    {

        public static void Main(string[] args)
        {
            // Options
            bool boolean = true;
            string loading = "Loading...";

            // Sætter biblio navnet
            Bibliotek biblio = new Bibliotek("Sønderborg Bibliotek");

            // While loop til at boolean er false
            while (boolean == true)
            {
                // Menu
                Console.Clear();
                Console.WriteLine("+ - - - - - - - - - - - - - - - - +");
                Console.WriteLine("v: Vis bibliotekets navn og dato");
                Console.WriteLine("o: Opret låner");
                Console.WriteLine("u: Udskriv lånere");
                Console.WriteLine("x: Afslut");
                Console.WriteLine("+ - - - - - - - - - - - - - - - - +");
                Console.Write("Du kan vælge følgende: ");

                string input = Console.ReadLine();
                
                // Input valg ud fra menu
                if (input == "v")
                {
                    Console.Clear();
                    Console.WriteLine(biblio.HentBibliotek());
                    Console.Write($"{loading}");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                if (input == "o")
                {
                    Console.Clear();
                    Console.Write("Indtast venligt lånerenes navn: ");
                    string navn = Console.ReadLine();
                    Console.Write("Indtast email: ");
                    biblio.OpretLaaner(navn, Console.ReadLine());
                    Console.Write($"{loading}");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (input == "u")
                {
                    Console.Clear();
                    Console.WriteLine(biblio.HentAlleLaanere());
                    Console.Write($"{loading}");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                if (input == "x")
                {
                    boolean = false;
                }

            }
        }
    }
}