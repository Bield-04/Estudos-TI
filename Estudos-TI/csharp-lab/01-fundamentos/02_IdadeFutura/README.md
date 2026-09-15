# 02. Idade futura

## Enunciado

Leia a idade atual e mostre qual será a idade daqui a 5, 10 e 20 anos.

## Decisões desta implementação

Faixa escolhida para a idade atual: 0 a 150 anos, em números inteiros.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./02_IdadeFutura/Exercicio02.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
