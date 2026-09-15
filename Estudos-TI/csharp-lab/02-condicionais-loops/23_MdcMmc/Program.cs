// Exercício 23 - MDC e MMC
// Implemente o algoritmo de Euclides para MDC e derive o MMC.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Primeiro inteiro: ", out int primeiro)
    || !LerInteiro("Segundo inteiro: ", out int segundo))
    return;

// Converte antes de obter o valor absoluto: int.MinValue cabe positivo em long.
long a = Math.Abs((long)primeiro);
long b = Math.Abs((long)segundo);
long x = a;
long y = b;

while (y != 0)
{
    long resto = x % y;
    x = y;
    y = resto;
}

long mdc = x;
long mmc = a == 0 || b == 0 ? 0 : a / mdc * b;

Console.WriteLine($"MDC: {mdc}");
Console.WriteLine($"MMC: {mmc}");

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
