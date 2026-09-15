// Exercício 10 - Bit a bit
// Receba dois inteiros pequenos e mostre AND, OR, XOR e deslocamentos. Escreva no README o que cada operador faz.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Primeiro inteiro (0 a 255): ", out int a, 0, 255)
    || !LerInteiro("Segundo inteiro (0 a 255): ", out int b, 0, 255))
    return;

Mostrar("A", a);
Mostrar("B", b);
Mostrar("A & B (AND)", a & b);
Mostrar("A | B (OR)", a | b);
Mostrar("A ^ B (XOR)", a ^ b);
Mostrar("A << 1", a << 1);
Mostrar("A >> 1", a >> 1);
Mostrar("B << 1", b << 1);
Mostrar("B >> 1", b >> 1);

static void Mostrar(string nome, int valor)
{
    string binario = Convert.ToString(valor, 2).PadLeft(8, '0');
    Console.WriteLine($"{nome}: {valor} (binário {binario})");
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
