using System;

namespace Exercicio_Dois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota do aluno: ");
            var n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            var n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            var n3 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3) / 3;

            if (media == 10)
                Console.WriteLine($"Aprovado com louvor! {media:F1}");
            else if (media >= 7)
                Console.WriteLine($"Aprovado! {media:F1}");
            else if (media < 7)
                Console.WriteLine($"Reprovado! {media:F1}");
            Console.ReadKey();
        }
    }
}
