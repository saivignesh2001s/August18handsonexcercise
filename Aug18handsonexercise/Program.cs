namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter the numbers");
            i=Convert.ToInt32(Console.ReadLine());
            j=Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine("{0} is max", i);
                Console.WriteLine("{0} is min", j);
            }
            else if (i == j)
                Console.WriteLine("{0} is equals {1}", i, j);
            else
            {
                Console.WriteLine("{0} is max", j);
                Console.WriteLine("{0} is min", i);
            }
        }
    }
}