using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a nota:");
        double nota =
        Convert.ToDouble(Console.ReadLine());

        //Verificação se a nota é maior do que 6

        if (nota >= 6)
        {
            Console.WriteLine("O aluno foi aprovado!");
        }
        else
        {
            Console.WriteLine("O aluno foi reprovado.");
        }

    }
}

        

