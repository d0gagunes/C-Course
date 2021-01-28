using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1 //Object Oriented Programing (nesne tabanli programlama)

{
    class Product
    {
        public int ID { get; set; }// urun kodu
        public int CategoryID { get; set; }// kategori kodu
        public string ProductName { get; set; } //Urun ismi
        public double UnitPrice { get; set; } //birim fiyat
        public int UnitInStock { get; set; } //stok adedi


    }
}
