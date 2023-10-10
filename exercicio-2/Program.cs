public class Program
{
    public static void Main(string[] args)
    {

        int numero1, numero2, produto = 0, quociente = 0;
        char sinal = '\0';
        bool numeroValido;

        do
        {
            Console.Write("Digite o primeiro número inteiro: ");
            numeroValido = int.TryParse(Console.ReadLine(), out numero1);
            if (!numeroValido)
            {
                Console.WriteLine("Valor inválido!");
            }
        } while (!numeroValido);

        do
        {
            Console.Write("Digite o segundo número inteiro: ");
            numeroValido = int.TryParse(Console.ReadLine(), out numero2);
            if (!numeroValido)
            {
                Console.WriteLine("Valor inválido!");
            }
        } while (!numeroValido);

        if (numero1 < 0 && numero2 < 0)
        {
            numero1 -= numero1 + numero1;
            numero2 -= numero2 + numero2;
        }
        else if (numero1 < 0)
        {
            sinal = '-';
            numero1 -= numero1 + numero1;
        }
        else if (numero2 < 0)
        {
            sinal = '-';
            numero2 -= numero2 + numero2;
        }

        for (int i = 0; i < numero1; i++)
        {
            produto += numero2;
        }

        if (numero2 > numero1)
        {
            quociente = 0;
            sinal = '\0';
        }
        else
        {
            do
            {
                numero1 -= numero2;
                quociente++;
            } while ((numero1 - numero2) >= 0);
        }

        Console.WriteLine($"Produto: {sinal}{produto}");
        Console.WriteLine($"Quociente: {sinal}{quociente}");

    }
}