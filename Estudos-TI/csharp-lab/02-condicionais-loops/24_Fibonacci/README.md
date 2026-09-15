# 24. Fibonacci

## Enunciado

Gere os N primeiros termos. Depois faça uma versão que pare ao ultrapassar um limite.

## Decisões desta implementação

Convenção: F0 = 0 e F1 = 1, portanto a sequência começa 0, 1, 1. A primeira versão aceita até 93 termos (F0 a F92). A segunda mostra os termos menores ou iguais ao limite informado; não imprime o termo que ultrapassa o limite. Limite zero produz apenas 0.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./24_Fibonacci/Exercicio24.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
