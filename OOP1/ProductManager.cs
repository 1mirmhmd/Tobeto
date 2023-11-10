using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        // Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Updated(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        public void DoSometh(int sayi)
        {
            sayi = 100;
        }
       
    }
}
