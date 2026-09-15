# 23. MDC e MMC

## Enunciado

Implemente o algoritmo de Euclides para MDC e derive o MMC.

## Decisões desta implementação

Aceita negativos e calcula com valores absolutos em long. Convenções: MDC(0, 0) = 0; MMC é zero se uma entrada for zero. Para entradas não nulas, divide pelo MDC antes de multiplicar. Todas as combinações de duas entradas int cabem em long nesta operação.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./23_MdcMmc/Exercicio23.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
