namespace Learning.Topics
{
    public class Topic19
    {
        public static void Run()
        {
            Welcome();
        }
        private static void Welcome()
        {
            Console.WriteLine("Provide your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");
        }
    }
}
