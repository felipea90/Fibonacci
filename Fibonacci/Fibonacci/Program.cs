using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência de Fibonacci \n");

            Console.WriteLine("Informe a quantidade de sucessões para cálculo da série.");
            int Fn = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            Console.WriteLine("0 \n1");

            for (int i = 2; i < Fn; i++)
            {
                c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;
            }

            Console.WriteLine("Informe a posição da seqûencia para saber o número respectivo.");
            int n = int.Parse(Console.ReadLine());

            int num = n - 1;

            int[] Fibonacci = new int[num + 1];

            Fibonacci[0] = 0;
            Fibonacci[1] = 1;

            for (int i = 2; i <= num; i++)
            {
                Fibonacci[i] = Fibonacci[i - 2] + Fibonacci[i - 1];
            }

            Console.WriteLine(Fibonacci[num]);

        }
    }
}
