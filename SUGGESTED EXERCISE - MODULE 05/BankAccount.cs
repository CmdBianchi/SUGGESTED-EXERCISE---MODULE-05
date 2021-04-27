using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SUGGESTED_EXERCISE___MODULE_05{
    //------------------------------- START -------------------------------//
    class BankAccount {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        //------------------------- CONSTRUCTORS ------------------------- //
        public BankAccount(int number, string holder) {
            Number = number;
            Holder = holder;
        }
        public BankAccount(int number, string holder, double balance) : this(number, holder) {
            Balance = balance;
        }
        //------------------------- CLASS |  MET --------------------------//
        public void Deposit(double deposit) {
            Balance += deposit;
        }
        public void Withdraw(double deposit) {
            Balance -= deposit + 5.0;
        }
        public override string ToString() {
            return "Conta "
            + Number + ", Titular: " + Holder + ", Saldo: $" + Balance.ToString("F2");
        }       
    }
    //-------------------------------- END -------------------------------//
}
