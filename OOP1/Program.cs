using OOP1;

Product product0 = new Product();
product0.Id = 1;
product0.CategoryId = 2;
product0.ProductName = "Table";
product0.UnitPrice = 250;
product0.UnitsInStock = 10;
Product product1 = new Product { Id = 2, CategoryId = 5, ProductName = "Pencil", UnitPrice = 10, UnitsInStock = 25 };

// Instance Creation
ProductManager productManager = new ProductManager();
productManager.Add(product0);
Console.WriteLine(product0.ProductName);
Console.WriteLine(product0.UnitPrice);

int sayi = 99;
productManager.DoSometh(sayi);
Console.WriteLine(sayi);



// int, double, bool ... value type
// arrays, class, abstract class, interface ... reference type

