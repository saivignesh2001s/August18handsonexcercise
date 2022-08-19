namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string i, j;
            Console.WriteLine("Enter the strings");
            i=Console.ReadLine();
            j=Console.ReadLine();
            bool res;
            res=i.Equals(j);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}