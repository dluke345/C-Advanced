using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Linq Query Operators - always start with from and end with select
            //var cheaperBooks = 
            //    from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b;

            //Using linq it takes 1 line of code instead, can also chain this expressions .Where.OrderBy
            //Linq extension methods - this syntax is more powerful, but depends

            var sumPrices = books.Sum(b => b.Price);
            Console.WriteLine(sumPrices);

            //var minPrice = books.Min(b => b.Price);
            //Console.WriteLine(minPrice);

            //var maxPrice = books.Max(b => b.Price);
            //Console.WriteLine(maxPrice);

            //var count = books.Count();
            //Console.WriteLine(count);

            //var pagedBooks = books.Skip(2).Take(3);
            //foreach (var pagedBook in pagedBooks)
            //{
            //    Console.WriteLine(pagedBook.Title);
            //}

            //var book = books.First(b => b.Title == "C# Advanced Topics");
            //Console.WriteLine(book.Title + " " + book.Price);

            //var book = books.SingleOrDefault(b => b.Title == "ASP.Net MVC++");
            //Console.WriteLine(book.Title);


            //var cheapBooks = books
            //    .Where(b => b.Price < 10)
            //    .OrderBy(b => b.Title)
            //    .Select(b => b.Title);


            //Without Linq this is what we would have to do
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //foreach (var cheapBook in cheapBooks)
            //{
            //    //Console.WriteLine(cheapBook.Title + " " + cheapBook.Price);
            //    Console.WriteLine(cheapBook);
            //}
        }
    }
}
