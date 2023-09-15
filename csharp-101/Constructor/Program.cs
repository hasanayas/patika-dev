using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****Product One****");
        Product productOne = new Product("Laptop", 1500, "Electronics");
        productOne.GetProductInfo();

        Console.WriteLine("************");

        Console.WriteLine("****Product Two****");
        Product productTwo = new Product();
        productTwo.Name = "Book";
        productTwo.Price = 20;
        productTwo.Category = "Books";

        productTwo.GetProductInfo();

        Console.WriteLine("****Product Three****");
        Product productThree = new Product("Headphones", 100, "Electronics");
        productThree.GetProductInfo();
    }
}

class Product
{
    public string Name;
    public double Price;
    public string Category;

    public Product(string name, double price, string category)
    {
        this.Name = name;
        this.Price = price;
        this.Category = category;
    }

    public Product() { }

    public void GetProductInfo()
    {
        Console.WriteLine("Product Name: {0}", Name);
        Console.WriteLine("Price: ${0}", Price);
        Console.WriteLine("Category: {0}", Category);
    }
}
