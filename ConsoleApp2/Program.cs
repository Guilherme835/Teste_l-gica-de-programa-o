using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // EXERCICIO 1 

            int distancia, tempo, velocidade, litro_usado;

            Console.WriteLine("Exercicio 1: ");

            Console.WriteLine("Qual foi seu tempo gasto? ");
            tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual foi sua Velocidade média? ");
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            litro_usado = distancia / 12;

            Console.WriteLine($"\nDados da viagem: ");
            Console.WriteLine($"\nVelocidade média da viagem: {velocidade} KM/h");
            Console.WriteLine($"\nDistância da viagem: {distancia} KM");
            Console.WriteLine($"\nTempo da viagem: {tempo}");
            Console.WriteLine($"\nlitros usados na viagem: {litro_usado}");


            // EXERCICIO 2



            // EXERCICIO 3

            int a, b, c, d, soma, p;

            Console.WriteLine("Exercicio 3: \n");


            Console.WriteLine("Qual é o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual é o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual é o valor de C: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual é o valor de D: ");
            d = int.Parse(Console.ReadLine());

            p = a + c;
            Console.WriteLine($"Primeiro resultado: {p} ");

            soma = b + d;
            Console.WriteLine($"\nSegundo resultado: {soma} ");

            // EXERCICIO 4

            Console.WriteLine("Exercicio 4: \n");

            int num1, num2, num3;

            Console.Write("Digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o terceiro numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3) Console.WriteLine($"\nO maior é {num1}\n");
                else Console.WriteLine($"\nO maior é {num3}\n");
            }
            else
            {
                if (num2 > num3) Console.WriteLine($"\nO maior é {num2}\n");
                else Console.WriteLine($"\nO maior é {num3}\n");
            }*/

            // EXERCICIO 5

            // EXERCICIO 6
            /*
            int numA, numB, numC, numD;

            Console.Write("Exercicio 6: \n\n");

            Console.Write("Digite o primeiro numero: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo numero: ");
            numB = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o terceiro numero: ");
            numC = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o terceiro numero: ");
            numD = int.Parse(Console.ReadLine());

            if (numA > numB && numC > numD)
            {
                if (numB > numC) {
                    Console.WriteLine($"\nO maior é {numA} e o menor é o {numD}");
                }
                else
                {
                    Console.WriteLine($"\nO maior é {numC} e o menor é o {numB}\n");
                }
            }
            else
            {
                if (numB > numC && numD > numA)
                {
                    if (numC > numD)
                    {
                        Console.WriteLine($"\nO maior é {numB} e o menor é o {numA}\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nO maior é {numD} e o menor é o {numC}\n");
                    }
                }  
            }

            // EXERCICIO 7
            int A, B, C;

            Console.WriteLine("Exercicio 7: \n");

            Console.Write("Digite o valor do lado A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do lado B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do lado C: ");
            C = int.Parse(Console.ReadLine());

            if (A == B && A == C)
            {
                Console.Write("\nSeu triangulo é Equilatero");
            }
            else
            {
                if (A == B && B != C)
                {
                  Console.Write("\nSeu triangulo é Isósceles");  
                }
                else
                {
                    if (A != B && A == C)
                    {
                        Console.Write("\nSeu triangulo é Isósceles");
                    }
                    else
                    {
                        if (A != C && A == B)
                        {
                            Console.Write("\nSeu triangulo é Isósceles");
                        }
                        else
                        {
                            Console.Write("\nSeu triangulo é Escalano");
                        }
                    }
                }
            }

            // EXERCICIO 8

            // EXERCICIO 9
            
            Console.WriteLine("Exercicio 9: \n");

            int n1, n2, resultado;
            string operacao, novaConta;
            do
            {
                Console.Clear();
                Console.Write("Digite o primeiro numero: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("\nDigite o operador (+, -, * e /):");
                operacao = Console.ReadLine();

                Console.Write("\nDigite o segundo numero: ");
                n2 = int.Parse(Console.ReadLine());

                if (operacao == "+")
                {
                    resultado = n1 + n2;
                    Console.Write($"\nO resultado é: {resultado}");
                }
                else
                {
                    if (operacao == "-")
                    {
                        resultado = n1 - n2;
                        Console.Write($"\nO resultado é: {resultado}");
                    }
                    else
                    {
                        if (operacao == "*")
                        {
                            resultado = n1 * n2;
                            Console.Write($"\nO resultado é: {resultado}");
                        }
                        else
                        {
                            if (operacao == "/")
                            {
                                resultado = n1 / n2;
                                Console.Write($"\nO resultado é: {resultado}");
                            }
                            else
                            {
                                Console.Write($"\nOpção invalida");
                            }
                        }
                    }
                }
                Console.Write($"\n\nDeseja fazer nova conta? (sim / não) ");
                novaConta = Console.ReadLine();
            }
            while (novaConta != "não");*/

            // EXERCICIO 10

            Console.WriteLine("Exercicio 10:  \n");

            int[] N = new int[10];

            Console.Write("Digite o 1° valor: ");
            N[0] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 2° valor: ");
            N[1] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 3° valor: ");
            N[2] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 4° valor: ");
            N[3] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 5° valor: ");
            N[4] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 6° valor: ");
            N[5] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 7° valor: ");
            N[6] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 8° valor: ");
            N[7] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 9° valor: ");
            N[8] = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o 10° valor: ");
            N[9] = int.Parse(Console.ReadLine());

            

            Console.Write("\n10° valor: " + N[9]);

            Console.Write("\n9° valor: " + N[8]);

            Console.Write("\n8° valor: " + N[7]);

            Console.Write("\n7° valor: " + N[6]);

            Console.Write("\n6° valor: " + N[5]);

            Console.Write("\n5° valor: " + N[4]);

            Console.Write("\n4° valor: " + N[3]);

            Console.Write("\n3° valor: " + N[2]);

            Console.Write("\n2° valor: " + N[1]);

            Console.Write("\n1° valor: " + N[0]);


            // EXERCICIO 11

            // EXERCICIO 12

            // EXERCICIO 13

            Console.ReadKey();
        }
    }
}
