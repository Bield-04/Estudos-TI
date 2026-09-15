// Exercício 07 - Segundos para horário
// Converta um total de segundos em horas, minutos e segundos.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerLongo("Total de segundos (não negativo): ", out long total, 0))
    return;

long horas = total / 3600;
long minutos = total % 3600 / 60;
long segundos = total % 60;

Console.WriteLine($"Horas: {horas}; minutos: {minutos}; segundos: {segundos}");
Console.WriteLine($"Formato: {horas:D2}:{minutos:D2}:{segundos:D2}");

static bool LerLongo(string mensagem, out long valor,
    long minimo = long.MinValue, long maximo = long.MaxValue)
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

        if (long.TryParse(linha, NumberStyles.Integer, CultureInfo.InvariantCulture, out valor)
            && valor >= minimo && valor <= maximo)
            return true;

        Console.WriteLine($"Entrada inválida. Digite um inteiro entre {minimo} e {maximo}.");
    }
}
