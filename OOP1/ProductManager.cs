using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {                                                                                                   

       public void Add(Product product) //product turunde product
        {
            Console.WriteLine(product.ProductName+ " eklendi.");


        }
        public void Update(Product product) // void emir kipi -guncelle-sil-ekle- seklinde cagirip islem yapma
        {
            Console.WriteLine(product.ProductName+ " guncellendi.");

        }
        public int Addition (int number1, int number2)
        {
            return number1 + number2; //

        }
        public void Addition2 (int number1, int number2)
        {
            Console.WriteLine(number1+number2);

        }
    }
}
