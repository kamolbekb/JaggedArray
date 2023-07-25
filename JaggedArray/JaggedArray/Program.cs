namespace HomeTask
{
    internal class Program
    {
        static void main(string[] args)
        {
            Random random = new Random();

            int[][] jaggedArray = new int[random.Next(3, 5)][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[(random.Next(3, 7))];
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = random.Next(1, 10);
                }
            }
            int odd = 0;
            int even = 0;
            for (int i = 0; i < jaggedArray.Length; i++)

            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($" {jaggedArray[i][j]}");
                    if (jaggedArray[i][j] % 2 == 0)
                    {
                        even += jaggedArray[i][j];
                    }
                    else
                    {
                        odd += jaggedArray[i][j];
                    }
                }
                Console.WriteLine();
            }
            if (even > odd)
            {
                Console.WriteLine($"Sum of evens is greater than odds, it equals {even}.");
            }
            else
            {
                Console.WriteLine($"Sum of odds is greater than evens, it equals {odd}.");
            }

        }
    }
}