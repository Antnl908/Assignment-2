using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class BankAccount
    {
        private double balance;
        private Security security;

        public int numberOfTransations;

        public BankAccount(double balance)
        {
            this.balance = balance;
            security = new Security();
            numberOfTransations = 0;
        }

        public void Transaction(double amount, int clientId)
        {
            security.MakePreTransactionStamp(clientId, balance);
            balance += amount;
            numberOfTransations++;
            security.MakePostTransactionStamp(clientId, balance);
            security.VerifyLastTransaction(amount);
        }
    }
}
