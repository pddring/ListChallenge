using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Will 1", "Will 2", "Ethan"};
            names.Add("Tom");

            Console.WriteLine(names[3]);
        }
    }
}
