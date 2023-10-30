namespace Learning.Topics
{
    public class Topic14
    {
        public static void Run()
        {
            Console.WriteLine("1 - Americano\n2 - Espresso\n3 - Cappuccino");
            Console.WriteLine("Provide the number of the coffee you want to choose:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Americano");
                    break;
                case 2:
                    Console.WriteLine("Espresso");
                    break;
                case 3:
                    Console.WriteLine("Cappuccino");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
