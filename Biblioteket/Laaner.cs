using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{

    internal class Laaner : Person
    {
        public int _laanerNummer { get; }

        public Laaner(int laanerNummer, string navn, string email) : base(navn, email)
        {
            _laanerNummer = laanerNummer;

        }

    }
}