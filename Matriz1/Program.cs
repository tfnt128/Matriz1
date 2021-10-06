using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            //criando a matriz "a"
            int[,] a;

            n = int.Parse(Console.ReadLine());

            //criando uma matriz quadrada
            a = new int[n, n];

            //for para a digitação e alocação em cada área da matriz
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("Diagonal Principal: ");

            //for para achar a diagonal principal
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i,i] + " ");

            }

            int cont = 0;
            //for para contar os numeros negativos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de negativos: " + cont);
        }
    }
}
