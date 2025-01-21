/*
 3. Aprovação de Aluno
o Objetivo: Compreender a aplicação de condições para tomada de decisão.
o Descrição: Escreva um programa que pergunte a nota de um aluno. Se a
nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso
contrário, ele é "Reprovado". Exiba a situação do aluno na tela.
o Exemplo de Saída: "Aluno aprovado." ou "Aluno reprovado.
 */

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota do aluno: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 6)
        {
            Console.WriteLine($"O aluno está aprovado");
        }
        else
        {
            Console.WriteLine("O aluno está reprovado");
        }
    }
}
