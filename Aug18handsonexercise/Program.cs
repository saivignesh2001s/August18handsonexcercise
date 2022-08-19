namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 0;
            j = 25;

            for (i = 0, j = 25; i < 25 && j >= 0; i++, j--)
            {
                if (i > j)
                {
                    Console.WriteLine("Crossed Over");
                    break;
                }
                Console.WriteLine("{0} {1}", i, j);
               
            }
            Console.ReadLine();
        }
    }
}