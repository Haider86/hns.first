using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your Name: ");
            int nam = Console.ReadLine();
            Console.Write("enter your password:  ");
            int pass = Console.ReadLine();


            
            if (nam == "haider" || pass == "1234")
            {
                Console.Write("Welcome " + nam);

            }
            else
            {
                Console.WriteLine("your password or user name is not currecct please try agean: ");
            }
        }
    }
}