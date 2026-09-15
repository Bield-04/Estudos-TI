// Exercício 09 - Divisão segura
// Leia dois números e evite divisão por zero. Mostre quociente e resto quando fizer sentido.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerDecimal("Dividendo (-1 trilhão a 1 trilhão): ", out decimal dividendo,
    -1_000_000_000_000m, 1_000_000_000_000m))
    return;

decimal divisor;
while (true)
{
    if (!LerDecimal("Divisor diferente de zero: ", out divisor,
        -1_000_000_000_000m, 1_000_000_000_000m))
        return;
    if (divisor != 0)
        break;
    Console.WriteLine("Divisão por zero não é permitida.");
}

try
{
    decimal resultado = dividendo / divisor;
    Console.WriteLine($"Resultado da divisão: {resultado}");

    if (decimal.Truncate(dividendo) == dividendo && decimal.Truncate(divisor) == divisor)
    {
        decimal quociente = decimal.Truncate(resultado);
        decimal resto = dividendo % divisor;
        Console.WriteLine($"Quociente inteiro: {quociente}");
        Console.WriteLine($"Resto: {resto}");
    }
    else
    {
        Console.WriteLine("Quociente inteiro e resto foram omitidos: a entrada contém fração.");
    }
}
catch (OverflowException)
{
    Console.WriteLine("O resultado da divisão ultrapassou o intervalo numérico de decimal.");
}

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
