//Utilizando Arrays
//Problema "aprovados"
//Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram
//no 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir
//os nomes dos alunos aprovados, considerando aprovados aqueles cuja média das notas seja maior ou
//igual a 6.0 (seis). 

using System.Globalization;

namespace AlunosAprovadosArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double mediaNotas;

            const double mediaAprovacao = 6.0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos alunos serao digitados? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite nome do aluno: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite a primeira nota do aluno: ");
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Digite a segunda nota do aluno: ");
                nota2[i] = double.Parse(Console.ReadLine(), CI);
                Console.WriteLine();
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++)
            {
                mediaNotas = (nota1[i] + nota2[i]) / 2;

                if (mediaNotas >= mediaAprovacao)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
