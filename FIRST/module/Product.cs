using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST.module
{
    public class Product
    {
        public Product(): this ("") { }
        public Product(string pin):this (pin, "") { }
        public Product(string pin, string brend):this (pin, brend,"") { }
        public Product(string pin, string brend, string name)
        {
            this.Pin = pin;
            this.Brend = brend;
            this.Name = name;
        }
       
        public string Pin { get; set; }//prop
        public string Brend { get; set; }
        public string Name { get; set; }
        public bool Analog { get; set; }
        public string ArtId { get; set; }
        public double Price
        {
            get { return price_; }
            set
            {
                if (value > 0)
                    price_ = value;
                else
                    price_ = 0;
            }
        }
        private double price_;

        public static void PrintInfo (List<Product> products)
        {
            foreach (Product item in products)
            {
               
                Console.WriteLine($"PIN: {item.Pin}\t BRAND: {item.Brend}\t NAME: {item.Name}");
            }
        }
    }
}
