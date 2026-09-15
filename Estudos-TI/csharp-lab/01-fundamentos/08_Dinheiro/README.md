# 08. Dinheiro

## Enunciado

Leia preço e quantidade, calcule subtotal, desconto percentual e total final.

## Decisões desta implementação

O usuário informa o desconto. Preço de 0 a 1 trilhão, quantidade inteira de 0 a 1 milhão e desconto de 0% a 100%. Subtotal e desconto são arredondados para centavos com AwayFromZero, nessa ordem.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./08_Dinheiro/Exercicio08.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
