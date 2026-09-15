# 12. Casas de um número

## Enunciado

Receba um inteiro positivo de 0 a 9999 e separe unidade, dezena, centena e milhar usando divisão e módulo.

## Decisões desta implementação

O enunciado chama o número de positivo, mas inclui zero na faixa. Esta implementação segue a faixa explícita: 0 a 9999.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./12_CasasNumero/Exercicio12.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
