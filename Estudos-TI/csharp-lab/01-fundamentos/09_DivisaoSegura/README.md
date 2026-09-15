# 09. Divisão segura

## Enunciado

Leia dois números e evite divisão por zero. Mostre quociente e resto quando fizer sentido.

## Decisões desta implementação

Aceita números decimais entre -1 trilhão e 1 trilhão e repete a leitura do divisor se ele for zero. Só mostra quociente inteiro e resto quando ambas as entradas são inteiras. A divisão inteira é truncada em direção a zero; o resto acompanha o sinal do dividendo.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./09_DivisaoSegura/Exercicio09.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
