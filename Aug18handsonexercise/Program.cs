namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s = " ";
            int sum = 100;
            for(i = 0; i < 4; i++)
            {
                s=Console.ReadLine();
                if (s.Equals("HIT")){
                    sum += 10;
                }
                else if (s.Equals("MISS")){
                    sum -= 20;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}