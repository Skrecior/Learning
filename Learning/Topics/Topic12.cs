namespace Learning.Topics
{
    public class Topic12
    {
        public static void Run()
        {
            Console.WriteLine("Provide the color:");
            string color = Console.ReadLine();

            if (color == "green")
            {
                Console.WriteLine("box #2");
            }
            else if (color == "red")
            {
                Console.WriteLine("box #1");
            }
            else if (color == "black")
            {
                Console.WriteLine("box #3");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
