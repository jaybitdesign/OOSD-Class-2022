namespace ProgrammingDemoDay5
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

        public double Balance { set; get; }

        public Account(double initialBalance)
        {
            Balance = initialBalance;
            AccountNumber = rand.Next();
        }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        public void Withdraw(double withdrawAmount)
        {
            Balance -= withdrawAmount;
        }
    }
}