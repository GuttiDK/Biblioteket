using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Person
    {

        public string _navn { get; }
        public string _email { get; set; }

        public Person(string navn, string email)
        {
            _navn = navn;
            _email = email;
        }

    }

}