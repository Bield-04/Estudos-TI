// Exercício 28 - Caixa eletrônico
// Dado um valor inteiro, informe quantas notas de 100, 50, 20, 10, 5 e 2 seriam usadas numa estratégia gulosa.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

if (!LerInteiro("Valor inteiro em reais (não negativo): ", out int valor, 0))
    return;

int[] notas = { 100, 50, 20, 10, 5, 2 };
int restante = valor;

foreach (int nota in notas)
{
    int quantidade = restante / nota;
    restante %= nota;
    Console.WriteLine($"Nota de R$ {nota}: {quantidade}");
}

Console.WriteLine($"Valor distribuído: R$ {valor - restante}");
Console.WriteLine($"Resto da estratégia gulosa: R$ {restante}");
if (restante != 0)
    Console.WriteLine("A estratégia gulosa não distribuiu o valor completo.");

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
