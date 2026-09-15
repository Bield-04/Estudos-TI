// Exercício 01 - Olá, usuário
// Leia o nome do usuário e imprima uma saudação personalizada.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerTexto("Qual é o seu nome? ", out string nome))
    return;

Console.WriteLine($"Olá, {nome}! Bem-vindo aos estudos de C#.");

static bool LerTexto(string mensagem, out string valor)
{
    valor = "";
    while (true)
    {
        Console.Write(mensagem);
        string? linha = Console.ReadLine();
        if (linha is null)
        {
            Console.WriteLine("\nEntrada encerrada.");
            return false;
        }

        valor = linha.Trim();
        if (valor.Length > 0)
            return true;

        Console.WriteLine("Entrada inválida. Digite um texto não vazio.");
    }
}
