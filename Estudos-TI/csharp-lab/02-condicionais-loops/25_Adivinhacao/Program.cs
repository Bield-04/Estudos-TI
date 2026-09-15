// Exercício 25 - Adivinhação
// Gere um número aleatório e permita tentativas até acertar. Informe "maior" ou "menor".
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

int secreto = Random.Shared.Next(1, 101);
int tentativas = 0;
Console.WriteLine("Adivinhe um número inteiro de 1 a 100.");

while (true)
{
    if (!LerInteiro("Seu palpite: ", out int palpite, 1, 100))
        return;

    tentativas++;
    if (palpite == secreto)
    {
        Console.WriteLine($"Acertou! O número era {secreto}. Tentativas válidas: {tentativas}.");
        break;
    }

    Console.WriteLine(palpite < secreto
        ? "O número secreto é maior."
        : "O número secreto é menor.");
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
