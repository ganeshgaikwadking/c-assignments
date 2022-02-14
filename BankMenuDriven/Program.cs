using System;

namespace BankMenuDriven
{
    class bankDetails
    {
        private double balance = 100000;
        public double bal
        {
            get 
            { return balance; }
            set 
            { balance = value; }
        }
    }
    class fuctions
    {
        bankDetails i = new bankDetails();
        string name;
        int accountno,balance;
        double withdraw, dep, total;

        public void openAccount()
        {
            Console.WriteLine("Enter Account No: ");
            int accountno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            balance = Convert.ToInt32(Console.ReadLine());
        }

        

        public void Deposit()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            accountno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            total = i.bal + dep;

       
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + accountno);
            Console.WriteLine("Total Balance amount in the account  : " + total);

        }
        public void withdrawal()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            accountno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= i.bal)
            {
                total = i.bal - withdraw;
 
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + accountno);
                Console.WriteLine("After Withdraw Amount balnace is : " + total);
            }
            else
                Console.WriteLine("Withdraw Ammount does not Exist your Account.");
        }
        public void showAccount()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Account : " + accountno);
            Console.WriteLine("Balance : " + balance);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char agn;
            do
            {
                fuctions fn = new fuctions();
                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("Press 1) for create an Account .\n Press 2) Deposite for Amount. \n press 3) for Withdraw Amount. \n press 4) for Display Account");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        fn.openAccount();
                        break;
                    case 2:
                        fn.Deposit();
                        break;
                    case 3:
                        fn.withdrawal();
                        break;
                    case 4:
                        fn.showAccount();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            Console.ReadKey();
        }
    }
}
