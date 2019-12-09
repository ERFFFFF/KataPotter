using System;
using System.Collections.Generic;
using System.Text;

namespace katapotter
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                Console.WriteLine("Vous ne pouvez pas retirez, vous n'avez pas assez d'argent sur votre compte.");
            }

            if (amount < m_balance)
            {
                Console.WriteLine("Vous avez retiré {0} €", amount);
                m_balance = m_balance - amount;
            }

        }
    }
}
