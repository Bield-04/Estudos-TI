// Exercício 02 - Idade futura
// Leia a idade atual e mostre qual será a idade daqui a 5, 10 e 20 anos.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Digite sua idade atual (0 a 150): ", out int idade, 0, 150))
    return;

Console.WriteLine($"Idade atual: {idade} anos.");
Console.WriteLine($"Daqui a 5 anos: {idade + 5} anos.");
Console.WriteLine($"Daqui a 10 anos: {idade + 10} anos.");
Console.WriteLine($"Daqui a 20 anos: {idade + 20} anos.");

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
