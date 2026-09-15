# 26. Menu persistente

## Enunciado

Crie um menu que só encerra quando o usuário escolher sair. Cada opção chama uma operação diferente.

## Decisões desta implementação

Operações escolhidas: saudação, soma e paridade. Todas retornam ao menu. A opção 0 encerra. Fim do fluxo de entrada também encerra de maneira controlada, inclusive durante uma operação.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./26_MenuPersistente/Exercicio26.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
