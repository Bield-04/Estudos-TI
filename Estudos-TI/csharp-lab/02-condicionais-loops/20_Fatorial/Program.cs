// Exercício 20 - Fatorial
// Calcule N! para valores pequenos. Descubra em que ponto int e long estouram.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("N para calcular N! (0 a 20): ", out int n, 0, 20))
    return;

long fatorial = 1;
for (int fator = 2; fator <= n; fator++)
    fatorial *= fator;
Console.WriteLine($"{n}! = {fatorial}");

// Verifica o próximo produto antes de multiplicar, para não provocar overflow.
int acumuladoInt = 1;
int limiteInt = 1;
while (acumuladoInt <= int.MaxValue / (limiteInt + 1))
{
    limiteInt++;
    acumuladoInt *= limiteInt;
}

long acumuladoLong = 1;
int limiteLong = 1;
while (acumuladoLong <= long.MaxValue / (limiteLong + 1))
{
    limiteLong++;
    acumuladoLong *= limiteLong;
}

Console.WriteLine($"int comporta até {limiteInt}! = {acumuladoInt}; {limiteInt + 1}! excede int.");
Console.WriteLine($"long comporta até {limiteLong}! = {acumuladoLong}; {limiteLong + 1}! excede long.");

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
