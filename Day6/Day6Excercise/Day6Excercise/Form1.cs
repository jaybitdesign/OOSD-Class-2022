namespace Day6Excercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Account
    {
        private static readonly Random rand = new Random();

        public int AccountNumber = 0;

        public decimal Balance { set; get; }

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
            AccountNumber = rand.Next();
            if(initialBalance < 0)
            {
                Balance = 0;
            } 
            else
            {
                Balance = initialBalance;
            }
        }

        public Account()
        {
        }

        public bool Deposit(decimal depositAmount)
        {
            if (depositAmount > 0)
            {
                Balance += depositAmount;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > 0 && withdrawAmount <= Balance)
            {
                Balance -= withdrawAmount;
                return true;
            }
            return false;
        }
    }
}