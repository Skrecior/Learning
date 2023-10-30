namespace Learning.Topics
{
    public class Topic13
    {
        public static void Run()
        {
            Console.WriteLine("Provide your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0 && age <= 11)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("Teen");
            }
            else if (age >= 18 && age <= 64)
            {
                Console.WriteLine("Adult");
            }
        }
    }
}
