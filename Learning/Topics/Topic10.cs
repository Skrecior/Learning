namespace Learning.Topics
{
    public class Topic10
    {
        public static void Run()
        {
            Console.WriteLine("Provide the name of the country:");
            string country = Console.ReadLine();
            Console.WriteLine("Provide the name of the capital:");
            string capital = Console.ReadLine();
            Console.WriteLine($"Country: {country}, Capital: {capital}");
        }
    }
}
