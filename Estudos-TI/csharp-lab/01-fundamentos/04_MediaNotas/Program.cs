// Exercício 04 - Média de notas
// Leia 4 notas, calcule média simples e imprima com duas casas decimais.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

decimal soma = 0;
for (int numero = 1; numero <= 4; numero++)
{
    if (!LerDecimal($"Nota {numero} (0 a 10): ", out decimal nota, 0, 10))
        return;
    soma += nota;
}

decimal media = soma / 4;
Console.WriteLine($"Média: {media:F2}");

static bool LerDecimal(string mensagem, out decimal valor,
    decimal minimo = decimal.MinValue, decimal maximo = decimal.MaxValue)
{
    valor = 0;
    const NumberStyles estilo = NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint;
    while (true)
    {
        Console.Write(mensagem);
        string? linha = Console.ReadLine();
        if (linha is null)
        {
            Console.WriteLine("\nEntrada encerrada.");
            return false;
        }

        string texto = linha.Trim().Replace(',', '.');
        if (decimal.TryParse(texto, estilo, CultureInfo.InvariantCulture, out valor)
            && valor >= minimo && valor <= maximo)
            return true;

        Console.WriteLine("Entrada inválida. Digite um número dentro do intervalo solicitado.");
    }
}
