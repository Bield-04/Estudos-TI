# 25. Adivinhação

## Enunciado

Gere um número aleatório e permita tentativas até acertar. Informe "maior" ou "menor".

## Decisões desta implementação

Intervalo escolhido: 1 a 100, inclusivo. O número é sorteado uma vez por execução. Uma entrada inválida não consome tentativa. A indicação maior/menor se refere ao número secreto em relação ao palpite.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./25_Adivinhacao/Exercicio25.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
