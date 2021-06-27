using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            System.Console.WriteLine("\n\n\tOlá usuário! Qual programa você deseja executar?\n\n\t1 - Calcular a área do paralelepípedo.\n\t2 - Colata de dados.\n\t3 - Calculo da area e preço de um terreno.");
            byte indiceMenu = byte.Parse(Console.ReadLine());
            switch (indiceMenu)
            {
                case 1:
                    Console.Clear();
                    AreaParalelepipedo();
                    break;

                case 2:
                    Console.Clear();
                    ColetaDados();
                    break;

                case 3:
                    Console.Clear();
                    CalculoTerreno();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("\n\tInsira uma opção válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Menu();
                    break;
            }


        }

        private static void AreaParalelepipedo()
        {
            double baseMaior, baseMenor, altura, area;

            System.Console.WriteLine("------------------------------------------------------------\n\n");
            System.Console.WriteLine("\tVamos calcular a área de um paralelepípedo?");
            System.Console.WriteLine("\t\t_\n\n\t  OOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOO\n\t_ OOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOOOO\n\t\t_\n");

            System.Console.WriteLine("------------------------------------------------------------\n\n");

            System.Console.WriteLine("\tPrimeiramente, insira o valor da base maior: ");
            baseMaior = double.Parse(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine("------------------------------------------------------------\n\n");
            System.Console.WriteLine("\tVamos calcular a área de um paralelepípedo?");
            System.Console.WriteLine($"\t\t_\n\n\t  OOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOO\n\t_ OOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOOOO\n\t\t{baseMaior}\n");
            System.Console.WriteLine("------------------------------------------------------------\n\n");

            System.Console.WriteLine("\tAgora insira o valor da base menor: ");
            baseMenor = double.Parse(Console.ReadLine());
            Console.Clear();


            if (baseMaior > baseMenor)
            {
                System.Console.WriteLine("------------------------------------------------------------\n\n");
                System.Console.WriteLine("\tVamos calcular a área de um paralelepípedo?");
                System.Console.WriteLine($"\t\t{baseMenor}\n\n\t  OOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOO\n\t_ OOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOOOO\n\t\t{baseMaior}\n");
                System.Console.WriteLine("------------------------------------------------------------\n\n");

                System.Console.WriteLine("\tPor fim, insira o valor da altura do paralelepípedo: ");
                altura = double.Parse(Console.ReadLine());
                area = Calcula_Area(baseMaior, baseMaior, altura);

                Console.Clear();

                System.Console.WriteLine("------------------------------------------------------------\n\n");
                System.Console.WriteLine("\tVamos calcular a área de um paralelepípedo?");
                System.Console.WriteLine($"\t\t{baseMenor}\n\n\t  OOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOO\n\t{altura} OOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOO\n\t  OOOOOOOOOOOOOOOOOOOOOO\n\t\t{baseMaior}\n");
                System.Console.WriteLine("------------------------------------------------------------\n\n");

                System.Console.WriteLine($"A área do paralelepípedo é {area}");
            }

            if (baseMaior < baseMenor)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("\n\tNão vale trapacear! Informe os valores corretamente.");
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("\nTente novamente.");
                System.Console.ReadKey();
                Console.Clear();
                AreaParalelepipedo();
            }

            if (baseMaior == baseMenor)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("\n\tIsso não vai funcionar! Você está tentando calcular a área de um quadrado.");
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("\nTente novamente.");
                System.Console.ReadKey();
                Console.Clear();
                AreaParalelepipedo();
            }

            System.Console.ReadKey();
        }

        static double Calcula_Area(double baseMaior, double baseMenor, double altura)
        {
            return altura * (baseMaior + baseMenor) / 2;
        }

        private static void ColetaDados()
        {
            System.Console.WriteLine("\n\tEntre com seu nome completo:");
            Console.ForegroundColor = ConsoleColor.Red;
            string nome = string.Format(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("\n\tQuantos quartos tem na sua casa?");
            Console.ForegroundColor = ConsoleColor.Red;
            byte quartos = byte.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("\n\tEntre com o preço de cada produto:");
            Console.ForegroundColor = ConsoleColor.Red;
            float precoProduto = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.ReadKey();
        }

        private static void CalculoTerreno()
        {
            System.Console.WriteLine("Insira a largura do terreno:");
            float larguraTerreno = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira agora o comprimento do terreno:");
            float comprimentoTerreno = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe o preço do metro quadrado do terreno:");
            float precoDoMetroQuadrado = float.Parse(Console.ReadLine());

            System.Console.WriteLine("A  área do terreno é: " + areaTerreno(larguraTerreno, comprimentoTerreno).ToString("F2"));
            System.Console.WriteLine("A  preço do terreno é: " + precoTerreno(areaTerreno(larguraTerreno, comprimentoTerreno), precoDoMetroQuadrado).ToString("F2"));

            Console.ReadKey();
        }

        private static float areaTerreno(float largura, float comprimento)
        {
            return largura * comprimento;
        }

        private static float precoTerreno(float area, float precoMetroQuadrado)
        {
            return area * precoMetroQuadrado;
        }
    }
}
