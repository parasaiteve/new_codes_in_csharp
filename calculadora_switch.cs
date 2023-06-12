//incluir a biblioteca
using System;
// classe
class Program
{
    static void Main(string[] args)
    {
        // declarar as variáveis usadas para a calculadora
        char op;
        float num1, num2;

        // a interface vai pedir um operador
        Console.Write("ENTRE COM UM OPERADOR: +, -, /, *: ");

        // o programa vai ler o operador
        op = char.Parse(Console.ReadLine());

        // a interface vai pedir dois valores
        Console.Write("ENTRE COM DOIS VALORES: ");

        // o programa vai ler os valores
        string[] values = Console.ReadLine().Split(' ');
        num1 = float.Parse(values[0]);
        num2 = float.Parse(values[1]);

        // calcular todas as condições dentro dos operadores citados
        switch (op)
        {
            // calcular uma adição
            case '+':
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                break;
            // calcular uma subtração
            case '-':
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                break;
            // calcular uma multiplicação
            case '*':
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                break;
            // calcular uma divisão
            case '/':
                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                break;
            // a interface pedirá que o usuário digite um operador correto caso o operador usado não seja um operador válido para o cálculo
            default:
                Console.WriteLine("OPERADOR ERRADO, POR FAVOR INSIRA O OPERADOR CORRETO");
                break;
        }

        // fechamento do programa
        Console.ReadLine();
    }
}
