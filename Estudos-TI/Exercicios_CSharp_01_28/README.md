# Exercícios C# 01 a 28

Resoluções completas recriadas para Gabriel, a partir dos exercícios 01 a 28 do documento **Plano_de_Estudos_Backend_NET_Caderno_CSharp.pdf**, páginas 5, 7 e 8.

São novas implementações para substituir os arquivos perdidos. Não são uma recuperação dos arquivos corrompidos, e podem ter organização e escolhas diferentes das suas versões anteriores. Cada pasta contém o enunciado, as decisões adotadas, um `Program.cs` completo e seu projeto `.csproj`.

## Começar

1. Extraia o ZIP para uma pasta de sua escolha.
2. Abra a pasta `Exercicios_CSharp_01_28` no VS Code ou no Neovim.
3. Use o **SDK do .NET 10** para compilar e executar. Não há pacotes NuGet externos.
4. Execute um projeto por vez. Por exemplo, o exercício de idade:

```bash
dotnet run --project ./02_IdadeFutura/Exercicio02.csproj
```

Para conferir a compilação dos 28 projetos de uma vez:

```bash
dotnet build ./Exercicios_CSharp_01_28.slnx --configuration Release -m:1
```

Também é possível entrar na pasta de qualquer exercício e executar `dotnet run`. Cada pasta é um projeto independente; mantenha seu `Program.cs` junto do `.csproj` correspondente.

## Entradas e saídas

- Entradas inválidas são recusadas e solicitadas novamente.
- Nos campos fracionários, ponto e vírgula funcionam como separadores decimais. Não use separadores de milhares nem notação científica.
- A saída usa o formato brasileiro: vírgula decimal.
- Fim do fluxo de entrada encerra o programa de maneira controlada. No terminal Linux, isso pode ser sinalizado com Ctrl+D.
- Os limites de entrada e as regras não especificadas pelo PDF estão documentados em cada README. Não são apresentados como exigências do enunciado original.
- O exercício 17 usa faixas de desconto escolhidas para esta implementação. O exercício 28 segue a estratégia gulosa e mostra o valor restante, se houver.

## Índice

| Nº | Exercício | Código |
| --- | --- | --- |
| 01 | [Olá, usuário](01_OlaUsuario/README.md) | [Program.cs](01_OlaUsuario/Program.cs) |
| 02 | [Idade futura](02_IdadeFutura/README.md) | [Program.cs](02_IdadeFutura/Program.cs) |
| 03 | [Conversor de temperatura](03_ConversorTemperatura/README.md) | [Program.cs](03_ConversorTemperatura/Program.cs) |
| 04 | [Média de notas](04_MediaNotas/README.md) | [Program.cs](04_MediaNotas/Program.cs) |
| 05 | [Troca de valores](05_TrocaValores/README.md) | [Program.cs](05_TrocaValores/Program.cs) |
| 06 | [IMC matemático](06_ImcMatematico/README.md) | [Program.cs](06_ImcMatematico/Program.cs) |
| 07 | [Segundos para horário](07_SegundosHorario/README.md) | [Program.cs](07_SegundosHorario/Program.cs) |
| 08 | [Dinheiro](08_Dinheiro/README.md) | [Program.cs](08_Dinheiro/Program.cs) |
| 09 | [Divisão segura](09_DivisaoSegura/README.md) | [Program.cs](09_DivisaoSegura/Program.cs) |
| 10 | [Bit a bit](10_BitABit/README.md) | [Program.cs](10_BitABit/Program.cs) |
| 11 | [Par ou ímpar](11_ParImpar/README.md) | [Program.cs](11_ParImpar/Program.cs) |
| 12 | [Casas de um número](12_CasasNumero/README.md) | [Program.cs](12_CasasNumero/Program.cs) |
| 13 | [Classificador de número](13_ClassificadorNumero/README.md) | [Program.cs](13_ClassificadorNumero/Program.cs) |
| 14 | [Maior de três](14_MaiorMenorTres/README.md) | [Program.cs](14_MaiorMenorTres/Program.cs) |
| 15 | [Calculadora com menu](15_CalculadoraMenu/README.md) | [Program.cs](15_CalculadoraMenu/Program.cs) |
| 16 | [Ano bissexto](16_AnoBissexto/README.md) | [Program.cs](16_AnoBissexto/Program.cs) |
| 17 | [Preço por faixa](17_PrecoFaixa/README.md) | [Program.cs](17_PrecoFaixa/Program.cs) |
| 18 | [Tabuada](18_Tabuada/README.md) | [Program.cs](18_Tabuada/Program.cs) |
| 19 | [Somatório](19_Somatorio/README.md) | [Program.cs](19_Somatorio/Program.cs) |
| 20 | [Fatorial](20_Fatorial/README.md) | [Program.cs](20_Fatorial/Program.cs) |
| 21 | [Contagem regressiva](21_ContagemRegressiva/README.md) | [Program.cs](21_ContagemRegressiva/Program.cs) |
| 22 | [Números primos](22_NumerosPrimos/README.md) | [Program.cs](22_NumerosPrimos/Program.cs) |
| 23 | [MDC e MMC](23_MdcMmc/README.md) | [Program.cs](23_MdcMmc/Program.cs) |
| 24 | [Fibonacci](24_Fibonacci/README.md) | [Program.cs](24_Fibonacci/Program.cs) |
| 25 | [Adivinhação](25_Adivinhacao/README.md) | [Program.cs](25_Adivinhacao/Program.cs) |
| 26 | [Menu persistente](26_MenuPersistente/README.md) | [Program.cs](26_MenuPersistente/Program.cs) |
| 27 | [Padrões com loops](27_PadroesLoops/README.md) | [Program.cs](27_PadroesLoops/Program.cs) |
| 28 | [Caixa eletrônico](28_CaixaEletronico/README.md) | [Program.cs](28_CaixaEletronico/Program.cs) |

## Validação

O arquivo `TESTES.md` registra a compilação e os cenários executados nesta entrega. As pastas `bin` e `obj` são geradas novamente na sua máquina e não fazem parte do ZIP.

## Documentação oficial

- [C# - referência da linguagem](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/)
- [.NET CLI - dotnet run](https://learn.microsoft.com/pt-br/dotnet/core/tools/dotnet-run)
- [.NET CLI - dotnet build](https://learn.microsoft.com/pt-br/dotnet/core/tools/dotnet-build)
- [Operadores bit a bit e deslocamentos](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators)
- [Int32.TryParse](https://learn.microsoft.com/pt-br/dotnet/api/system.int32.tryparse?view=net-10.0)
- [Double.TryParse](https://learn.microsoft.com/pt-br/dotnet/api/system.double.tryparse?view=net-10.0)
- [DateTime.IsLeapYear](https://learn.microsoft.com/pt-br/dotnet/api/system.datetime.isleapyear?view=net-10.0)
