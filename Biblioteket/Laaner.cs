using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{
    // Her får den kun infomation med forhold til Person.cs
    internal class Laaner : Person
    {
        public int _laanerNummer { get; }

        // Her gemmer du de forskellige værdier i en metode som fx laanerNummer og henter de andre værdier fra Person.cs
        public Laaner(int laanerNummer, string navn, string email) : base(navn, email)
        {
            _laanerNummer = laanerNummer;
        }

    }
}