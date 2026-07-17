using CSharpDataStructures.Arrays;
using CSharpDataStructures.Strings;

Console.WriteLine("===== csharp-data-structures =====");

Console.WriteLine();

int[] numeros = { 10, 25, 5, 42 };

Console.WriteLine("Exercício 1 - Segundo Maior");

Console.WriteLine($"Resultado: {SegundoMaior.Encontrar(numeros)}");

Console.WriteLine();

string texto = "programacao";

char resultadoCaractere = PrimeiroCaractereUnico.Encontrar(texto);

Console.WriteLine("Exercício 2 - Primeiro Caractere Único");

if (resultadoCaractere == '\0')
{
    Console.WriteLine("Nenhum caractere único encontrado.");
}
else
{
    Console.WriteLine($"Resultado: {resultadoCaractere}");
}

Console.WriteLine();

int[] resultadoTwoSum = TwoSum.Encontrar(new int[] { 2, 7, 11, 15 }, 9);

Console.WriteLine("Exercício 3 - Two Sum");
Console.WriteLine($"Resultado: [{resultadoTwoSum[0]}, {resultadoTwoSum[1]}]");
