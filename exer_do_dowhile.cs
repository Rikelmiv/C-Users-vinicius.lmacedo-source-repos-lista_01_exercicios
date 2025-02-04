/*1.Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir os dias trabalhados 
(de 1 a 31) até que digite 0, que indica que terminou de informar os dias. O aluno deve implementar essa contagem utilizando
as estruturas de repetição while, do while e for.*/

// While
int dia;
int diasTrabalhados = 0;
while (true)
{
    Console.WriteLine("Digite o dia trabalhado (1-31) ou 0 para encerrar:");
    dia = int.Parse(Console.ReadLine());
    if (dia == 0)
        break;
    diasTrabalhados++;
}
Console.WriteLine($"Dias trabalhados: {diasTrabalhados}");

// Do-While
int diasTrabalhados2 = 0;
do
{
    Console.WriteLine("Digite o dia trabalhado (1-31) ou 0 para encerrar:");
    dia = int.Parse(Console.ReadLine());
    if (dia != 0)
        diasTrabalhados2++;
} while (dia != 0);
Console.WriteLine($"Dias trabalhados: {diasTrabalhados2}");

// For
int diasTrabalhados3 = 0;
for (; ; )
{
    Console.WriteLine("Digite o dia trabalhado (1-31) ou 0 para encerrar:");
    dia = int.Parse(Console.ReadLine());
    if (dia == 0)
        break;
    diasTrabalhados3++;
}
Console.WriteLine($"Dias trabalhados: {diasTrabalhados3}");



/*2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas até que ele digite
 * um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total utilizando while, do while e for.*/

// While
int despesa;
double totalDespesas = 0;
while (true)
{
    Console.WriteLine("Digite a despesa ou um valor negativo para encerrar:");
    despesa = int.Parse(Console.ReadLine());
    if (despesa < 0)
        break;
    totalDespesas += despesa;
}
Console.WriteLine($"Total das despesas: {totalDespesas}");

// Do-While
double totalDespesas2 = 0;
do
{
    Console.WriteLine("Digite a despesa ou um valor negativo para encerrar:");
    despesa = int.Parse(Console.ReadLine());
    if (despesa >= 0)
        totalDespesas2 += despesa;
} while (despesa >= 0);
Console.WriteLine($"Total das despesas: {totalDespesas2}");

// For
double totalDespesas3 = 0;
for (; ; )
{
    Console.WriteLine("Digite a despesa ou um valor negativo para encerrar:");
    despesa = int.Parse(Console.ReadLine());
    if (despesa < 0)
        break;
    totalDespesas3 += despesa;
}
Console.WriteLine($"Total das despesas: {totalDespesas3}");


/*3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as nolas dos alunos (de 0 a 10) e, ao digitar-1,
 * encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utilizando as três estruturas de repetição.*/

// While
int nota;
int aprovados = 0;
while (true)
{
    Console.WriteLine("Digite a nota do aluno (0-10) ou -1 para encerrar:");
    nota = int.Parse(Console.ReadLine());
    if (nota == -1)
        break;
    if (nota >= 6)
        aprovados++;
}
Console.WriteLine($"Alunos aprovados: {aprovados}");

// Do-While
int aprovados2 = 0;
do
{
    Console.WriteLine("Digite a nota do aluno (0-10) ou -1 para encerrar:");
    nota = int.Parse(Console.ReadLine());
    if (nota >= 6 && nota != -1)
        aprovados2++;
} while (nota != -1);
Console.WriteLine($"Alunos aprovados: {aprovados2}");

// For
int aprovados3 = 0;
for (; ; )
{
    Console.WriteLine("Digite a nota do aluno (0-10) ou -1 para encerrar:");
    nota = int.Parse(Console.ReadLine());
    if (nota == -1)
        break;
    if (nota >= 6)
        aprovados3++;
}
Console.WriteLine($"Alunos aprovados: {aprovados3}");


/*4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0.
 * A solução deve ser implementada usando while, do while e for.*/

// While
int idade;
int somaIdades = 0;
int quantidadeIdades = 0;
while (true)
{
    Console.WriteLine("Digite a idade ou 0 para encerrar:");
    idade = int.Parse(Console.ReadLine());
    if (idade == 0)
        break;
    somaIdades += idade;
    quantidadeIdades++;
}
double mediaIdades = quantidadeIdades > 0 ? somaIdades / (double)quantidadeIdades : 0;
Console.WriteLine($"Média das idades: {mediaIdades}");

