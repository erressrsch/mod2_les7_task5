namespace mod2_les7_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("You can become an MP");
            }
            if (age >= 30)
            {
                Console.WriteLine("You can become a Senator");

            }
            if (age >= 30)
            {
                Console.WriteLine("You can become Prime Minister");
            }
            if (age >= 35)
            {
                Console.WriteLine("You can become President");
            }
        }
    }
}
