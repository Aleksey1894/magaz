using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Product
    {
        private string name;
        private decimal price;
        private int quantity;

        public Product(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string Name => name;
        public decimal Price => price;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Name}, costs only{Price:C2}, we've got {Quantity} left";
        }
    }
}
