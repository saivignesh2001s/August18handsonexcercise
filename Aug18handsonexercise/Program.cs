namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the numbers");
            i=Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                Console.WriteLine("zero");
            else if (i % 2 == 0)
            {
                Console.WriteLine("even");
                if (i % 10 == 0)
                {
                    Console.WriteLine("multiple of 10");
                }
                else
                {
                    Console.WriteLine("not a multiple of 10");
                }
                if (i > 100)
                    Console.WriteLine("too large");
            }
            else
            {
                Console.WriteLine("odd");
                Console.WriteLine("not a multiple of 10");
                if (i > 100)
                    Console.WriteLine("too large");

            }
            Console.ReadLine();
        }
    }
}