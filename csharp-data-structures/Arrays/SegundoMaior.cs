namespace csharp-data-structures.Arrays;

public static class SegundoMaior
{
    public static int Encontrar(int[] numeros)
    {
        int maior = int.MinValue;
        int segundoMaior = int.MinValue;

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                segundoMaior = maior;
                maior = numero;
            }
            else if (numero != maior && numero > segundoMaior)
            {
                segundoMaior = numero;
            }
        }

        if (segundoMaior == int.MinValue)
            throw new InvalidOperationException("Não existe um segundo maior elemento distinto.");

        return segundoMaior;
    }
}