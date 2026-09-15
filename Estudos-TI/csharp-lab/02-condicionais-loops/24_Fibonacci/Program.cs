// Exercício 24 - Fibonacci
// Gere os N primeiros termos. Depois faça uma versão que pare ao ultrapassar um limite.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Quantidade de termos (0 a 93): ", out int quantidade, 0, 93))
    return;

Console.WriteLine("Sequência por quantidade:");
long anterior = 0;
long atual = 1;

if (quantidade == 0)
    Console.Write("(sequência vazia)");
if (quantidade >= 1)
    Console.Write(anterior);
if (quantidade >= 2)
    Console.Write($" {atual}");

for (int indice = 2; indice < quantidade; indice++)
{
    long proximo = anterior + atual;
    Console.Write($" {proximo}");
    anterior = atual;
    atual = proximo;
}
Console.WriteLine();

if (!LerLongo("Limite máximo para a segunda sequência: ", out long limite, 0))
    return;

Console.WriteLine("Sequência por limite:");
anterior = 0;
atual = 1;
Console.Write(anterior);

if (limite >= 1)
{
    Console.Write($" {atual}");
    // Só calcula a soma quando ela ainda cabe em long.
    while (anterior <= long.MaxValue - atual)
    {
        long proximo = anterior + atual;
        if (proximo > limite)
            break;

        Console.Write($" {proximo}");
        anterior = atual;
        atual = proximo;
    }
}
Console.WriteLine();

static bool LerInteiro(string mensagem, out int valor,
    int minimo = int.MinValue, int maximo = int.MaxValue)
{
    valor = 0;
    while (true)
    {
        Console.Write(mensagem);
        string? linha = Console.ReadLine();
        if (linha is null)
        {
            Console.WriteLine("\nEntrada encerrada.");
            return false;
        }

        if (int.TryParse(linha, NumberStyles.Integer, CultureInfo.InvariantCulture, out valor)
            && valor >= minimo && valor <= maximo)
            return true;

        Console.WriteLine($"Entrada inválida. Digite um inteiro entre {minimo} e {maximo}.");
    }
}

static bool LerLongo(string mensagem, out long valor,
    long minimo = long.MinValue, long maximo = long.MaxValue)
{
    valor = 0;
    while (true)
    {
        Console.Write(mensagem);
        string? linha = Console.ReadLine();
        if (linha is null)
        {
            Console.WriteLine("\nEntrada encerrada.");
            return false;
        }

        if (long.TryParse(linha, NumberStyles.Integer, CultureInfo.InvariantCulture, out valor)
            && valor >= minimo && valor <= maximo)
            return true;

        Console.WriteLine($"Entrada inválida. Digite um inteiro entre {minimo} e {maximo}.");
    }
}
