namespace ConsoleApp2
{
    internal class GreetingPrgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the total number of your enrolled course: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled courses: " + num);
            Console.WriteLine("Price of my favorite book: " + num1);

            Console.Write("\nPress any key to exit");
            Console.ReadKey();



        }
    }
}