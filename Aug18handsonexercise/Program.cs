namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter the characters");
            i=Convert.ToChar(Console.ReadLine());
            j=Convert.ToChar(Console.ReadLine());
            if (i == j)
            {
                Console.WriteLine("Characters are same");
               
            }
            else
            {
                Console.WriteLine("Characters are not same");
                
            }
            Console.ReadLine();
        }
    }
}