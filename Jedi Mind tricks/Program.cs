using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind_tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 1
            Dictionary<string, int> mig = new Dictionary<string, int>(); 

            //Opg 2
            mig.Add("Jesper", 19);

            mig["Han"] = 59;
            mig["Hun"] = 49;

            //Opg 3
            mig.Remove("Han");

            //Opg 4
            foreach (var pair in mig)
            {
                Console.WriteLine($"Found: {pair.Value}, with key: {pair.Key}");
            }

            Console.ReadKey();
        }
    }
}
