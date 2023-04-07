
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeMediasComVetorBidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedido de entrada para o usuario digitar a quantidade de linhas e colunas da matriz.
            Console.Write("Digite a quantidade de linhas ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas ");
            int colunas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declaraçao e instanciaçao da matrix e variaveis.
            int[,] matrix = new int[linhas,colunas];
            int conclusao = 0;
            int e = 1;

            //Armazenagem de dados dentro da matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++) 
                {
                    Console.WriteLine($"Digite o numero para ser armazenado na linha {i} e coluna {j} ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Registrado na posiçao: linha {i} e coluna {j}.");
                    Console.WriteLine();
                }
                while (conclusao == linhas)
                {
                    Console.WriteLine("LINHAS E COLUNAS REGISTRADAS");
                    conclusao = 0;
                    Console.WriteLine();
             //Exibiçao dos numeros armazenados na Matriz       
                }
                for (int a = 0; a < matrix.GetLength(0); a++) 
                {
                    for(int b = 0; b < matrix.GetLength(1); b++)
                    {
                        e =+ 1;
                        Console.Write(matrix[a,b] + " ");
                    }
                    Console.WriteLine();       
                }
            }
            Console.WriteLine("ENCERRAMENTO DO PROGRAMA");
            Console.ReadLine();
        }
    }
}
