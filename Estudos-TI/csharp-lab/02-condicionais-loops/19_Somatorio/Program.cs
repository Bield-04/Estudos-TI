// Exercício 19 - Somatório
// Some todos os inteiros de 1 até N. Faça com loop e depois compare com a fórmula matemática.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("N (0 a 1 milhão): ", out int n, 0, 1_000_000))
    return;

long somaLoop = 0;
for (int numero = 1; numero <= n; numero++)
    somaLoop += numero;

long somaFormula = (long)n * (n + 1) / 2;

Console.WriteLine($"Soma com loop: {somaLoop}");
Console.WriteLine($"Soma com fórmula: {somaFormula}");
Console.WriteLine(somaLoop == somaFormula ? "Resultados iguais." : "Resultados diferentes.");

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
