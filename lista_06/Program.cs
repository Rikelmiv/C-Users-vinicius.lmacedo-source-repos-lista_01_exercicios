/*
 6. Classificação de Notas
o Objetivo: Aprender a usar múltiplas condições em uma estrutura de
decisão.
o Descrição: Crie um programa que peça a nota de um aluno e classifique a
nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular"
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
o Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa".
 */

class Program
{
    static void Main()
    {
        Console.Write("Digite um nota: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 9)
        {
            Console.WriteLine("Parabéns sua nota é EXCELENTE");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("Parabéns sua nota é BOA");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Parabéns sua nota é REGULAR");
        }
        else
        {
            Console.WriteLine("Infelizmente sua nota está muito baixa");
        }
    }
}
