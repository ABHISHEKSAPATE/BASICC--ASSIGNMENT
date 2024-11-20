using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparableandcomparer
{
    internal class Program
    {
        public class Product:IComparable
        {
            private string name;
            private float price;

            public Product(string name,float price)
            {
                this.name = name;
                this.price = price;
            }
            //as price field is private we can accen in other class so for that we use get
            public float Price
            {
                get { return price; }
            }

            public int CompareTo(object obj)
            {
                Product p = (Product)obj;
                if(this.price>p.price)
                {
                    return 1;
                }
                else if (this.price < p.price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        //for IComparer
      
       
        public class CheckPrice : IComparer
        {
            public int Compare(object x, object y)
            {
                Product p1 = (Product)x;
                Product p2 = (Product)y;
                if(p1.Price> p2.Price)
                {
                    return 1;
                }
               else if (p1.Price < p2.Price)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Product fan = new Product("Fan", 50000);
            Product tv = new Product("TV", 60000);
            //int result = fan.CompareTo(tv);
            //if (result == 1)
            //{
            //    Console.WriteLine("Fan price more  than TV");
            //}
            //else if (result == -1)
            //{
            //    Console.WriteLine("TV price more  than Fan");
            //}
            //else
            //{
            //    Console.WriteLine("Both scored equal");


            //}
            //iComparer class obj creation
            CheckPrice c1 = new CheckPrice();
            int result = c1.Compare(fan, tv);
            if (result == 1)
            {
                Console.WriteLine("Fan price more  than TV");
            }
            else if (result == -1)
            {
                Console.WriteLine("TV price more  than Fan");
            }
            else
            {
                Console.WriteLine("Both scored equal");


            }


        }
    }
}
