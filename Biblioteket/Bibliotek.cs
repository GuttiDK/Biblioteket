using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{

    class Bibliotek
    {

        List<Laaner> laanere = new List<Laaner>();
        public string biblioteksNavn { get; init; }
        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;
        }

        public string HentBibliotek()
        {
            return ($"Velkommen til {biblioteksNavn} - datoen idag er: {DateTime.Now.ToShortDateString()}");
        }

        public void OpretLaaner(int laanerNummer, string navn)
        {
            laanere.Add(new Laaner(laanerNummer, navn));
        }

        public string HentLaaner(int id)
        {
            return ($"Lånernummer: {laanere[id].laanerNummer} - Navn: {laanere[id].navn} er låner hos {biblioteksNavn}");
        }


    }
}
