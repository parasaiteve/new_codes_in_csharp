using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        // interface de usuário
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        // mostrar os primeiros números pares usando o número solicitado pelo usuário
        Console.Write("Os primeiros " + num + " números pares são: ");

        // usar for para executar os números até onde o usuário solicita
        for (int i = 2; i <= num * 2; i += 2)
        {
            Console.Write(i + " ");
        }

        // fechamento do programa
        Console.ReadLine();
    }
}