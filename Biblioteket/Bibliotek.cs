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


        string _biblioteksNavn;
        int laanNum = 0;
        List<Laaner> laanere = new List<Laaner>();


        public Bibliotek(string navn)
        {
            _biblioteksNavn = navn;
        }

        public string HentBibliotek()
        {
            return ($"Velkommen til {_biblioteksNavn} - datoen idag er: {DateTime.Now.ToShortDateString()}");
        }


        public string HentLaaner(int id)
        {
            return ($"Lånernummer: {laanere[id]._laanerNummer} - Navn: {laanere[id]._navn} er låner hos {_biblioteksNavn}");
        }

        public void OpretLaaner(string navn)
        {
            laanere.Add(new Laaner(laanNum++, navn));
        }


        public string HentAlleLaanere()
        {
            string laanereAll = "";
            foreach (Laaner laaner in laanere)
            {
                laanereAll += $"Lånernummer: {laaner._laanerNummer} - Navn: {laaner._navn} er låner hos {_biblioteksNavn}";
            }
            return laanereAll;
        }

    }
}
