using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instead of declaring this variable outside the try block we can use a using statement
            //StreamReader streamReader = null;

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("David");

                //var calculator = new Calculator();
                //var result = calculator.Divide(5, 0);

                //Using this using statement here we can get rid of the finally block
                //this creates a finally block under the hood essentially
                //using (var streamReader = new StreamReader(@"c:\file.zip"))
                //{
                //    var content = streamReader.ReadToEnd();
                //}

                //streamReader = new StreamReader(@"c:\file.zip");     
            }

            //Catch blocks need to be in order from most specific to most generic, otherwise the more specific catch blocks will never run
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by zero.");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured.\n" + e.Message);
            }

            //finally
            //{
            //    if(streamReader != null)
            //        streamReader.Dispose();
            //}

        }
    }
}
