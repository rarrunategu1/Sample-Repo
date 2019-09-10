using System;

namespace Hello_World{

  public class Bank
  {
    //Read only Auto-Implemented Property
    public long _acctNumber{get;}
    
    //Member variable
    public string _location {get; set;}

    //Constructor 
    public Bank(long acctNumber)
    {
      this._acctNumber = acctNumber;
    }
    //Method
    public void MakeDeposit()
    {
      Console.WriteLine("Your deposit transaction has been completed to account number {0}.", _acctNumber);
    }

  }

}