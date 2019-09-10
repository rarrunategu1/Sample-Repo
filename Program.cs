using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankTrans1 = new Bank(123456789);
            Bank bankTrans2 = new Bank(21.00);
            bankTrans1._location = "Kansas";

            Console.WriteLine(bankTrans1._location);

            bankTrans1.MakeDeposit();
            bankTrans2.MakeWithdrawal();
            bankTrans2.MakeWithdrawal();
        }
    }
}
