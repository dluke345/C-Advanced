using System;
using System.Linq;

//Can change namespace to be System so we don't have to import a bunch of namespaces.
namespace System
{
    //To create an extension method you need to create a static class
    //Only use extension methods only when you really have to, because if Microsoft decided to change the String class this code may not run.
    //You will most likley never be creating extension methods but rather using them.
    public static class StringExtensions
    {
        //methods in an extension class should also be static
        //first argument of these methods should always be (this, type you are extending, and a name)
        public static string Shorten(this String str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be greater than 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}