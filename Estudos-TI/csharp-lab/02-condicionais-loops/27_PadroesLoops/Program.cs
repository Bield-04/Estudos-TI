// Exercício 27 - Padrões com loops
// Desenhe triângulos de asteriscos, crescente e decrescente, usando loops aninhados.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Altura dos triângulos (1 a 50): ", out int altura, 1, 50))
    return;

Console.WriteLine("Crescente:");
for (int linha = 1; linha <= altura; linha++)
{
    for (int coluna = 1; coluna <= linha; coluna++)
        Console.Write("*");
    Console.WriteLine();
}

Console.WriteLine("Decrescente:");
for (int linha = altura; linha >= 1; linha--)
{
    for (int coluna = 1; coluna <= linha; coluna++)
        Console.Write("*");
    Console.WriteLine();
}

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
