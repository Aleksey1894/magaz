using System;
using System.Collections.Generic;

public struct HistoryShop
{
    public string description { get; set; }
}
public abstract class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public abstract class AfterShop
{
    public string Responses { get; set; }
    public int Telephone { get; set; }
}

public abstract class Basket
{
    public List<Product> Products { get; set; }
    public decimal TotalPrice { get; set; }

    public abstract void AddProduct(Product product);
}

public struct Stock
{
    public int StockId { get; set; }
    public string StockName { get; set; }
}

// AbstractFactory
public abstract class StoreFactory
{
    public abstract Product CreateProduct();
    public abstract AfterShop CreateAfterShop();
    public abstract Basket CreateBasket();
}

// ConcreteFactory
public class OnlineStoreFactory : StoreFactory
{
    public override Product CreateProduct()
    {
        return new OnlineStoreProduct();
    }

    public override AfterShop CreateAfterShop()
    {
        return new OnlineStoreAfterShop();
    }


    public override Basket CreateBasket()
    {
        return new OnlineStoreBasket();
    }
}

// ConcreteClasses
public class OnlineStoreProduct : Product { }

public class OnlineStoreAfterShop : AfterShop { }

public class OnlineStoreBasket : Basket
{
    public OnlineStoreBasket()
    {
        Products = new List<Product>();
    }
    public override void AddProduct(Product product)
    {
        if (Products == null)
        {
            Products = new List<Product>();
        }

        Products.Add(product);
        TotalPrice += product.Price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        HistoryShop hs = new HistoryShop();
        hs.description = "The store was founded in 2023 and sells goods";
        Console.WriteLine($"About us: {hs.description}");

        StoreFactory onlineStoreFactory = new OnlineStoreFactory();

        Product product1 = onlineStoreFactory.CreateProduct();
        Product product2 = onlineStoreFactory.CreateProduct();

        AfterShop afterShop = onlineStoreFactory.CreateAfterShop();

        Basket basket = onlineStoreFactory.CreateBasket();
        basket.AddProduct(product1);
        basket.AddProduct(product2);

        Console.WriteLine("Order is processed!");

        Stock stockItem = new Stock();
        stockItem.StockId = 1;
        stockItem.StockName = "Sneakers";

        Console.WriteLine($"Stock ID: {stockItem.StockId}, Stock Name: {stockItem.StockName}");
    }
}

