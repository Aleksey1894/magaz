using magaz;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Shop shop = new Shop();

        Product apple = new Product("Apple", 2.99m, 10);
        Product pear = new Product("Pear", 3.99m, 15);
        Product plum = new Product("Plum", 4.99m, 20);
        Product banana = new Product("Banana", 5.99m, 25);
        Product orange = new Product("Orange", 6.99m, 30);
        shop.AddProduct(apple);
        shop.AddProduct(pear);
        shop.AddProduct(plum);
        shop.AddProduct(banana);
        shop.AddProduct(orange);

        Console.WriteLine();
        Buyer buyer = new Buyer("John", "john@i.ua");
        shop.CreateReceipt(buyer, apple, 9);
        shop.CreateReceipt(buyer, banana, 3);


        shop.Assortment();

        shop.PrintReceipts();
    }
}



