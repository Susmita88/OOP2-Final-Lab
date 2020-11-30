using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a2 = new SavingsAccount("Susmita", "1144", 10000);      
            a2.transaction(9580);
            Console.WriteLine();
            a2.transaction(1000); 
            a2.transaction(1000);
            a2.transaction(1000);
            a2.transaction(1000);
            a2.transaction(1000); 

            a2.transaction(1000); 
            a2.ShowInfo();
            Console.WriteLine();


            FixedAccount a4 = new FixedAccount("Susmita", "0838", 2020, 10000);  
            a4.transaction(1000);
            a4.ShowInfo();
            Console.WriteLine();

            SpecialSavingsAccount a1 = new SpecialSavingsAccount("Reyansh", "0233", 2000);       
            SpecialSavingsAccount a7 = new SpecialSavingsAccount("Reyansh", "2900", 1000);

            a1.transaction(400);
            a1.transaction(400);
            a1.transaction(400);
            a1.transaction(400);
            a1.transaction(400);
            a1.transaction(400); 

            a7.transaction(450); 
            a1.ShowInfo();
            a7.ShowInfo();
            Console.WriteLine();


            Account a3 = new OverDraftAccount("Moumita ", "338", 4000);      
            a3.transaction(4550);
            a3.ShowInfo();
            Console.WriteLine();

        }
    }
}