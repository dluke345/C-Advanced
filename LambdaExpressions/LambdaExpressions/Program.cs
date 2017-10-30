using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Example 3:
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title);
            }

            // args => expression
            //number => number * number;

            // () => ...
            // x => ...
            // (x, y, x) => ...

            //Example 2: 
            //const int factor = 5;
            //Func<int, int> multipler = n => n * factor;
            //var result = multipler(10);
            //Console.WriteLine(result);


            //Example 1: 

            //Func<int, int> square = number => number*number;
            //Console.WriteLine(square(5));
        }

        //Don't need this method with Lambda Expression above
        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}

        //Don't need this method with Lambda Expression above
        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
