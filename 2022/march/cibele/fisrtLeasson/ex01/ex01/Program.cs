using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diaria;
            double qtdaptos;
            Console.Write("qual é o valor da diária : ");
            diaria = double.Parse(Console.ReadLine());
            Console.Write("qual a quantidade de apartamentos : ");
            qtdaptos = double.Parse(Console.ReadLine());
            double diariaDesc = diaria * 0.75;
            double total100 = diariaDesc * qtdaptos * 2;
            double total70 = diariaDesc * qtdaptos * 2 * 0.7;
            double perda = diaria * qtdaptos * 2 * 0.25;
            Console.WriteLine("Resultados\nDiariDesc : "+ diariaDesc + "\nTotal 100: " + total100 + "\nTotal" +
                "70: " + total70 + "\nPerda: " + perda);

            Console.ReadLine();


        }
    }
}
