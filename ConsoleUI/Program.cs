using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

    // SOLID
    // Open Closed Principle

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetByUnitPrice(20,200))
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("Hello, World!");
    }
}