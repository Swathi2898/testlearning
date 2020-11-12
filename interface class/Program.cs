using System;

namespace interface_class
{
    interface IAccount
    {
        void Deposit();
        void Withdraw();
    }
    public class Saving : IAccount
    {
        public void Deposit()
        {
            Console.WriteLine("Deposit to Saving Account");
        }
        public void Withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account");
        }
    }
    public class Current : IAccount
    {
        public void Deposit()
        {
            Console.WriteLine("Deposit to Current Account");
        }
        public void Withdraw()
        {
            Console.WriteLine("Withdraw from Current Account");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.Deposit();
            s.Withdraw();

            Current c = new Current();
            c.Deposit();
            c.Withdraw();
        }
    }
}
