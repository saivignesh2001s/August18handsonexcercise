namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the numbers");
            n=Convert.ToInt32(Console.ReadLine());
            int i,j=1, sum = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(j);
                sum = sum + j;
                j = j + 2;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}