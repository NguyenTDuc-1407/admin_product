ProductManager productManager = new ProductManager();
productManager.updateById(2, new Product(2, "Samsung A300", 270));
Product? product = productManager.findById(5);
if (product != null)
{
    Console.WriteLine(product.ProId);
    Console.WriteLine(product.ProName);
    Console.WriteLine(product.ProPrice);
}
Product[]? products = productManager.loadProduct();
if (products != null)
{
    foreach (Product product2 in products)
    {
        Console.WriteLine("ProId: " + product.ProId);
        Console.WriteLine("ProName: " + product.ProName);
        Console.WriteLine("ProPrice: " + product.ProPrice);
        Console.WriteLine("-------------------");
    }
}
Product product1 = new Product(10, "Samsung Galaxy S24", 2300);
productManager.insertProduct(product);
Console.ReadLine();