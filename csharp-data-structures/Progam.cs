using csharp-data-structures.Arrays;
using csharp-data-structures.Strings;

Console.WriteLine("===== csharp-data-structures =====");

Console.WriteLine();

int[] numeros = { 10, 25, 5, 42 };

Console.WriteLine("Exercício 1 - Segundo Maior");

Console.WriteLine($"Resultado: {SegundoMaior.Encontrar(numeros)}");

Console.WriteLine();

string texto = "programacao";

char resultado = PrimeiroCaractereUnico.Encontrar(texto);

Console.WriteLine("Exercício 2 - Primeiro Caractere Único");

if (resultado == '\0')
{
    Console.WriteLine("Nenhum caractere único encontrado.");
}
else
{
    Console.WriteLine($"Resultado: {resultado}");
}