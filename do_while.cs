//incluir a biblioteca
using System;
//classe
class Program
{
    //programa principal
    static void Main(string[] args)
    {
        int num;

        // usar do-while para executar o código
        do
        {
            Console.Write("Digite um número de 1 a 10: ");
            num = int.Parse(Console.ReadLine());
            // while para ser usada em condição
        } while (num < 1 || num > 10);

        Console.WriteLine("Voce digitou o numero " + num + ".");

        // fechamento do programa
        Console.ReadLine();
    }
}
