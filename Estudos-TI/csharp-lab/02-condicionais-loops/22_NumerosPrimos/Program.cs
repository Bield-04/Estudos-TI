// Exercício 22 - Números primos
// Determine se um número é primo. Depois liste os primos até N.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Número para verificar: ", out int numero))
    return;

bool primo = numero >= 2;
for (int divisor = 2; primo && divisor <= numero / divisor; divisor++)
{
    if (numero % divisor == 0)
        primo = false;
}
Console.WriteLine(primo ? $"{numero} é primo." : $"{numero} não é primo.");

if (!LerInteiro("Listar primos até N (0 a 100000): ", out int limite, 0, 100_000))
    return;

Console.WriteLine($"Primos até {limite}:");
bool encontrou = false;
for (int candidato = 2; candidato <= limite; candidato++)
{
    bool candidatoPrimo = true;
    for (int divisor = 2; divisor <= candidato / divisor; divisor++)
    {
        if (candidato % divisor == 0)
        {
            candidatoPrimo = false;
            break;
        }
    }

    if (candidatoPrimo)
    {
        if (encontrou)
            Console.Write(" ");
        Console.Write(candidato);
        encontrou = true;
    }
}
if (!encontrou)
    Console.Write("Nenhum.");
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
