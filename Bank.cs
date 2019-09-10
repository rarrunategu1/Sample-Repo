using System;

namespace Hello_World{

  public class Bank
  {
    //Private Member Variable
    private double withdrawalAmount;
    public double bankFee = 3.00;
    private double balance = 25.00;

    public double WithdrawalAmount
    {
      get
      {
        return withdrawalAmount;
      }
      set
      {
        withdrawalAmount = value;
      }
    }

    //Read only Auto-Implemented Property
    public long _acctNumber{get;}
    
    //Member variable
    public string _location {get; set;}

    //Constructor 
    public Bank(long acctNumber)
    {
      this._acctNumber = acctNumber;
    }
    public Bank(double withdrawalamount)
    {
      this.WithdrawalAmount = withdrawalamount;
    }
    
    //Method
    public void MakeDeposit()
    {
      Console.WriteLine("Your deposit transaction has been completed to account number {0}.", _acctNumber);
    }

    public void MakeWithdrawal()
    {
      double precalculatedBalance = balance - withdrawalAmount - bankFee;

      if (precalculatedBalance >= 0)
      {
        Console.WriteLine("Your current balance is ${0:0.00}.  There is a fee of ${1:0.00} for your withdrawal.  Your balance after your withdrawal of ${2:0.00} is ${3:0.00}.", balance, bankFee, withdrawalAmount, (balance - withdrawalAmount- bankFee));
      }
      else
      {
        Console.WriteLine("Your current balance is ${0:0.00}.  There is a fee of ${1:0.00} for your withdrawal.  Your balance after your withdrawal of ${2:0.00} is ${3:0.00}.  You have insufficient funds to make your withdrawal.", balance, bankFee, withdrawalAmount, (balance - withdrawalAmount - bankFee));
      }
    }

  }

}