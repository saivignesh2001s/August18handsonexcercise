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
            k= Convert.ToInt32(Console.ReadLine());
            int sum;
            float avg;
             sum = i + j + k;
            avg = sum / 3;
            if (avg < 35)
            {
                Console.WriteLine("Fail");
                
            }
            else if (avg>35 && avg<45)
                Console.WriteLine("third");
            else if (avg > 45 && avg < 60)
                Console.WriteLine("second");
            else
            {
                Console.WriteLine("first");
            }
            Console.ReadLine();
        }
    }
}