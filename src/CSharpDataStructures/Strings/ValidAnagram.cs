namespace CSharpDataStructures.Strings;

public static class ValidAnagram
{
	public static bool SaoAnagramas(string texto, string frase)
	{
		Dictionary<char, int> frequencia = new();
		
		if (texto.Length != frase.Length)
		{
			return false;
		}

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

		foreach (char caractere in frase)
		{
			if (!frequencia.ContainsKey(caractere))
			{
				return false;
			}

			frequencia[caractere]--;

			if (frequencia[caractere] < 0)
			{
				return false;
			}
		}

		return frequencia.Values.All(v => v == 0);
	}
}