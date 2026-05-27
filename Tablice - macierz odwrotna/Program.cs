class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int suma = 0;
        int[,] macierz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                /* Console.Write($" {macierz[i, j]}"); */
                if (i + j == n - 1)
                {
                    macierz[i, j] = 1;

                }
                else
                {
                    macierz[i, j] = 0;

                }
                Console.Write($" {macierz[i, j]}");
            }

            Console.WriteLine();

        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                suma += macierz[i, j];
            }


        }
        Console.WriteLine($"suma: {suma}");
    }
}