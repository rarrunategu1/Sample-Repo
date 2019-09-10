using System;

namespace Hello_World{

  public class Bank
  {
    //Private Member Variable
    private double depositAmount;
    private double withdrawalAmount;
    public double bankFee = 3.00;
    private double balance = 0.00;

    //Read only Auto-Implemented Property
    private long _acctNumber = 123456789;
    
    //Member variable
    public string _location {get; set;}
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
    public double DepositAmount
    {
      get
      {
        return depositAmount; 
      }
      set
      {
        depositAmount = value;
      }
    }

    //Constructor 
    public Bank(long acctNumber, double transactionamount, string transactiontype)
    {
      if (this._acctNumber == acctNumber && transactiontype == "withdrawal")
      {
        this.WithdrawalAmount = transactionamount;
        Console.WriteLine("We're happy to assist you with your withdrawal!");
        MakeWithdrawal();
      }
      else if (this._acctNumber == acctNumber && transactiontype == "deposit")
      {
        this.depositAmount = transactionamount;
        Console.WriteLine("We're happy to assist you with your deposit!");
        MakeDeposit();
      }
      if (this._acctNumber != acctNumber)
      {
        Console.WriteLine("Sorry that is an incorrect account number.");
      }
      //require transaction type here
    }
    
    
    //Method
    public void MakeDeposit()
    {
      balance += depositAmount;
      Console.WriteLine("Your deposit transaction has been made to account number {0}.  Your new balance is ${1:0.00}", _acctNumber, balance);
    }

    public void MakeWithdrawal()
    {
      double precalculatedBalance = balance - withdrawalAmount - bankFee;

      if (precalculatedBalance >= 0)
      {
        Console.WriteLine("Your current balance is ${0:0.00}.  There is a fee of ${1:0.00} for your withdrawal.  Your balance after your withdrawal of ${2:0.00} is ${3:0.00}.", balance, bankFee, withdrawalAmount, (balance - withdrawalAmount- bankFee));

        balance = balance - withdrawalAmount - bankFee;
      }
      else
      {
        Console.WriteLine("Your current balance is ${0:0.00}.  There is a fee of ${1:0.00} for your withdrawal.  Your balance after your withdrawal of ${2:0.00} is ${3:0.00}.  You have insufficient funds to make your withdrawal.", balance, bankFee, withdrawalAmount, (balance - withdrawalAmount - bankFee));
      }
    }

  }

}