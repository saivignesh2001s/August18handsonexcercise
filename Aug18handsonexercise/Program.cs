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
                Console.WriteLine("{0} is biggest", i);
              
            }
            else if (j > i)
                Console.WriteLine("{0} is biggest", j);
            else
            {
                Console.WriteLine("{0} is equals to {i}",i,j);
            }
            Console.ReadLine();
        }
    }
}