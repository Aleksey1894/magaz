using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Receipt
    {
        public string productName;
        public string buyerName;
        public decimal price;
        public int quantity;    
        public DateTime purchaseTime;

        public Receipt(Buyer bayer, Product product, int quantityBoungth)
        {
            purchaseTime = DateTime.Now;
            productName = product.Name;
            price = product.Price;
            quantity = quantityBoungth;
            buyerName = bayer.Name;
        }
        public override string ToString()
        {
            return $"**Receipt**\n" +
                   $"Buyer: {buyerName}\n" +
                   $"Product: {productName}\n" +
                   $"Quantity: {quantity}\n" +
                   $"Price: {price}\n" +
                   $"Total: {price * quantity}\n" +
                   $"PurchaseTime: {purchaseTime}";
        }

        internal decimal CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}
