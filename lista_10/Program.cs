/*
 10. Cálculo do Desconto
o Objetivo: Aplicar condições para cálculos.
o Descrição: Escreva um programa que peça o valor de uma compra e
verifique se o valor é maior que 100. Se sim, aplique um desconto de 10%
no valor e mostre o valor final. Caso contrário, exiba o valor original.
o Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original:
[valor]
 */

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de compra");
        double produto = double.Parse(Console.ReadLine());
        if (produto > 100)
        {
            double desconto = produto * 0.10;
            double valorFinal = produto - desconto;
            Console.WriteLine($"O valor da compra com desconto é: R${valorFinal:F2}");
        }
        else
        {
            Console.WriteLine($"O valor não possui desconto: R${produto:F2}");
        }
    }
}
