# 06. IMC matemático

## Enunciado

Leia peso e altura e calcule o IMC. Neste exercício, foque no cálculo e formatação, não em diagnóstico de saúde.

## Decisões desta implementação

Unidades: quilogramas e metros. Limites escolhidos para o laboratório: peso de 0,01 a 1000 kg e altura de 0,01 a 3 m. A saída é somente o resultado matemático, sem classificação de saúde.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./06_ImcMatematico/Exercicio06.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
