﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Program
    {
        public static void Main()
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg bibliotek");
            Console.WriteLine(bibliotek.HentBibliotek());
        }
    }
}