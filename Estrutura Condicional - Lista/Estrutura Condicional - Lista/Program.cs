using System;

namespace Estrutura_Condicional___Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            double e1Lab, e1AvSemestral, e1ExFinal, e1media, e2Nota1, e2Nota2, e2Nota3, e2Media, e2NotaExameFinal,
                e3Valor1, e3Valor2;
            String e1Nota;

            Console.WriteLine("Qual exercício você deseja conferir?");
            indice = int.Parse(Console.ReadLine());
            int caseSwitch = indice;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Insira a nota do Trabalho de Laboraótio:");
                    e1Lab = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a nota da Avaliação Semestral:");
                    e1AvSemestral = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a nota do Exame Final:");
                    e1ExFinal = Convert.ToDouble(Console.ReadLine());

                    e1media = (e1Lab * 2 + e1AvSemestral * 3 + e1ExFinal * 5) / (2 + 3 + 5);
                    if (e1media >= 8)
                    {
                        e1Nota = Convert.ToString("A");
                        Console.WriteLine("Você tirou a nota " + e1Nota);
                    }
                    else if (e1media < 8 && e1media >= 7)
                    { 
                        e1Nota = Convert.ToString("B");
                        Console.WriteLine("Você tirou a nota " + e1Nota);
                    }
                    else if(e1media < 8 && e1media >= 7)
                    {
                        e1Nota = Convert.ToString("C");
                        Console.WriteLine("Você tirou a nota " + e1Nota);
                    }
                    else if(e1media < 8 && e1media >= 7)
                    {
                        e1Nota = Convert.ToString("D");
                        Console.WriteLine("Você tirou a nota " + e1Nota);
                    }
                    else if(e1media < 5)
                    {
                        e1Nota = Convert.ToString("E");
                        Console.WriteLine("Você tirou a nota " + e1Nota);
                    }
                    
                    break;

                case 2:
                    Console.WriteLine("Insira a primeira nota do aluno");
                    e2Nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a primeira nota do aluno");
                    e2Nota2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a primeira nota do aluno");
                    e2Nota3 = Convert.ToDouble(Console.ReadLine());

                    e2Media = (e2Nota1 + e2Nota2 + e2Nota3) / 3;

                    if (e2Media < 3)
                        {
                        Console.WriteLine("O aluno foi reprovado.");
                    }
                    else if (e2Media >= 7 && e2Media <10)
                    {
                        Console.WriteLine("O aluno foi aprovado.");
                    }
                    else if(e2Media>=3 && e2Media<7)
                    {
                        e2NotaExameFinal = 24 - e2Nota1 - e2Nota2 - e2Nota3;
                        Console.WriteLine("O aluno deverá fazer o exame final e alcançar no mínimo a nota " + e2NotaExameFinal);
                    }
                    break;

                case 3:
                    Console.WriteLine("Neste exercício vamos comparar dois números e descobrir qual o maior.\nInsira o primeiro valor");
                    e3Valor1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira um segundo valor, diferente do primeiro.");
                    e3Valor2 = Convert.ToDouble(Console.ReadLine());

                    while (e3Valor1 == e3Valor2)
                    {
                        Console.WriteLine("Você deve escolher números distintos.\nInsira o primeiro valor");
                        e3Valor1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Insira um segundo valor, diferente do primeiro.");
                        e3Valor2 = Convert.ToDouble(Console.ReadLine());
                    }
                    if (e3Valor1 > e3Valor2)
                    {
                        Console.WriteLine("O número maior é o " + e3Valor1);
                    }
                        
                    else if (e3Valor2 > e3Valor1)
                    {
                        Console.WriteLine("O número maior é o " + e3Valor2);
                    }
                        
                    else if (e3Valor1 == e3Valor2)
                    {
                        Console.WriteLine("Você deve escolher números " + e3Valor2);
                    }
                        
                    break;
            }
                

            
        }
    }
}
