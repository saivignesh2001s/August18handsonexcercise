namespace Aug18handsonexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the numbers");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Zero\n 2.Even/odd\n 3.multiple of 10\n 4.toolarge\n");
            int input=0;
            while (input < 4){
                switch (input) {
                    case 0:
                        if (i == 0)
                            Console.WriteLine("zero");
                        break;
                    case 1:
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("even");
                        }
                        else
                            Console.WriteLine("odd");

                        break;
                    case 2:
                        if (i % 10 != 0)
                        {
                            Console.WriteLine("not a multiple of 10");

                        }
                        else
                        {
                            Console.WriteLine("multiple of 10");

                        }
                        break;
                    case 3:
                        if (i > 100)
                            Console.WriteLine("too large");
                        break;
                    default:
                        break;
                        


                }
                input++;
            }
            Console.ReadLine();
        }
    }
}