# 28. Caixa eletrônico

## Enunciado

Dado um valor inteiro, informe quantas notas de 100, 50, 20, 10, 5 e 2 seriam usadas numa estratégia gulosa.

## Decisões desta implementação

Usa as notas na ordem 100, 50, 20, 10, 5 e 2, com quantidade disponível ilimitada. Aceita valores inteiros não negativos, inclusive zero.

A estratégia gulosa pode deixar resto mesmo quando existe outra combinação exata. Por exemplo, para R$ 6, ela escolhe uma nota de R$ 5 e deixa R$ 1, embora três notas de R$ 2 também somem R$ 6. Esta solução mantém a estratégia pedida e informa a sobra; não afirma que uma sobra prova a impossibilidade do saque. Não faz busca por uma combinação alternativa.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./28_CaixaEletronico/Exercicio28.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
