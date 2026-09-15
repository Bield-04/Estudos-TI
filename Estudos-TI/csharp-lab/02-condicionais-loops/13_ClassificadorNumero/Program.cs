// Exercício 13 - Classificador de número
// Leia um número e classifique como positivo, negativo ou zero; depois diga se é par ou ímpar.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Digite um inteiro: ", out int numero))
    return;

if (numero > 0)
    Console.WriteLine("Positivo.");
else if (numero < 0)
    Console.WriteLine("Negativo.");
else
    Console.WriteLine("Zero.");

Console.WriteLine(numero % 2 == 0 ? "Par." : "Ímpar.");

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
