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

        public string biblioteksNavn { get; init; }

        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;
        }

        public string HentBibliotek()
        {
            return ($"Velkommen til {biblioteksNavn} - datoen idag er: {DateTime.Now.ToShortDateString()}");
        }

    }
}
