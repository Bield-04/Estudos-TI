// Exercício 12 - Casas de um número
// Receba um inteiro positivo de 0 a 9999 e separe unidade, dezena, centena e milhar usando divisão e módulo.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Número de 0 a 9999: ", out int numero, 0, 9999))
    return;

int unidade = numero % 10;
int dezena = numero / 10 % 10;
int centena = numero / 100 % 10;
int milhar = numero / 1000;

Console.WriteLine($"Milhar: {milhar}");
Console.WriteLine($"Centena: {centena}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Unidade: {unidade}");

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
