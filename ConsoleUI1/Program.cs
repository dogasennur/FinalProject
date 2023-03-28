// See https://aka.ms/new-console-template for more information
using Bussiness1.Concrete;
using DataAccess1.Concrete.InMemory;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager(new InMemoryProductDal());
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}
