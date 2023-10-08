using System;
using System.Collections.Generic;

public class Shop
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
            Receipt receipt = new Receipt(buyer, product, quantityBought);
            receipts.Add(receipt);
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
            Console.WriteLine("Receipt Details:");
            Console.WriteLine(receipt);
            Console.WriteLine();
        }
    }
}

public struct Buyer
{
    private string name;
    private string email;
    public Buyer(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
    public string Name => name;

    public string Email => email;
}

public class Product
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

public class Receipt
{
    public string productName;
    public string buyerName;
    public decimal price;
    public int quantity;
    public Guid purchaseId;
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

class Program
{
    static void Main()
    {
        Shop shop = new Shop();

        Product apple = new Product("Apple", 2.99m, 10);
        shop.AddProduct(apple);

        Buyer buyer = new Buyer("John", "john@i.ua");
        shop.CreateReceipt(buyer, apple, 5);

        shop.PrintReceipts();
    }
}



