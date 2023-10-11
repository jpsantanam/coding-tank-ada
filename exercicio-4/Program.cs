public class Program
{
    public static void Main(string[] args)
    {
        Int32 numero;
        numero = Convert.ToInt16(!(21 > 21));
        Console.WriteLine(numero);
        /* 
         * Resposta: C) 1
         * Declara a variável numero como um inteiro de 32 bits
         * Verifica se 21 é maior que 21 (falso) e inverte o valor booleano (true), converte o valor de "true" para um inteiro de 16 bits (1) e atribui esse valor a numero
         * Imprime o valor de numero (1)
         */
    }
}