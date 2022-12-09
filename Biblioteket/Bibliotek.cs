using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{

    internal class Bibliotek
    {

        // Options her bliver definet de forskellige værdier
        string _biblioteksNavn;
        int laanNum = 0;
        List<Laaner> laanere = new List<Laaner>();

        // Her henter du biblioteksnavnet og gemmer værdien i en lokal værdi
        public Bibliotek(string navn)
        {
            _biblioteksNavn = navn;
        }

        // Når denne metode bliver brugt returner den en string værdi til brugeren
        public string HentBibliotek()
        {
            return ($"Velkommen til {_biblioteksNavn} - datoen idag er: {DateTime.Now.ToShortDateString()}");
        }

        // Når denne metode bliver brugt returner den en string værdi til brugeren
        public string HentLaaner(int id)
        {
            return ($"Lånernummer: {laanere[id]._laanerNummer} - Navn: {laanere[id]._navn} er låner hos {_biblioteksNavn}");
        }

        // Når denne metode bliver brugt returner den ikke noget men tilføjer en ny laaner
        public void OpretLaaner(string navn, string email)
        {
            laanere.Add(new Laaner(++laanNum, navn, email));
        }

        // Når denne metode bliver brugt returner den en string for hver laaner der er med deres infomationer
        public string HentAlleLaanere()
        {
            string laanereAll = "";
            foreach (Laaner laaner in laanere)
            {
                laanereAll += $"Lånernummer: {laaner._laanerNummer} - Navn: {laaner._navn} | Email: {laaner._email} - Låner hos {_biblioteksNavn}\n";
            }
            return laanereAll;
        }

    }
}
