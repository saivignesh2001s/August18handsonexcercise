namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the year");
            i=Convert.ToInt32(Console.ReadLine());
            if (i % 4 == 0) {
                
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                        Console.WriteLine("False");

                }
                else
                    Console.WriteLine("True");

            }
            else
                Console.WriteLine("False");
            Console.ReadLine();

        }
    }
}