using System;
using System.Text.RegularExpressions;

namespace Exam4
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] aMnt = new int[100];
            int cnT = -1, number;
            string[] iTnm = new string[100];
            string iNNie;
            

            Console.WriteLine("==========================GROCERY RECEIPT================================");
            Console.WriteLine("");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("");
            Console.WriteLine("Please enter the name of the item(enter 0 to stop): ");
            Console.WriteLine("");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("");

            float pRcNum, subtotal = 0;
            float[] cost = new float[100];
            bool ckh = false; //check 

            iNNie = Console.ReadLine();
            if (!Regex.IsMatch(iNNie, @"a-zA-Z0-9&().-_*"))
            {
                ckh = true;
            }
            else
            {
                ckh = false;
            }

            while (ckh == false)
            {
                Console.WriteLine("Please enter a valid name for the item.");
                iNNie = Console.ReadLine();
                if (!Regex.IsMatch(iNNie, @"a-zA-Z0-9&().-_* "))
                {
                    ckh = true;
                }
                else
                {
                    ckh = false;
                }
            }


                Console.WriteLine("=========================================================================");
                Console.WriteLine("");
                Console.WriteLine("What is the quantity of this item?: ");
                Console.WriteLine("");
                Console.WriteLine("=========================================================================");
                while (!int.TryParse(Console.ReadLine(), out number)) //accept only numbers
                {
                    Console.WriteLine("!Enter only number 0-9 please!");
                    Console.WriteLine("What is the quantity of this item?: ");
                }

                do
                {
                    cnT++;
                    iTnm[cnT] = iNNie;
                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("");
                    Console.WriteLine("What is the price of this item?: ");
                    Console.WriteLine("");
                    Console.WriteLine("=========================================================================");
                    while (!float.TryParse(Console.ReadLine(), out pRcNum)) //accept only numbers
                    {
                        Console.WriteLine("!Enter only number 0-9 please!");
                        Console.WriteLine("What is the price of this item?: ");
                    }

                    
                Console.WriteLine("=========================================================================");
                Console.WriteLine("");
                Console.WriteLine("What is the name of the item?(enter 0 to stop): ");
                Console.WriteLine("");
                Console.WriteLine("=========================================================================");
                cost[cnT] = pRcNum;
                aMnt[cnT] = number;
                subtotal += cost[cnT] * aMnt[cnT];
                iNNie = Console.ReadLine();
               
                if (!Regex.IsMatch(iNNie, @"a-zA-Z0-9&().-_* "))
                {
                    ckh = true;
                }
                else
                {
                    ckh = false;
                }

                while (ckh == false)
                {
                    Console.WriteLine("Please enter a valid name for the item.");
                    iNNie = Console.ReadLine();

                    if (!Regex.IsMatch(iNNie, @"a-zA-Z0-9&().-_* "))
                    {
                        ckh = true;
                    }
                    else
                    {
                        ckh = false;
                    }
                }

            }
            while (!iNNie.Equals("0"));

            Console.WriteLine("=========================================================================");
            Console.WriteLine("");
            Console.WriteLine("Item\t\tPrice\t\tQuantity\t\tSub Total");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------");
            for (int i = 0; i <= cnT; i++)
            {

                Console.WriteLine(iTnm[i] + "\t\t" + cost[i] + "\t\t" + aMnt[i] + "\t\t\t" + (cost[i] * aMnt[i]));

            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Subtotal Amount: \t" + subtotal);
            Console.WriteLine("Accumulated Tax (0.065%): \t" + Math.Round(subtotal * 0.065, 2));
            Console.WriteLine("Total Cost: \t" + Math.Round(subtotal + (subtotal * 0.065), 2));
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();

            // END PROGRAM
        }
    }
}