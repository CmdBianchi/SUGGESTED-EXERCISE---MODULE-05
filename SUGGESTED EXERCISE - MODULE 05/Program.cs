using System;
namespace SUGGESTED_EXERCISE___MODULE_05 {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            BankAccount bankAccount;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();
            Console.Write("Haverá depósito inicial SIM ou NÃO ? (s/n)");
            char answer = char.Parse(Console.ReadLine());

            if(answer == 's' || answer == 'S') {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                double initialdeposit = double.Parse(Console.ReadLine());
                bankAccount = new BankAccount(number, holder, initialdeposit);
            }
            else {
                bankAccount = new BankAccount(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(bankAccount);

            Console.WriteLine();
            Console.Write("Entre um valorr para depósito: ");
            double amount = double.Parse(Console.ReadLine());
            bankAccount.Deposit(amount);
            Console.WriteLine("Dados da conta att: ");
            Console.WriteLine(bankAccount);
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
