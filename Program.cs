using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankTrans = new Bank(123456789, 21.00, "deposit");
            bankTrans._location = "Kansas";

            //Console.WriteLine(bankTrans1._location);

            
            
        }
    }
}