// Do-While
int somaIdades2 = 0;
int quantidadeIdades2 = 0;
do
{
    Console.WriteLine("Digite a idade ou 0 para encerrar:");
    idade = int.Parse(Console.ReadLine());
    if (idade != 0)
    {
        somaIdades2 += idade;
        quantidadeIdades2++;
    }
} while (idade != 0);
double mediaIdades2 = quantidadeIdades2 > 0 ? somaIdades2 / (double)quantidadeIdades2 : 0;
Console.WriteLine($"Média das idades: {mediaIdades2}");

// For
int somaIdades3 = 0;
int quantidadeIdades3 = 0;
for (; ; )
{
    Console.WriteLine("Digite a idade ou 0 para encerrar:");
    idade = int.Parse(Console.ReadLine());
    if (idade == 0)
        break;
    somaIdades3 += idade;
    quantidadeIdades3++;
}
double mediaIdades3 = quantidadeIdades3 > 0 ? somaIdades3 / (double)quantidadeIdades3 : 0;
Console.WriteLine($"Média das idades: {mediaIdades3}");


/*5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0.
Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição.*/

// While
int produtosRecebidos, produtosVendidos;
int estoque = 0;
while (true)
{
    Console.WriteLine("Digite a quantidade de produtos recebidos ou vendidos (0 para encerrar):");
    produtosRecebidos = int.Parse(Console.ReadLine());
    if (produtosRecebidos == 0)
        break;
    produtosVendidos = int.Parse(Console.ReadLine());
    estoque += produtosRecebidos - produtosVendidos;
}
Console.WriteLine($"Estoque total: {estoque}");

// Do-While
int estoque2 = 0;
do
{
    Console.WriteLine("Digite a quantidade de produtos recebidos ou vendidos (0 para encerrar):");
    produtosRecebidos = int.Parse(Console.ReadLine());
    if (produtosRecebidos != 0)
    {
        produtosVendidos = int.Parse(Console.ReadLine());
        estoque2 += produtosRecebidos - produtosVendidos;
    }
} while (produtosRecebidos != 0);
Console.WriteLine($"Estoque total: {estoque2}");

// For
int estoque3 = 0;
for (; ; )
{
    Console.WriteLine("Digite a quantidade de produtos recebidos ou vendidos (0 para encerrar):");
    produtosRecebidos = int.Parse(Console.ReadLine());
    if (produtosRecebidos == 0)
        break;
    produtosVendidos = int.Parse(Console.ReadLine());
    estoque3 += produtosRecebidos - produtosVendidos;
}
Console.WriteLine($"Estoque total: {estoque3}");


/*6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao
usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu. implementando a solução com while, do while e for*/

// While
int voto;
int votosA = 0, votosB = 0;
while (true)
{
    Console.WriteLine("Digite o voto (1 para A, 2 para B) ou 0 para encerrar:");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0)
        break;
    if (voto == 1)
        votosA++;
    else if (voto == 2)
        votosB++;
}
Console.WriteLine($"Votos Candidato A: {votosA}, Votos Candidato B: {votosB}");

// Do-While
int votosA2 = 0, votosB2 = 0;
do
{
    Console.WriteLine("Digite o voto (1 para A, 2 para B) ou 0 para encerrar:");
    voto = int.Parse(Console.ReadLine());
    if (voto == 1)
        votosA2++;
    else if (voto == 2)
        votosB2++;
} while (voto != 0);
Console.WriteLine($"Votos Candidato A: {votosA2}, Votos Candidato B: {votosB2}");

// For
int votosA3 = 0, votosB3 = 0;
for (; ; )
{
    Console.WriteLine("Digite o voto (1 para A, 2 para B) ou 0 para encerrar:");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0)
        break;
    if (voto == 1)
        votosA3++;
    else if (voto == 2)
        votosB3++;
}
Console.WriteLine($"Votos Candidato A: {votosA3}, Votos Candidato B: {votosB3}");


/*7 Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição.*/

// While
double distancia;
double totalDistancia = 0;
while (true)
{
    Console.WriteLine("Digite a distância percorrida (ou um valor negativo para encerrar):");
    distancia = double.Parse(Console.ReadLine());
    if (distancia < 0)
        break;
    totalDistancia += distancia;
}
Console.WriteLine($"Distância total percorrida: {totalDistancia}");

