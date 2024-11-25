using System;
public class BankAccount
{
   string Name;
   double Balance;
   
   public string name
   {
    get{return Name;}
    set{Name=value;}
   }
   public double balance{
    get{return Balance;}
    set{Balance=value;}
   }
   public BankAccount(string _name,double  _balance)
   {
    this.name = _name;
    this.balance = _balance;
   }
}
class Bank
{
    static void Main()
    {
       
        BankAccount b1 = new BankAccount("Nusrat", 1000);


        BankAccount b2 = new BankAccount(b1.name, b1.balance);
        BankAccount b3 = new BankAccount(b1.name, b1.balance);


        b2.balance = 500;


        Console.WriteLine("acc1 Balance: " + b1.balance);  // Should be 1000
        Console.WriteLine("acc2 Balance: " + b2.balance);  // Should be 500
        Console.WriteLine("acc3 Balance: " + b3.balance);  // Should be 1000
    }
}
