// Exercício 05 - Troca de valores
// Leia dois inteiros e troque seus valores. Faça primeiro com variável auxiliar e depois usando tupla.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Primeiro inteiro: ", out int primeiro)
    || !LerInteiro("Segundo inteiro: ", out int segundo))
    return;

int originalPrimeiro = primeiro;
int originalSegundo = segundo;
Console.WriteLine($"Antes: primeiro = {primeiro}; segundo = {segundo}");

int auxiliar = primeiro;
primeiro = segundo;
segundo = auxiliar;
Console.WriteLine($"Com auxiliar: primeiro = {primeiro}; segundo = {segundo}");

// As duas demonstrações partem dos mesmos valores originais.
primeiro = originalPrimeiro;
segundo = originalSegundo;
(primeiro, segundo) = (segundo, primeiro);
Console.WriteLine($"Com tupla: primeiro = {primeiro}; segundo = {segundo}");

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
