# 15. Calculadora com menu

## Enunciado

Use switch para escolher soma, subtração, multiplicação, divisão ou potência.

## Decisões desta implementação

Executa uma operação por vez; um menu que se repete é a atividade 26. Na potência, o primeiro número é a base e o segundo é o expoente. Resultados não finitos são informados sem serem apresentados como cálculos válidos.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./15_CalculadoraMenu/Exercicio15.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
