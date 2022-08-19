namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the numbers");
            n=Convert.ToInt32(Console.ReadLine());
           
            while (n > 0)
            {
                int i;
                i = n % 10;
                Console.Write(i);
                n = n / 10;
            }
            Console.ReadLine();
        }
    }
}