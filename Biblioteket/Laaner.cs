using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{

    internal class Laaner
    {

        public int _laanerNummer { get; }
        public string _navn { get; }

        public Laaner(int laanerNummer, string navn)
        {
            _laanerNummer = laanerNummer;
            _navn = navn;
        }

    }

}