# Validação da entrega

Foram compilados **28 projetos**, com **zero erros e zero avisos**, e executados **129 cenários aprovados** sobre os programas compilados.

- SDK utilizado na verificação: .NET 10.0.401, em Linux x64.
- Configuração: Release, nullable habilitado e checagem de overflow inteiro habilitada.
- Cada cenário envia entradas ao executável real e compara saídas e encerramento. Não se trata apenas de revisão estática do código.
- Todos os 28 programas foram verificados também com fim da entrada antes do primeiro valor, sem ficarem presos em repetição.
- O jogo de adivinhação foi verificado com sorteios reais, palpites crescentes e decrescentes, contagem de tentativas e direção das mensagens.

Esses testes cobrem os casos descritos abaixo; não representam prova de correção para toda entrada possível.

Para reproduzir a compilação, na pasta principal:

```bash
dotnet build ./Exercicios_CSharp_01_28.slnx --configuration Release -m:1
```

Para repetir um cenário, execute o projeto e forneça uma entrada por linha. Nas tabelas, `;` separa linhas de entrada e `(vazio)` representa uma linha vazia. O encerramento do fluxo pode ser reproduzido com Ctrl+D no Linux.

## 01. Olá, usuário

3 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Nome simples | Gabriel | Olá, Gabriel! |
| Nome vazio e espaços externos |    ;   José da Silva   | Entrada inválida. / Olá, José da Silva! |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 02. Idade futura

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Idade 13 | 13 | Daqui a 5 anos: 18 anos. / Daqui a 10 anos: 23 anos. / Daqui a 20 anos: 33 anos. |
| Limite superior da idade atual | 150 | Daqui a 20 anos: 170 anos. |
| Texto, idade negativa e nova entrada | abc; -1; 0 | Entrada inválida. / Idade atual: 0 anos. / Daqui a 20 anos: 20 anos. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 03. Conversor de temperatura

5 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Celsius zero | 0 | Fahrenheit: 32,00 °F / Kelvin: 273,15 K |
| Temperatura fracionária com vírgula | 36,5 | Fahrenheit: 97,70 °F / Kelvin: 309,65 K |
| Temperatura negativa com ponto | -40.0 | Fahrenheit: -40,00 °F / Kelvin: 233,15 K |
| Texto, vazio e NaN recusados | abc; (vazio); NaN; 10.5 | Entrada inválida. / Fahrenheit: 50,90 °F / Kelvin: 283,65 K |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 04. Média de notas

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Quatro notas | 8; 7; 9; 6 | Média: 7,50 |
| Notas nos dois limites | 0; 10; 0; 10 | Média: 5,00 |
| Nota fora da escala e frações | 11; 7,5; 8.5; 9; 10 | Entrada inválida. / Média: 8,75 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 05. Troca de valores

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Troca positiva e negativa | 7; -2 | Com auxiliar: primeiro = -2; segundo = 7 / Com tupla: primeiro = -2; segundo = 7 |
| Troca dos limites de int | -2147483648; 2147483647 | Com tupla: primeiro = 2147483647; segundo = -2147483648 |
| Valores iguais | 0; 0 | Com auxiliar: primeiro = 0; segundo = 0 / Com tupla: primeiro = 0; segundo = 0 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 06. IMC matemático

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Cálculo matemático | 80; 2 | IMC matemático: 20,00 |
| Altura com vírgula | 70; 1,75 | IMC matemático: 22,86 |
| Peso e altura zero recusados | 0; 80; 0; 2 | Entrada inválida. / IMC matemático: 20,00 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 07. Segundos para horário

5 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Hora com segundos | 3661 | Formato: 01:01:01 |
| Mais de um dia | 90061 | Formato: 25:01:01 |
| Zero | 0 | Formato: 00:00:00 |
| Limite de long | 9223372036854775807 | Horas: 2562047788015215; minutos: 30; segundos: 7 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 08. Dinheiro

5 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Preço fracionário e desconto | 19,90; 3; 10 | Subtotal: R$ 59,70 / Desconto: R$ 5,97 / Total: R$ 53,73 |
| Desconto integral | 100; 2; 100 | Total: R$ 0,00 |
| Arredondamento após o produto | 0.105; 3; 0 | Subtotal: R$ 0,32 / Total: R$ 0,32 |
| Quantidade zero | 99; 0; 10 | Subtotal: R$ 0,00 / Total: R$ 0,00 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 09. Divisão segura

