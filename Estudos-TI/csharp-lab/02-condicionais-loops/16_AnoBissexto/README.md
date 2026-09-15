# 16. Ano bissexto

## Enunciado

Receba um ano e diga se ele é bissexto. Pesquise e escreva a regra correta antes de codar.

## Decisões desta implementação

Regra utilizada, para o calendário gregoriano: um ano é bissexto se for divisível por 400, ou se for divisível por 4 e não por 100. A faixa adotada é de 1 a 9999.

Referência: [DateTime.IsLeapYear - Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/api/system.datetime.isleapyear?view=net-10.0). A solução expressa a regra com operadores, sem chamar o método pronto.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./16_AnoBissexto/Exercicio16.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
