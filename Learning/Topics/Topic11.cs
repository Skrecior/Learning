namespace Learning.Topics
{
    public class Topic11
    {
        public static void Run()
        {
            Console.WriteLine("Provide your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 19)
            {
                Console.WriteLine("Take your kindle");
            }
        }
    }
}
