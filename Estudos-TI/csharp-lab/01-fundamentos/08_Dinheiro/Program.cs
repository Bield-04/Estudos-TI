// Exercício 08 - Dinheiro
// Leia preço e quantidade, calcule subtotal, desconto percentual e total final.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerDecimal("Preço unitário (0 a 1 trilhão): ", out decimal preco, 0, 1_000_000_000_000m)
    || !LerInteiro("Quantidade (0 a 1 milhão): ", out int quantidade, 0, 1_000_000)
    || !LerDecimal("Desconto percentual (0 a 100): ", out decimal percentual, 0, 100))
    return;

decimal subtotal = decimal.Round(preco * quantidade, 2, MidpointRounding.AwayFromZero);
decimal desconto = decimal.Round(subtotal * percentual / 100, 2, MidpointRounding.AwayFromZero);
decimal total = subtotal - desconto;

Console.WriteLine($"Subtotal: R$ {subtotal:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2} ({percentual:F2}%)");
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
