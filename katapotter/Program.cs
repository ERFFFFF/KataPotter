using System;
using Testpotter;

namespace katapotter
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class Program
    {

        public static void Main()
        {
/*            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Debit(11.22);
            Console.WriteLine("il vous reste actuellement {0} € sur votre compte en banque.", ba.Balance);*/
            Cart oui = new Cart();
            oui.ReadList();
        }
    }
}
