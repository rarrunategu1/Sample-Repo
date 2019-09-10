using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank._location = "Kansas";

            Console.WriteLine(bank._location);

            bank.MakeDeposit();
        }
    }
}
