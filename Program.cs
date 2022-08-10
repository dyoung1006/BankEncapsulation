namespace BankEncapsulation
{
    #region  Instructions
    //Create a new Console Application in your repos folder
    //name it BankEncapsulation
    //Create a new public class named BankAccount -- x
    //In your BankAccount class, create the following:
    //A private field of type double named balance with a value of 0 -- x
    //Define a method named Deposit that will accept a double and store that value in the balance field  --x
    //Define a method named GetBalance that will return the amount stored in the balance field --x
    //In the main method of your application, create a new instance of the BankAccount class.  Allow the user of the application to Deposit money and retrieve their balance through the console.
    #endregion
   internal class Program
   {

        public class BankAccount
        {
            private double Balance { get; set; } = 0;
            public void Deposit(double amount) => Balance += amount;

            public BankAccount()
            {
            }
            public void GetBalance() => Console.WriteLine($"Your balance is: {Balance:c2}");
        }
    
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            myAccount.Deposit(300);
            myAccount.GetBalance();
        }
    }
}