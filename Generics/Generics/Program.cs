using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());


            //var dictionary = new GenericDictionary<string, int>();
            //dictionary.Add("11111", 11111);
        }
    }
}
