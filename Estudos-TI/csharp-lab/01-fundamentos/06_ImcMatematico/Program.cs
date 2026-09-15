// Exercício 06 - IMC matemático
// Leia peso e altura e calcule o IMC. Neste exercício, foque no cálculo e formatação, não em diagnóstico de saúde.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerReal("Peso em kg (0,01 a 1000): ", out double peso, 0.01, 1000)
    || !LerReal("Altura em metros (0,01 a 3): ", out double altura, 0.01, 3))
    return;

double imc = peso / (altura * altura);
Console.WriteLine($"IMC matemático: {imc:F2}");

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
