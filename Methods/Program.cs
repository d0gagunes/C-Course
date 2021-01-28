using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //string urunAdi = "Elma";
            //double fiyat = 10;   DUZENSIZ BIR GOSTERIM DIZI KULLANMAK DAHA MANTIKLI
            //string aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] { "Elma" , "Muz"};
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elmasi";

            Product product2 = new Product();
            product2.Adi = "Muz";
            product2.Fiyati = 30;
            product2.Aciklama = "Yerli muz";

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("------------METHODS--------------");
        
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yesil armut", 12, 10);
            sepetManager.Add2("Elma", "Yesil elma", 10,9);
            sepetManager.Add2("Karpuz", "Cekirdeksiz Karpuz", 80, 8);
        }
    }
}
