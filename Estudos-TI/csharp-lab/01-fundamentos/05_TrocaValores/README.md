# 05. Troca de valores

## Enunciado

Leia dois inteiros e troque seus valores. Faça primeiro com variável auxiliar e depois usando tupla.

## Decisões desta implementação

As duas trocas são demonstradas separadamente, partindo dos mesmos valores. Nenhuma operação aritmética é usada para trocar os inteiros.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./05_TrocaValores/Exercicio05.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
