# 27. Padrões com loops

## Enunciado

Desenhe triângulos de asteriscos, crescente e decrescente, usando loops aninhados.

## Decisões desta implementação

Altura de 1 a 50. Os dois triângulos são alinhados à esquerda e usam loops aninhados, sem construir cada linha com repetição pronta de string.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./27_PadroesLoops/Exercicio27.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
