using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int e0, e1w, e1x, e1y, e1z, e1soma, e15hora, e15min, e15total, e6b, e6h, e6a, e10nascimento, e10ano, e10_2050;
            int e10idade, e10ani, e12ndegraus, e12altura, e12alturadegrau;
            double e2x, e2y, e2z, e2m, e3x, e3y, e3z, e3xp, e3yp, e3zp, e3m, e4at, e4s, e4a, e4ns, e5st, e5s, e5g, e5d;
            double e7n, e7r, e7r3, e7p, e7p3, e8base, e8expoente, e8resultado, e9polegadas, e9pes, e9jardas, e9milhas;
            double e11precofab, e11lucrodist, e11imposto, e11total;

            Console.WriteLine("Qual exercício você deseja testar?");
            e0 = Convert.ToInt16(Console.ReadLine());

            switch (e0)
            {
                case 1:
                   Console.WriteLine("Neste exercício efetuaremos a soma de quatro números!\nInsira o primeiro:");
                   e1w = Convert.ToInt16(Console.ReadLine());

                   Console.WriteLine("Agora insira o segundo:");
                   e1x = Convert.ToInt16(Console.ReadLine());

                   Console.WriteLine("O terceiro:");
                   e1y = Convert.ToInt16(Console.ReadLine());

                   Console.WriteLine("E por fim, o quarto número:");
                   e1z = Convert.ToInt16(Console.ReadLine());

                   e1soma = e1w + e1x + e1y + e1z;

                   Console.WriteLine($"O valor da soma é:\n{e1soma}\n");
                   Console.ReadKey();
                   break;

                 case 2:
                    Console.WriteLine("Vamos calcular a mádia aritmetica de três notas,\ninsira a primeira:");
                    e2x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Agora insira a segunda nota:");
                    e2y = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("E por fim, a terceira:");
                    e2z = Convert.ToDouble(Console.ReadLine());

                    e2m = (e2x + e2y + e2z) / 3;
                    Console.WriteLine($"A nota média é {e2m}.");
                    break;

                case 3:
                    Console.WriteLine("Vamos calcular a mádia ponderada de três notas,\ninsira a primeira:");
                    e3x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Quantas pessoas tiraram a nota {e3x}?");
                    e3xp = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Agora insira a segunda nota:");
                    e3y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Quantas pessoas tiraram a nota {e3y}?");
                    e3yp = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("E por fim, a terceira:");
                    e3z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Quantas pessoas tiraram a nota {e3z}?");
                    e3zp = Convert.ToDouble(Console.ReadLine());

                    e3m = (e3x * e3xp + e3y * e3yp + e3z * e3zp) / (e3xp + e3yp + e3zp);
                    Console.WriteLine($"A nota média é {e3m}.");
                    break;

                case 4:
                    Console.WriteLine("Vamos calcular o aumento salarial de um empregado.\nInsira o atual salário:");
                    e4s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Agora insira a porcentagem de aumento:");
                    e4a = Convert.ToDouble(Console.ReadLine());

                    e4at = e4s * e4a /100;
                    e4ns = e4s + e4at;

                    Console.WriteLine($"O aumento será de {e4at}, o novo salário será de {e4ns}.");
                    break;

                case 5:
                    Console.WriteLine("Vamos calcular o salario líquido de um empregado.\nInsira o salário bruto:");
                    e5s = Convert.ToDouble(Console.ReadLine());

                    e5d = e5s * 0.07;
                    e5g = e5s * 0.05;
                    e5st = e5s + e5g - e5d;

                    Console.WriteLine($"O salário líquido será de R${e5st}.");
                    break;

                case 6:
                    Console.WriteLine("Vamos calcular a área de um triângulo, \ninsira o valor da base do triângulo:");
                    e6b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Agora insira a altura:");
                    e6h = int.Parse(Console.ReadLine());

                    e6a = e6b * e6h / 2;

                    Console.WriteLine("O valor da área é: " + e6a);
                    break;

                case 7:
                    Console.WriteLine("Vamos brincar com raízes e pontências, \nexperimente um número positivo e maior que zero:");
                    e7n = Double.Parse(Console.ReadLine());

                    if (e7n <= 0)
                    {
                        Console.WriteLine("Ei! Jogue limpo! \n Vamos tentar novamente. ;) \nInsira um número válido, positivo e maior que zero:");
                        e7n = Double.Parse(Console.ReadLine());
                    }
                    e7p = Math.Pow(e7n, 2);
                    e7p3 = Math.Pow(e7n, 3);
                    e7r = Math.Sqrt(e7n);
                    e7r3 = Math.Pow(e7n,1.0 / 3.0);

                    Console.WriteLine($"{e7n} ao quadrado é: {e7p}.\nAo cubo é: {e7p3}.\nA raíz quadrada de {e7n} é: {e7r}. \nA cúbica é: {e7r3}");

                    break;

                case 8:
                    Console.WriteLine("Vamos calcular uma potência, insira um valor positivo para a base:");
                    double v1 = Convert.ToDouble(Console.ReadLine());
                    e8base = v1;
                    while (e8base <= 0)
                    {
                        Console.WriteLine("Insira um valor POSITIVO para a base:");

                        double v5 = Convert.ToDouble(Console.ReadLine());
                        e8base = v5;
                    }
                    Console.WriteLine("Agora insira um valor positivo para o expoente:");
                    double v2 = Convert.ToDouble(Console.ReadLine());
                    e8expoente = v2;
                    while (e8expoente <= 0)
                    {
                        Console.WriteLine("Insira um valor POSITIVO para o expoente:");
                        double v4 = Convert.ToDouble(Console.ReadLine());
                        e8expoente = v4;
                    }
                    double v3 = Math.Pow(e8base, e8expoente);
                    e8resultado = v3;
                    Console.WriteLine($"{e8base} elevado a {e8expoente} é igual a: {e8resultado}");
                    break;

                case 9:
                    /* Sabe - se que: 1 pé = 12 polegadas, 1 jarda = 3 pés, 1 milha = 1,760 jarda.Faça um 
                     * programa que receba uma medida em pés, faça as conversões a seguir e mostre os
                     * resultados:
                     * a) polegadas, b) jardas, c) milhas.*/

                    Console.WriteLine("Vamos converter unidades, insira um valor em pés que eu o ttransformarei em polegadas, jardas e milhas. :)");
                    e9pes = double.Parse(Console.ReadLine());

                    e9polegadas = e9pes * 12.0;
                    e9jardas = e9pes / 3.0;
                    e9milhas = e9jardas / 1760.0;

                    Console.WriteLine($"{e9pes} são {e9polegadas} polegadas, {e9jardas} jardas, {e9milhas} milhas");
                    break;

                case 10:
                    Console.WriteLine("Vou calcular a sua idade, em que ano você nasceu?");
                    e10nascimento = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Em que ano estamos?");
                    e10ano = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Você já fez aniveirsário este ano?\n1 - Sim\n2 - Não");
                    e10ani = Convert.ToInt16(Console.ReadLine());

                    if (e10ani == 1)
                    {
                        e10ano = e10ano - 1;
                    }
                    e10idade = e10ano - e10nascimento;
                    e10_2050 = 2050 - e10nascimento;

                    Console.WriteLine($"Você tem {e10idade} anos, em 2050 você fará {e10_2050} anos, se estiver vivo até lá. ;)");
                    break;

                case 11:
                    Console.WriteLine("Vamos calcular o custo de um carro novo, insira o preço de fábrica deste veículo:");
                    e11precofab = double.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o percentual de lucro do distribuidor:");
                    e11lucrodist = double.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o percentual dos impostos sobre o valor de fábrica:");
                    e11imposto = double.Parse(Console.ReadLine());

                    e11total = e11precofab + e11precofab * e11lucrodist / 100 + e11precofab * e11imposto / 100;
                    Console.WriteLine($"O custo deste carro novo será de {e11total} reais.");
                    break;

                case 12:
                    Console.WriteLine("Quantos centímetros tem o espelho (altura) de cada degrau?");
                    e12alturadegrau = int.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos centímetros você deseja subir?");
                    e12altura = int.Parse(Console.ReadLine());

                    e12ndegraus = e12altura / e12alturadegrau;
                    Console.WriteLine($"Serão necessários {e12ndegraus} degraus");
                    break;

                case 15:
                    Console.WriteLine("Vamos converter um horário em minutos.\nInsira uma unidade de HORA de 00 a 23:");
                    e15hora = int.Parse(Console.ReadLine());
                    while (e15hora >= 24)
                    {
                        Console.WriteLine("Horario invalido, por favor insira um valor válido:");
                        e15hora = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("Agora insira os minutos:");
                    e15min = Convert.ToInt32(Console.ReadLine());
                    while (e15min >= 60)
                    {
                        Console.WriteLine("Minutos inválidos, por favor insira um valor válido:");
                        int v = Convert.ToInt32(Console.ReadLine());
                        e15min = v;
                    }                    
                    e15total = e15hora * 60 + e15min;
                    Console.WriteLine($"Totalizam {e15total} minutos");
                    Console.ReadKey();
                    break;
            }

            


        
        }
    }
}
