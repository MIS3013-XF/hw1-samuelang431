// HW1a Sales Total

// Your Name: Samuel Ang
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productAsString;
            string quantityAsString;
            string priceAsString;

            double quantity;
            double price;
            double subtotal;
            double tax;
            double total;

            const double SalesTaxRate = 0.085;

            Console.WriteLine("What is the product name of the item you are purchasing?: ");
            productAsString = Console.ReadLine();

            Console.WriteLine("How many Football Ticket's do you want to buy? ");
            quantityAsString = Console.ReadLine();

            Console.WriteLine("What is the price for each football ticket? ");
            priceAsString = Console.ReadLine();

            quantity = Convert.ToDouble(quantityAsString);
            price = Convert.ToDouble(priceAsString);

            subtotal = quantity * price;
            tax = subtotal * SalesTaxRate;
            total = subtotal + tax;

            Console.WriteLine("Your subtotal for your bill is " + subtotal);
            Console.WriteLine("Your sales tax for your bill is " + tax);
            Console.WriteLine("Your total for your bill is " + total);

            Console.ReadKey();

        }
    }
}
