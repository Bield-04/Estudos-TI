// Exercício 03 - Conversor de temperatura
// Converta Celsius para Fahrenheit e Kelvin. Valide a entrada numérica.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerReal("Temperatura em Celsius: ", out double celsius))
    return;

double fahrenheit = celsius * 1.8 + 32;
double kelvin = celsius + 273.15;

if (!double.IsFinite(fahrenheit) || !double.IsFinite(kelvin))
{
    Console.WriteLine("A conversão ultrapassou o intervalo numérico de double.");
    return;
}

Console.WriteLine($"Celsius: {celsius:F2} °C");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
Console.WriteLine($"Kelvin: {kelvin:F2} K");

static bool LerReal(string mensagem, out double valor,
    double minimo = double.MinValue, double maximo = double.MaxValue)
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
        if (double.TryParse(texto, estilo, CultureInfo.InvariantCulture, out valor)
            && double.IsFinite(valor) && valor >= minimo && valor <= maximo)
            return true;

        Console.WriteLine("Entrada inválida. Digite um número finito dentro do intervalo solicitado.");
    }
}
