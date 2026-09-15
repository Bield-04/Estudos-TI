// Exercício 17 - Preço por faixa
// Aplique descontos diferentes conforme o valor de uma compra. Evite condições sobrepostas.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerDecimal("Valor da compra (0 a 1 trilhão): ", out decimal compra, 0, 1_000_000_000_000m))
    return;

compra = decimal.Round(compra, 2, MidpointRounding.AwayFromZero);
decimal taxa;
if (compra < 100)
    taxa = 0;
else if (compra < 500)
    taxa = 0.05m;
else
    taxa = 0.10m;

decimal desconto = decimal.Round(compra * taxa, 2, MidpointRounding.AwayFromZero);
decimal total = compra - desconto;

Console.WriteLine($"Compra: R$ {compra:F2}");
Console.WriteLine($"Desconto percentual: {taxa * 100:0}%");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Total: R$ {total:F2}");

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
