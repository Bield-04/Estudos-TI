# 03. Conversor de temperatura

## Enunciado

Converta Celsius para Fahrenheit e Kelvin. Valide a entrada numérica.

## Decisões desta implementação

Aceita casas decimais com vírgula ou ponto. A atividade aplica as fórmulas matemáticas, sem impor limites físicos à temperatura. Não aceita NaN ou infinito.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./03_ConversorTemperatura/Exercicio03.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
