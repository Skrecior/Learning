namespace Learning.Topics
{
    public class Topic16
    {
        public static void Run()
        {
            Console.WriteLine("Provide the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int y = 1;
            for (int i = 1; i <= num; i++)
            {
                y *= i;
            }
            Console.WriteLine(y);
        }
    }
}
