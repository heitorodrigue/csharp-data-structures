namespace CSharpDataStructures.Strings;

public static class PrimeiroCaractereUnico
{
    public static char Encontrar(string texto)
    {
        Dictionary<char, int> frequencia = new();

        foreach (char caractere in texto)
        {
            if (frequencia.ContainsKey(caractere))
            {
                frequencia[caractere]++;
            }
            else
            {
                frequencia[caractere] = 1;
            }
        }

        foreach (char caractere in texto)
        {
            if (frequencia[caractere] == 1)
            {
                return caractere;
            }
        }

        return '\0';
    }
}