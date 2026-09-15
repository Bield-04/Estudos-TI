// Exercício 15 - Calculadora com menu
// Use switch para escolher soma, subtração, multiplicação, divisão ou potência.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Potência");

if (!LerInteiro("Escolha a operação: ", out int opcao, 1, 5)
    || !LerReal("Primeiro número: ", out double a)
    || !LerReal("Segundo número: ", out double b))
    return;

double resultado;
switch (opcao)
{
    case 1:
        resultado = a + b;
        break;
    case 2:
        resultado = a - b;
        break;
    case 3:
        resultado = a * b;
        break;
    case 4:
        while (b == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
            if (!LerReal("Informe outro divisor: ", out b))
                return;
        }
        resultado = a / b;
        break;
    case 5:
        resultado = Math.Pow(a, b);
        break;
    default:
        return;
}

if (double.IsFinite(resultado))
    Console.WriteLine($"Resultado: {resultado}");
else
    Console.WriteLine("O resultado não é um número real finito representável por double.");

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
