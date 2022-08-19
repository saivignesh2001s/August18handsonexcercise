namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int upper, lower;
            upper=Convert.ToInt32(Console.ReadLine());
            lower=Convert.ToInt32(Console.ReadLine());
            int i,sum=0;
            for (i = upper; i <= lower; i++)
            {
                    sum +=i;
            }
            Console.WriteLine(sum);
            Console.WriteLine("----Problem12-----");
            int j,sum1=0;
            for (j = upper; j <= lower; j++)
            {
                if (j % 9 == 0)
                {
                    Console.WriteLine(j);
                    sum1+= j;
                }
            }
            Console.WriteLine(sum1);
            Console.ReadLine();
        }
    }
}