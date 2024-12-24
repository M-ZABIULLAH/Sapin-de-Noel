class Program
{
    static void Main()
    {
        Console.Write("Entrez la hauteur du sapin: ");
        int height = int.Parse(Console.ReadLine());
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            for (int i = 1; i <= height; i++)
            {
                Console.Write(new string(' ', height - i));
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (random.Next(0, 5) == 0)
                    {
                        Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
                        Console.Write("O");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }

            for (int i = 0; i < height / 3; i++)
            {
                Console.Write(new string(' ', height - 1));
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("|||");
            }
            Console.ResetColor();

            Thread.Sleep(950);
        }
    }
}