# 11. Par ou ímpar

## Enunciado

Dado um inteiro, determine se é par ou ímpar usando operador módulo.

## Decisões desta implementação

Aceita todo o intervalo de int. Zero é par e números negativos também são classificados.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./11_ParImpar/Exercicio11.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
