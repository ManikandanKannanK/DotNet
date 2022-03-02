using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    internal class Program
    {
        static string productName;
        static int price;
        static int discountRate;
        static int qtyPurchased;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name");
            productName = Console.ReadLine();

            Console.WriteLine("\nEnter the product Price");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nenter the DiscountRate");
            discountRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Qty of the Product");
            qtyPurchased = Convert.ToInt32(Console.ReadLine());

            int GrossValue = price * qtyPurchased;
            Console.WriteLine("\nGross value :" + GrossValue);

            int DiscountAmount = GrossValue * 20 / 100;
            Console.WriteLine("\nDiscount Amount :" + DiscountAmount);

            int pay = GrossValue - DiscountAmount;

            Console.WriteLine("\npayable Amount :" + pay);

            Console.ReadKey();

        }
    }
}
