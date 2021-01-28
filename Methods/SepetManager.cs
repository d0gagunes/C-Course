using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add (Product product) // parantezz ici parametre
        {
            Console.WriteLine( "Sepete Eklendi : " +product.Adi);

        }
        public void Add2(string Adi, string Aciklama, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + Adi);
        }
    }
}
