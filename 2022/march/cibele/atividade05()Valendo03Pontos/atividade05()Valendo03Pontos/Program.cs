using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
nome: João Victor de Souza Oliveira (Engenharia) , Luiz Fernando Alves de Souza (S.I)
rgm:  11221104721, 11221104808
 */
namespace atividade05__Valendo03Pontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totFolha = 0;
            double totPecas = 0;
            double mediaM = 0;
            double mediaF = 0;
            int countM = 0;
            int countF = 0;
            double sm = 724;//consertar o valor do salário


            //variáveis adicio nada por  mim obs: questionar o professo sobre o escopo de variáveis no C#
            double salarioMaior = 0;
            double NumMaior = 0;
            


            for (int count  = 1; count <= 15; count++)
            {
                Console.Write("digite o número do  operário: ");
                int numOp = int.Parse(Console.ReadLine());

                Console.Write("digite o número de peças fabricadas por este operário: ");
                double pecasOP = double.Parse(Console.ReadLine());

                char sexoOp = 's';

                while (sexoOp != 'F' && sexoOp != 'f' && sexoOp != 'M' && sexoOp !='m')
                {
                    Console.Write("Digite o sexo do operário : ");
                    sexoOp = char.Parse(Console.ReadLine());
                }
                double salarioOp = 0;


                if (pecasOP <= 30){
                     salarioOp = sm;
                }
                else
                {
                    if(pecasOP > 30 && pecasOP <= 35)
                    {
                         salarioOp = sm + ((pecasOP - 30) * 3 / 100 * sm);
                    }
                    else
                    {
                        salarioOp = sm + ((pecasOP -30) * 5 / 100 * sm);/*no progama constava o valor 3 mais eu acho que está incorreto*/
                    }
                }

                Console.WriteLine($"o número do operário é {numOp} e o seu salário é igula á R${salarioOp}");

                totFolha += salarioOp;
                totPecas += pecasOP;

                if(sexoOp == 'M' || sexoOp == 'm')
                {
                    mediaM += pecasOP;
                    countM++ ;
                }
                else
                {
                    mediaF += pecasOP;
                    countF++;
                }
                


                if(count == 1)
                {
                    salarioMaior = salarioOp;
                    NumMaior = numOp;
                }
                else
                {
                    if(salarioOp > salarioMaior)
                    {
                        salarioMaior = salarioOp;
                        NumMaior = numOp;
                    }
                }

            // fim do meu primerio laço de repetição
            }
            if(countM == 0)
            {
                mediaM = 0;
            }
            else
            {
                mediaM = mediaM / countM;
            }
            if(countF == 0)
            {
                mediaF = 0;
            }
            else
            {
                mediaF = mediaF / countF;
            }



            Console.Write($"A salário total a ser pago pele empresa é de R$ {totFolha}" +
                $"\nO total de peças feitas por todos o funcionário é de {totPecas}" +
                $"\nÁ média de peças feitas por mulheres é de {mediaF}" +
                $"\nÁ méida de peças feitas por homens é de {mediaM}" +
                $"\nO número do funcionário com o maior salário é de R$ {NumMaior}");


            Console.ReadLine();
            
        }
    }
}
