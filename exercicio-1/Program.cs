public class Program
{
    public static void Main(string[] args)
    {
        const int TOTAL_NUMEROS = 5;

        int pares = 0, impares, positivos = 0, negativos, zeros = 0, numero;

        for (int i = 0; i < 5; i++)
        {
            bool numeroValido;
            do
            {
                Console.Write("Digite um número inteiro: ");
                numeroValido = int.TryParse(Console.ReadLine(), out numero);
                if (!numeroValido)
                {
                    Console.WriteLine("Valor inválido!");
                }
                else
                {
                    if (numero % 2 == 0)
                    {
                        pares++;
                    }
                    if (numero == 0)
                    {
                        zeros++;
                    }
                    else if (numero > 0)
                    {
                        positivos++;
                    }
                }
            } while (!numeroValido);
        }

        impares = TOTAL_NUMEROS - pares;
        negativos = TOTAL_NUMEROS - (positivos + zeros);

        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Ímpares: " + impares);
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Neutros: " + zeros);
    }
}