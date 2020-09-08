using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joe Russo", "cookie");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            
            Console.WriteLine(avengers.Rating);
        }
    }
}
