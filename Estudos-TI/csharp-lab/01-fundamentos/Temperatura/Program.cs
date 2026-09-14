Console.WriteLine("Digite uma temperatura em celcius para que o programa converta em Fareheints e em Kelvins:");
string? input = Console.ReadLine();
double C = int.Parse(input ?? "0");
double K = C + 273.15;
double
F = (C * 1.8) + 32;
Console.WriteLine($"Você Digitou {C}° celcius e convertendo em Kelvins fica {K} K e em Fahrenheit fica {F} °F");

