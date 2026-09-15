# 04. Média de notas

## Enunciado

Leia 4 notas, calcule média simples e imprima com duas casas decimais.

## Decisões desta implementação

Escala adotada: notas entre 0 e 10. A média usa decimal e é apresentada com duas casas decimais.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./04_MediaNotas/Exercicio04.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
