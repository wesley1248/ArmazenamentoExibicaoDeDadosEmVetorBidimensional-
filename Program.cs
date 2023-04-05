
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeMeidasComv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedido de entrada para o usuario digitar a quantidade de linhas e colunas da matrix.
            Console.Write("Digite a quantidade de linhas ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas ");
            int colunas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declaraçao e instanciaçao da matrix e variaveis.
            int[,] matrix = new int[linhas,colunas];
            int conclusao = 0;

            //Armazenagem de dados dentro da matrix
            for (int i = 0; i < linhas; i++)
            {
                conclusao = +1;
                for (int j = 0; j < colunas; j++) 
                {
                    Console.WriteLine($"Digite o numero para ser armazenado na linha {i} e coluna {j} ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Registrado na posiçao: linha {i} e coluna {j}.");
                }
                while (conclusao == linhas)
                {
                    Console.WriteLine("LINHAS E COLUNAS REGISTRADAS");
                    conclusao = 0;
                    Console.WriteLine();
                }
                for (int a = 0; a < linhas; a ++) {
                    Console.Write(matrix[linhas,colunas]);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }//Criar o trecho de codigo  para exibir os intens dentro da matrix
        }
    }
}
