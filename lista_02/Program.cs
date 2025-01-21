/*
2 Número Positivo ou Negativo
o Objetivo: Aprender a trabalhar com condições múltiplas.
o Descrição: Desenvolva um programa que solicita ao usuário um número. O
programa deve determinar se o número é positivo, negativo ou zero,
utilizando if, else if, e else para as três possibilidades. Exiba a mensagem
correspondente.
o Exemplo de Saída: "O número é positivo.", "O número é negativo." ou "O
número é zero."
*/

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1)
        {
            Console.WriteLine($"O numero é positivo");
        }
        else if (numero <= -1)
        {
            Console.WriteLine($"O numero é negativo");
        }
        else
        {
            Console.WriteLine($"O numero é igual a zero");
        }
    }
}
