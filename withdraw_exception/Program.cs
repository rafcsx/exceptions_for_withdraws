using System;
using System.Globalization;
using withdraw_exception.Entities;
using withdraw_exception.Entities.Exceptions;

namespace withdraw_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int num_input = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name_input = Console.ReadLine();

                Console.Write("Initial balance: ");
                double init_bal_input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdraw_limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(num_input, name_input, init_bal_input, withdraw_limit);

                Console.Write("Enter the amount for withdraw: ");
                double withdraw_amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                try
                {
                    acc.Withdraw(withdraw_amount);
                    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
                }
                catch (AccountException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}