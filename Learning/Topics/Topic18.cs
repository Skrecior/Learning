namespace Learning.Topics
{
    public class Topic18
    {
        public static void Run()
        {
            int num = 1;

            for (int i = 1; i <= 100; i++)
            {
                if (num > 10000)
                {
                    break;
                }


                num *= i;
            }
            Console.WriteLine(num);
        }
    }
}
