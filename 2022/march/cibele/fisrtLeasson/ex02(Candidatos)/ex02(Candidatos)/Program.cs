using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_Candidatos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eleitores;
            double cand01;
            double cand02;

            Console.Write("Qual é o número total de eleitores : ");
            eleitores = double.Parse(Console.ReadLine());
            Console.Write("Qual é o número total de votos do primeiro candidato : ");
            cand01 = double.Parse(Console.ReadLine());
            Console.Write("Qual é o número total de votos do segundo candidato : ");
            cand02 = double.Parse(Console.ReadLine());

            double percCand1 = (cand01 / eleitores) * 100;
            double percCand02 = (cand02 / eleitores) * 100;
            double nulos = (eleitores - (cand01 + cand02)) / eleitores * 100;

            Console.WriteLine("Resultados \n PercCand1: " + percCand1 + "\n PercCand2 : " + percCand02 +
                "\n Nulos" + nulos);

            Console.ReadLine();


        }
    }
}
