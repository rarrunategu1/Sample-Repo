using System;

namespace Hello_World{

  public class Bank{

    public long _acctNumber{get;}
    
    public string _location {get; set;}

    public Bank(long acctNumber)
    {
      this._acctNumber = acctNumber;
    }
    public void MakeDeposit()
    {
      Console.WriteLine("Your deposit transaction has been completed to account number {0}.", _acctNumber);
    }

  }

}