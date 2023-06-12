//incluir a biblioteca
using System;
//classe
class Program
{
    //programa principal
    static void Main(string[] args)
    {
        int num, i = 1;

        // interface de usuário
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        // usar while enquanto o número for maior ou igual a i
        while (i <= num)
        {
            // mostrar a contagem de 1 até i
            Console.Write(i + " ");
            i++;
        }

        // fechamento do programa
        Console.ReadLine();
    }
}
