namespace HomeTask
{
    internal class Program
    {
        static void main(string[] args)
        {

            Random random = new Random();
            int[][] jaggedArray = new int[5][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[5];
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = random.Next(1, 10);
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sumMain = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (i == 0 || i == jaggedArray.Length - 1 || j == 0 || j == jaggedArray[j].Length - 1)
                    {
                        Console.Write($"{jaggedArray[i][j]} ");
                        sumMain += jaggedArray[i][j];
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of outer Jagged: {sumMain}.");

            int sumInner = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (!(i == 0 || i == jaggedArray.Length - 1 || j == 0 || j == jaggedArray[j].Length - 1))
                    {
                        Console.Write($"{jaggedArray[i][j]} ");
                        sumInner += jaggedArray[i][j];
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of inner Jagged: {sumInner}.");

            if (sumMain > sumInner)
            {
                Console.WriteLine($"Sum of outer Jagged is greater than inner it equals: {sumMain}.");
            }
            else
            {
                Console.WriteLine($"Sum of inner Jagged is greater than outer one it equals: {sumInner}.");
            }
        }
    }
}