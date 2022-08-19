namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}