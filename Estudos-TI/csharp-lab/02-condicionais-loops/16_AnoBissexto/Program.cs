// Exercício 16 - Ano bissexto
// Receba um ano e diga se ele é bissexto. Pesquise e escreva a regra correta antes de codar.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Ano (1 a 9999): ", out int ano, 1, 9999))
    return;

// Regra do calendário gregoriano, também registrada no README.
bool bissexto = ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0);
Console.WriteLine(bissexto ? $"{ano} é bissexto." : $"{ano} não é bissexto.");

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
