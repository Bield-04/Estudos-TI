// Exercício 26 - Menu persistente
// Crie um menu que só encerra quando o usuário escolher sair. Cada opção chama uma operação diferente.
using System;
using System.Globalization;

// Entrada aceita ponto ou vírgula; a saída usa o formato brasileiro.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

while (true)
{
    Console.WriteLine("\n1 - Saudação");
    Console.WriteLine("2 - Somar dois números");
    Console.WriteLine("3 - Verificar par ou ímpar");
    Console.WriteLine("0 - Sair");

    if (!LerInteiro("Opção: ", out int opcao, 0, 3))
        return;

    bool continuar;
    switch (opcao)
    {
        case 1:
            continuar = Saudar();
            break;
        case 2:
            continuar = Somar();
            break;
        case 3:
            continuar = VerificarParidade();
            break;
        case 0:
            Console.WriteLine("Programa encerrado.");
            return;
        default:
            continue;
    }

    if (!continuar)
        return;
}

static bool Saudar()
{
    if (!LerTexto("Nome: ", out string nome))
        return false;
    Console.WriteLine($"Olá, {nome}!");
    return true;
}

static bool Somar()
{
    if (!LerReal("Primeiro número: ", out double a)
        || !LerReal("Segundo número: ", out double b))
        return false;

    double resultado = a + b;
    Console.WriteLine(double.IsFinite(resultado)
        ? $"Soma: {resultado}"
        : "A soma ultrapassou o intervalo numérico de double.");
    return true;
}

static bool VerificarParidade()
{
    if (!LerInteiro("Número inteiro: ", out int numero))
        return false;
    Console.WriteLine(numero % 2 == 0 ? "Par." : "Ímpar.");
    return true;
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