6 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Divisão com resto | 7; 3 | Quociente inteiro: 2 / Resto: 1 |
| Divisão negativa | -7; 3 | Quociente inteiro: -2 / Resto: -1 |
| Números fracionários | 7,5; 2.5 | Resultado da divisão: 3 / a entrada contém fração. |
| Divisor zero e nova leitura | 8; 0; 4 | Divisão por zero não é permitida. / Quociente inteiro: 2 / Resto: 0 |
| Resultado além de decimal | 1000000000000; 0.0000000000000000000000000001 | ultrapassou o intervalo numérico de decimal. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 10. Bit a bit

3 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Operações com 5 e 3 | 5; 3 | A & B (AND): 1 / A \| B (OR): 7 / A ^ B (XOR): 6 / A << 1: 10 / A >> 1: 2 |
| Deslocamento além de oito bits | 255; 0 | A << 1: 510 (binário 111111110) / A >> 1: 127 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 11. Par ou ímpar

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Zero é par | 0 | Par. |
| Ímpar negativo | -3 | Ímpar. |
| Menor int é par | -2147483648 | Par. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 12. Casas de um número

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Quatro dígitos | 9876 | Milhar: 9 / Centena: 8 / Dezena: 7 / Unidade: 6 |
| Zero | 0 | Milhar: 0 / Centena: 0 / Dezena: 0 / Unidade: 0 |
| Fora da faixa e valor com zero interno | 10000; 1001 | Entrada inválida. / Milhar: 1 / Centena: 0 / Dezena: 0 / Unidade: 1 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 13. Classificador de número

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Positivo par | 4 | Positivo. / Par. |
| Negativo ímpar | -7 | Negativo. / Ímpar. |
| Zero | 0 | Zero. / Par. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 14. Maior de três

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Três negativos | -4; -9; -2 | Maior: -2 / Menor: -9 |
| Três iguais | 5; 5; 5 | Maior: 5 / Menor: 5 |
| Valores fracionários | 0.5; -0,75; 0 | Maior: 0,5 / Menor: -0,75 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 15. Calculadora com menu

9 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Soma | 1; 3; 4 | Resultado: 7 |
| Subtração | 2; 3; 4 | Resultado: -1 |
| Multiplicação | 3; 2,5; 4 | Resultado: 10 |
| Divisão | 4; 7; 2 | Resultado: 3,5 |
| Potência | 5; 2; 10 | Resultado: 1024 |
| Divisor zero | 4; 5; 0; 2 | Divisão por zero não é permitida. / Resultado: 2,5 |
| Potência sem resultado real | 5; -1; 0,5 | não é um número real finito |
| Potência além do intervalo | 5; 10; 400 | não é um número real finito |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 16. Ano bissexto

6 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Ano 2000 | 2000 | 2000 é bissexto. |
| Ano 1900 | 1900 | 1900 não é bissexto. |
| Ano 2024 | 2024 | 2024 é bissexto. |
| Ano 2023 | 2023 | 2023 não é bissexto. |
| Ano 2100 | 2100 | 2100 não é bissexto. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 17. Preço por faixa

7 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Limite de faixa: 0 | 0 | Desconto percentual: 0% / Total: R$ 0,00 |
| Limite de faixa: 99,99 | 99,99 | Desconto percentual: 0% / Total: R$ 99,99 |
| Limite de faixa: 100 | 100 | Desconto percentual: 5% / Total: R$ 95,00 |
| Limite de faixa: 499,99 | 499,99 | Desconto percentual: 5% / Total: R$ 474,99 |
| Limite de faixa: 500 | 500 | Desconto percentual: 10% / Total: R$ 450,00 |
| Valor arredondado antes da faixa | 99.995 | Compra: R$ 100,00 / Desconto percentual: 5% |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 18. Tabuada

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Tabuada de três | 3 | 3 x 1 = 3 / 3 x 10 = 30 |
| Maior int sem estouro | 2147483647 | 2147483647 x 10 = 21474836470 |
| Tabuada negativa | -4 | -4 x 10 = -40 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 19. Somatório

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Somatório de dez | 10 | Soma com loop: 55 / Soma com fórmula: 55 / Resultados iguais. |
| Soma vazia | 0 | Soma com loop: 0 / Soma com fórmula: 0 |
| Limite superior | 1000000 | Soma com loop: 500000500000 / Soma com fórmula: 500000500000 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 20. Fatorial

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Fatorial de zero | 0 | 0! = 1 / int comporta até 12! = 479001600; 13! excede int. / long comporta até 20! = 2432902008176640000; 21! excede long. |
| Fatorial de cinco | 5 | 5! = 120 |
| Limite de long e recusa de 21 | 21; 20 | Entrada inválida. / 20! = 2432902008176640000 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 21. Contagem regressiva

