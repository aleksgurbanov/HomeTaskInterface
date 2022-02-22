using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("istifadeci adi daxil edin");
            string username = Console.ReadLine();
            User username1 = new User();
            username1.FullName = username;

            Console.WriteLine("email daxil edin");
            string email = Console.ReadLine();
            username1.Email = email;


            Console.WriteLine("parolu duzgun daxil edin");
            string pasword = Console.ReadLine();
            username1.PasWordChecker(pasword);
                    

            Console.WriteLine("qeydiyat ola bildinz");

            Console.WriteLine($"{username1.ShowInfo()}");

        }
    }
}
