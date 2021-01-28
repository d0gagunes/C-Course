using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { ID=2, CategoryID=5, UnitInStock=5, ProductName="Kalem", UnitPrice=35 };
            //PascalCase(ilk harfler buyuk) //camelCase (ilk harf kucuk diger kelimenin ilk harfi  buyuk
            ProductManager productManager= new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Addition2(3, 6);

            int additionTotal = productManager.Addition(3, 6);
            Console.WriteLine(additionTotal*2);


            
        }
    }
}
