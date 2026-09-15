# 22. Números primos

## Enunciado

Determine se um número é primo. Depois liste os primos até N.

## Decisões desta implementação

A verificação individual aceita todo int; valores menores que 2 não são primos. A listagem usa N entre 0 e 100000. A condição divisor <= número / divisor evita multiplicar divisor por ele mesmo e estourar int.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./22_NumerosPrimos/Exercicio22.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
