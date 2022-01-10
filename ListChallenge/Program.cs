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
            Random rnd = new Random();
            
            List<string> names = new List<string> { "Will 1", "Will 2", "Ethan", "Adam", "Cormac", "Tom", "Ben", "Henry", "Mr. Dring", "Ashton", "Ethan"};
            List<int> score = new List<int> {  };
            for (int i = 0; i < names.Count(); i++)
            {
                score.Add(rnd.Next(100));
                Console.WriteLine(names[i] +" "+score[i]);
            }
            Console.ReadLine();
        }
    }
}
