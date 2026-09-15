# 17. Preço por faixa

## Enunciado

Aplique descontos diferentes conforme o valor de uma compra. Evite condições sobrepostas.

## Decisões desta implementação

O PDF não fornece valores nem taxas para as faixas. Foram escolhidas as seguintes regras para completar esta resolução:

- Abaixo de R$ 100,00: 0%.
- De R$ 100,00 até menos de R$ 500,00: 5%.
- A partir de R$ 500,00: 10%.

A compra é arredondada para centavos antes de escolher a faixa. Compra e desconto usam AwayFromZero. O maior valor aceito é R$ 1 trilhão. Essas faixas são escolhas desta implementação, não requisitos acrescentados ao texto original.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./17_PrecoFaixa/Exercicio17.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
