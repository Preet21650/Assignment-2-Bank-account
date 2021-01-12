using System;

namespace Assignment_2_Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Preet = new Account("Preet", 100);
            Console.WriteLine(Preet.AddInterest(1.05));
        
        }
    }
}