3 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Contagem de três | 3 | 3 / 2 / 1 / 0 / GO! |
| Contagem de zero | 0 | 0 / GO! |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 22. Números primos

5 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Primo e listagem | 29; 30 | 29 é primo. / 2 3 5 7 11 13 17 19 23 29 |
| Um não é primo; lista vazia | 1; 1 | 1 não é primo. / Nenhum. |
| Quadrado composto | 49; 2 | 49 não é primo. / Primos até 2: / 2 /  |
| Maior int, sem overflow no divisor | 2147483647; 0 | 2147483647 é primo. / Nenhum. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 23. MDC e MMC

6 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Euclides comum | 48; 18 | MDC: 6 / MMC: 144 |
| Sinais distintos | -48; 18 | MDC: 6 / MMC: 144 |
| Uma entrada zero | 0; 15 | MDC: 15 / MMC: 0 |
| Duas entradas zero | 0; 0 | MDC: 0 / MMC: 0 |
| Limites opostos de int | -2147483648; 2147483647 | MDC: 1 / MMC: 4611686016279904256 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 24. Fibonacci

5 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Dez termos e limite 20 | 10; 20 | Sequência por quantidade: / 0 1 1 2 3 5 8 13 21 34 /  / Sequência por limite: / 0 1 1 2 3 5 8 13 /  |
| Quantidade zero e limite zero | 0; 0 | (sequência vazia) / Sequência por limite: / 0 /  |
| Um termo e limite um | 1; 1 | Sequência por quantidade: / 0 /  / Sequência por limite: / 0 1 1 /  |
| 93 termos e maior long | 93; 9223372036854775807 | 7540113804746346429 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 25. Adivinhação

3 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Sorteio com palpites crescentes e três erros de entrada | abc; 0; 101; depois 1 a 100 | Acertou! / Entrada inválida. |
| Sorteio com palpites decrescentes | 100 a 1 | Acertou! |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 26. Menu persistente

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Executar todas as operações e sair | 1; Gabriel; 2; 3,5; 4.5; 3; -3; 0 | Olá, Gabriel! / Soma: 8 / Ímpar. / Programa encerrado. |
| Opção inválida e retorno ao menu | 9; 3; 4; 0 | Entrada inválida. / Par. / Programa encerrado. |
| Fim da entrada durante a soma | 2; 5 | Entrada encerrada. |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 27. Padrões com loops

4 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Triângulos de altura três | 3 | Crescente: / * / ** / *** /  / Decrescente: / *** / ** / * /  |
| Triângulos de altura um | 1 | Crescente: / * / Decrescente: / * /  |
| Altura inválida e nova tentativa | 0; 51; 2 | Entrada inválida. / Crescente: / * / ** /  |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |

## 28. Caixa eletrônico

6 cenários aprovados.

| Cenário | Entradas | Verificação |
| --- | --- | --- |
| Todas as notas e valor exato | 187 | Nota de R$ 100: 1 / Nota de R$ 50: 1 / Nota de R$ 20: 1 / Nota de R$ 10: 1 / Nota de R$ 5: 1 / Nota de R$ 2: 1 / Resto da estratégia gulosa: R$ 0 |
| Resto guloso apesar de alternativa exata | 6 | Nota de R$ 5: 1 / Nota de R$ 2: 0 / Valor distribuído: R$ 5 / Resto da estratégia gulosa: R$ 1 |
| Valor zero | 0 | Nota de R$ 100: 0 / Nota de R$ 2: 0 / Valor distribuído: R$ 0 / Resto da estratégia gulosa: R$ 0 |
| Valor um | 1 | Valor distribuído: R$ 0 / Resto da estratégia gulosa: R$ 1 |
| Maior valor de int | 2147483647 | Nota de R$ 100: 21474836 / Valor distribuído: R$ 2147483647 / Resto da estratégia gulosa: R$ 0 |
| Fim da entrada antes do primeiro valor | Fim do fluxo (Ctrl+D) | Entrada encerrada. |
