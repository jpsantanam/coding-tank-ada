public class Program
{
    public static void Main(string[] args)
    {
        string frase;
        string[] palavras, letras;
        int maiusculas = 0, minusculas = 0, inicialMaiuscula = 0, inicialMinuscula = 0, quantidadePalavras;

        Console.WriteLine("Digite uma frase.");
        frase = Console.ReadLine();
        palavras = frase.Split(' ');

        foreach (string palavra in palavras)
        {
            int contMaiusculas = 0;
            foreach (char letra in palavra)
            {
                if (Char.IsUpper(letra))
                {
                    contMaiusculas++;

                }
            }
            if (contMaiusculas == palavra.Length)
            {
                maiusculas++;
            }
            else if (contMaiusculas == 0)
            {
                minusculas++;
            }
            else if (Char.IsUpper(palavra[0]))
            {
                inicialMaiuscula++;
            }
            else if (Char.IsLower(palavra[0]))
            {
                inicialMinuscula++;
            }
        }

        quantidadePalavras = palavras.Length;

        Console.WriteLine($"Maiúsculas: {maiusculas}");
        Console.WriteLine($"Minúsculas: {minusculas}");
        Console.WriteLine($"Iniciam com maiúscula: {inicialMaiuscula}");
        Console.WriteLine($"Iniciam com minúscula: {inicialMinuscula}");
        Console.WriteLine($"Quantidade de palavras digitadas: {quantidadePalavras}");
    }
}