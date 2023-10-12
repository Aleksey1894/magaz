using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Shop
    {
        private List<Product> products;
        private List<Receipt> receipts;

        public Shop()
        {
            products = new List<Product>();
            receipts = new List<Receipt>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void CreateReceipt(Buyer buyer, Product product, int quantityBought)
        {
            if (products.Contains(product))
            {
                if (product.Quantity >= quantityBought)
                {
                    Receipt receipt = new Receipt(buyer, product, quantityBought);
                    receipts.Add(receipt);
                    product.Quantity -= quantityBought;
                }
                else
                {
                    Console.WriteLine("This quantity of goods is not available in the shop");
                }
            }
            else
            {
                Console.WriteLine("Product not found in the shop.");
            }
        }

        public void PrintReceipts()
        {
            foreach (var receipt in receipts)
            {
                Console.WriteLine("\nReceipt Details:");
                Console.WriteLine(receipt);
                Console.WriteLine();
            }
        }
        public void Assortment()
        {
            Console.WriteLine("Assortment of products in the shop:\n");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - price: {product.Price}, quantity: {product.Quantity}");
            }
        }
    }
}
