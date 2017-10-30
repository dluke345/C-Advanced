using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Long way
            //Nullable<DateTime> date = null;

            //short way
            //DateTime? date2 = null;

            //Another example
            //DateTime? date3 = new DateTime(2014, 1, 1);
            //DateTime date4 = date3.GetValueOrDefault();
            //Console.WriteLine(date4);

            //DateTime? date5 = date4;
            //Console.WriteLine(date5.GetValueOrDefault());

            //Another example
            DateTime? date = null;
            //The double ?? says if there is a value in date then use it otherwise use todays date
            DateTime date2 = date ?? DateTime.Today;

            //This block of code can be written much shorter
            //DateTime? date = null;
            //DateTime date2;
            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //{
            //    date2 = DateTime.Today;
            //}
            Console.WriteLine(date2);

            ////This will return a default value instead of throwing an exception like .Value does
            //Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            ////This throws an exception because date has no value
            //Console.WriteLine("Value: " + date.Value);

        }
    }
}
