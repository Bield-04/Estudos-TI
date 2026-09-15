# 13. Classificador de número

## Enunciado

Leia um número e classifique como positivo, negativo ou zero; depois diga se é par ou ímpar.

## Decisões desta implementação

Usa int porque a classificação par/ímpar se aplica a inteiros. Aceita negativos e zero.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./13_ClassificadorNumero/Exercicio13.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
