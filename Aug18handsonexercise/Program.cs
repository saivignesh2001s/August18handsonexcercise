namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j,k;
            Console.WriteLine("Enter the numbers");
            i=Convert.ToInt32(Console.ReadLine());
            j=Convert.ToInt32(Console.ReadLine());
            k=Convert.ToInt32(Console.ReadLine());
            if(i>=j && i >= k)
            {
                Console.WriteLine("{0} is largest", i);
            }
            if(j>i && j>k)
            {
                Console.WriteLine("{0} is largest", j);
            
        }
            else
            {
                Console.WriteLine("{0} is largest", k);
            
        }
            Console.ReadLine();


        }
    }
}