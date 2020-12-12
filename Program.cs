using System;
using System.Collections.Generic;

namespace openlab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Book Johns = new Book(100, "Johnsons book", "John", "Comedy", 2020);
            Book Pauls = new Book(150, "Pauls book", "Paul", "Sci-fi", 2021);      
            List<string> students = new List<string>() { "John","Paul" };
            List<Book> books = new List<Book>(){ Johns, Pauls };
            Library schoolLibrary = new Library();
            schoolLibrary.Listing();





        }
    }
}
