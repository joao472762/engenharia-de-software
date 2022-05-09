using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class06_function_
{
    internal class Program
        //function in C#
        /*sitaxe
            static void funcionNmae(){
            Comands
        }
         */
    {
        static void Main(string[] args)
        {
            Console.Write("type a price : ");
            var price  = int.Parse(Console.ReadLine());

            Console.Write("type a product name : ");
            string product = Console.ReadLine();
            ShowPrice(price,product);
            Console.ReadLine();
        }
        static void ShowPrice(int price,string name) { 
            Console.WriteLine($"o produto {name} custa exatamente {price}reais");
        }


        static void Function()
        {
            Console.WriteLine("this fucntion will execute all comands that are inside the block");
        }

       
    }
}
