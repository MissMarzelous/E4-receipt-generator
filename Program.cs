using System;

namespace AdvancedReceiptGenerator
{
    class Program
    {
        private const double TaxRate       = 0.08;
        private const int    MaxItems      = 50;
        private const string Divider       = "==============================";
        private const string ThinDivider   = "------------------------------";

        static void Main(string[] args)
        {
            Console.WriteLine(Divider);
            Console.WriteLine("     GROCERY RECEIPT ENTRY");
            Console.WriteLine(Divider);

            int itemCount = ReadItemCount();

            string[] itemNames  = new string[itemCount];
            double[] itemPrices = new double[itemCount];

            CollectItems(itemCount, itemNames, itemPrices);

            double subtotal  = CalculateSubtotal(itemPrices, itemCount);
            double taxAmount = subtotal * TaxRate;
            double total     = subtotal + taxAmount;

            double cashPaid = ReadPayment(total);
            double change   = cashPaid - total;

            PrintReceipt(itemNames, itemPrices, itemCount,
                         subtotal, taxAmount, total, cashPaid, change);
        }

        /// <summary>
        /// Prompts for and validates the number of items (1 to MaxItems).
        /// </summary>
        static int ReadItemCount()
        {
            while (true)
            {
                Console.Write($"How many items? (1–{MaxItems}): ");
                if (int.TryParse(Console.ReadLine(), out int count)
                    && count >= 1 && count <= MaxItems)
                    return count;

                Console.WriteLine($"⚠ Please enter a whole number between 1 and {MaxItems}.");
            }
        }

        /// <summary>
        /// Collects item names and prices from the user into parallel arrays.
        /// </summary>
        static void CollectItems(int count, string[] names, double[] prices)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Item {i + 1} ---");

                // Validate item name
                string name;
                do
                {
                    Console.Write("  Item name: ");
                    name = Console.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(name))
                        Console.WriteLine("  ⚠ Name cannot be empty.");
                } while (string.IsNullOrEmpty(name));

                names[i] = name;

                // Validate item price
                while (true)
                {
                    Console.Write("  Price ($): ");
                    if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
                    {
                        prices[i] = price;
                        break;
                    }
                    Console.WriteLine("  ⚠ Please enter a valid non-negative price.");
                }
            }
        }

        /// <summary>
        /// Sums all prices in the array to produce the subtotal.
        /// </summary>
        static double CalculateSubtotal(double[] prices, int count)
        {
            double subtotal = 0;
            for (int i = 0; i < count; i++)
                subtotal += prices[i];
            return subtotal;
        }

        /// <summary>
        /// Prompts for a payment amount that covers the total.
        /// </summary>
        static double ReadPayment(double totalDue)
        {
            while (true)
            {
                Console.Write($"\nEnter cash payment (minimum {totalDue:C}): $");
                if (double.TryParse(Console.ReadLine(), out double payment)
                    && payment >= totalDue)
                    return payment;

                Console.WriteLine($"⚠ Payment must be at least {totalDue:C}.");
            }
        }

        /// <summary>
        /// Prints the formatted grocery receipt.
        /// </summary>
        static void PrintReceipt(
            string[] names, double[] prices, int count,
            double subtotal, double tax, double total,
            double cashPaid, double change)
        {
            Console.WriteLine("\n" + Divider);
            Console.WriteLine("       GROCERY RECEIPT");
            Console.WriteLine(Divider);

            for (int i = 0; i < count; i++)
                Console.WriteLine($"{names[i],-24}{prices[i],6:C}");

            Console.WriteLine(ThinDivider);
            Console.WriteLine($"{"Subtotal:",-24}{subtotal,6:C}");
            Console.WriteLine($"{"Tax (8%):",-24}{tax,6:C}");
            Console.WriteLine(Divider);
            Console.WriteLine($"{"TOTAL:",-24}{total,6:C}");
            Console.WriteLine(ThinDivider);
            Console.WriteLine($"{"Cash Paid:",-24}{cashPaid,6:C}");
            Console.WriteLine($"{"CHANGE:",-24}{change,6:C}");
            Console.WriteLine(Divider);
        }
    }
}
