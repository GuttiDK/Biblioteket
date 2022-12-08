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

            Bibliotek biblio = new Bibliotek("Sønderborg Bibliotek");
            Console.WriteLine(biblio.HentBibliotek());



            biblio.OpretLaaner(1, "Egon");
            biblio.OpretLaaner(2, "Phillip");
            biblio.OpretLaaner(3, "Sander");

            Console.WriteLine(biblio.HentLaaner(0));
        
        }

    }

}