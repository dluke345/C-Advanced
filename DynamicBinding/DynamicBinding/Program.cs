using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using reflection which was the older way of doing things would like this
            //object obj = "David";
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);


            //This is the dynamic way of doing it which is shorter and cleaner
            //dynamic excelObject = "David";
            //excelObject.Optimize();

            //Another example:
            //dynamic name = "David";
            //name = 30;

            //Another example:
            //dynamic a = 10;
            //dynamic b = 5;
            ////This variable becomes dynamic because it's using 2 dynamic types
            //var c = a + b;

            //Another example:
            int i = 5;
            dynamic d = i;
        }
    }
}
