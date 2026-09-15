# 20. Fatorial

## Enunciado

Calcule N! para valores pequenos. Descubra em que ponto int e long estouram.

## Decisões desta implementação

A entrada vai de 0 a 20 e 0! vale 1. O programa descobre os limites por comparação antes de multiplicar: int comporta 12!, mas não 13!; long comporta 20!, mas não 21!. Não usa constantes prontas como substituto dessa verificação.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./20_Fatorial/Exercicio20.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
