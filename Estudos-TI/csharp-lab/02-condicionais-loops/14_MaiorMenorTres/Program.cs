// Exercício 14 - Maior de três
// Leia três números e encontre maior e menor sem usar LINQ.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerReal("Primeiro número: ", out double primeiro)
    || !LerReal("Segundo número: ", out double segundo)
    || !LerReal("Terceiro número: ", out double terceiro))
    return;

double maior = primeiro;
double menor = primeiro;

if (segundo > maior)
    maior = segundo;
if (terceiro > maior)
    maior = terceiro;

if (segundo < menor)
    menor = segundo;
if (terceiro < menor)
    menor = terceiro;

Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");

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
