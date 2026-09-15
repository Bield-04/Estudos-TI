# 19. Somatório

## Enunciado

Some todos os inteiros de 1 até N. Faça com loop e depois compare com a fórmula matemática.

## Decisões desta implementação

N fica entre 0 e 1 milhão. Para N = 0, a soma é zero. Usa long desde a multiplicação da fórmula. O limite mantém a versão com loop rápida no laboratório.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./19_Somatorio/Exercicio19.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