// Do-While
double totalDistancia2 = 0;
do
{
    Console.WriteLine("Digite a distância percorrida (ou um valor negativo para encerrar):");
    distancia = double.Parse(Console.ReadLine());
    if (distancia >= 0)
        totalDistancia2 += distancia;
} while (distancia >= 0);
Console.WriteLine($"Distância total percorrida: {totalDistancia2}");

// For
double totalDistancia3 = 0;
for (; ; )
{
    Console.WriteLine("Digite a distância percorrida (ou um valor negativo para encerrar):");
    distancia = double.Parse(Console.ReadLine());
    if (distancia < 0)
        break;
    totalDistancia3 += distancia;
}
Console.WriteLine($"Distância total percorrida: {totalDistancia3}");


/*8. Um atendente de suporte lécnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0. O programa deve calcular o total de minutos atendidos, utilizando while, do while e for.*/

// While
int duracao;
int totalMinutos = 0;
while (true)
{
    Console.WriteLine("Digite a duração da chamada em minutos (0 para encerrar):");
    duracao = int.Parse(Console.ReadLine());
    if (duracao == 0)
        break;
    totalMinutos += duracao;
}
Console.WriteLine($"Total de minutos atendidos: {totalMinutos}");

// Do-While
int totalMinutos2 = 0;
do
{
    Console.WriteLine("Digite a duração da chamada em minutos (0 para encerrar):");
    duracao = int.Parse(Console.ReadLine());
    if (duracao != 0)
        totalMinutos2 += duracao;
} while (duracao != 0);
Console.WriteLine($"Total de minutos atendidos: {totalMinutos2}");

// For
int totalMinutos3 = 0;
for (; ; )
{
    Console.WriteLine("Digite a duração da chamada em minutos (0 para encerrar):");
    duracao = int.Parse(Console.ReadLine());
    if (duracao == 0)
        break;
    totalMinutos3 += duracao;
}
Console.WriteLine($"Total de minutos atendidos: {totalMinutos3}");

/*9. Um cliente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digile 0. A soma dos valores das compras deve ser implementada usando as trés estruturas de repetição.*/

// While
double compra;
double totalCompras = 0;
while (true)
{
    Console.WriteLine("Digite o valor da compra (0 para encerrar):");
    compra = double.Parse(Console.ReadLine());
    if (compra == 0)
        break;
    totalCompras += compra;
}
Console.WriteLine($"Total das compras: {totalCompras}");

// Do-While
double totalCompras2 = 0;
do
{
    Console.WriteLine("Digite o valor da compra (0 para encerrar):");
    compra = double.Parse(Console.ReadLine());
    if (compra != 0)
        totalCompras2 += compra;
} while (compra != 0);
Console.WriteLine($"Total das compras: {totalCompras2}");

// For
double totalCompras3 = 0;
for (; ; )
{
    Console.WriteLine("Digite o valor da compra (0 para encerrar):");
    compra = double.Parse(Console.ReadLine());
    if (compra == 0)
        break;
    totalCompras3 += compra;
}
Console.WriteLine($"Total das compras: {totalCompras3}");


/*10. Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo. O total de passagens vendidas deve ser calculado e apresentado utilizando while, do while e for*/

// While
double passagem;
int totalPassagens = 0;
while (true)
{
    Console.WriteLine("Digite o valor da passagem (valor negativo para encerrar):");
    passagem = double.Parse(Console.ReadLine());
    if (passagem < 0)
        break;
    totalPassagens++;
}
Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");

// Do-While
int totalPassagens2 = 0;
do
{
    Console.WriteLine("Digite o valor da passagem (valor negativo para encerrar):");
    passagem = double.Parse(Console.ReadLine());
    if (passagem >= 0)
        totalPassagens2++;
} while (passagem >= 0);
Console.WriteLine($"Total de passagens vendidas: {totalPassagens2}");

// For
int totalPassagens3 = 0;
for (; ; )
{
    Console.WriteLine("Digite o valor da passagem (valor negativo para encerrar):");
    passagem = double.Parse(Console.ReadLine());
    if (passagem < 0)
        break;
    totalPassagens3++;
}
Console.WriteLine($"Total de passagens vendidas: {totalPassagens3}");

