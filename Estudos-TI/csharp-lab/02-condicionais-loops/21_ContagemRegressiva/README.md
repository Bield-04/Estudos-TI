# 21. Contagem regressiva

## Enunciado

Mostre uma contagem regressiva de N até 0 e imprima "GO!" no final.

## Decisões desta implementação

Faixa escolhida: 0 a 1000. Não existe espera de um segundo entre linhas: o enunciado pede a sequência, sem exigir temporização.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./21_ContagemRegressiva/Exercicio21.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
