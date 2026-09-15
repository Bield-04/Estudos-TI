# 10. Bit a bit

## Enunciado

Receba dois inteiros pequenos e mostre AND, OR, XOR e deslocamentos. Escreva no README o que cada operador faz.

## Decisões desta implementação

Os dois valores ficam entre 0 e 255, mas são armazenados em int. Todos os deslocamentos usam uma posição. A apresentação binária tem pelo menos oito dígitos; um resultado maior usa os dígitos necessários.

| Operador | Efeito em cada posição de bit |
| --- | --- |
| `&` (AND) | Produz 1 quando os dois bits são 1. |
| `\|` (OR) | Produz 1 quando pelo menos um bit é 1. |
| `^` (XOR) | Produz 1 quando os bits são diferentes. |
| `<< 1` | Desloca os bits uma posição à esquerda e preenche com zero à direita. |
| `>> 1` | Desloca uma posição à direita. Para int com sinal, replica o bit de sinal; neste exercício os valores são não negativos. |

As operações são feitas sobre int de 32 bits; não há conversão do resultado para byte.

## Executar

Dentro desta pasta, com o SDK do .NET 10 instalado:

```bash
dotnet run
```

Ou, a partir da pasta principal do pacote:

```bash
dotnet run --project ./10_BitABit/Exercicio10.csproj
```

Os arquivos deste projeto são independentes dos outros exercícios. As funções de leitura no fim do `Program.cs` pedem uma nova entrada quando o formato ou a faixa são inválidos. Elas encerram a leitura quando o fluxo termina (Ctrl+D no terminal Linux).

Para números fracionários, use vírgula ou ponto decimal, sem separador de milhares nem notação científica. Consulte o README principal e `TESTES.md` para os detalhes da validação realizada.
