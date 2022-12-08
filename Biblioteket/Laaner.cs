using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner
    {

        public int laanerNummer { get; }

        public string navn { get; }

        public Laaner(int laanerNummer, string navn)
        {
            this.laanerNummer = laanerNummer;
            this.navn = navn;
        }

    }

}