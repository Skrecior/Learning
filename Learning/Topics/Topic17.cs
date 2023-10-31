namespace Learning.Topics
{
    public class Topic17
    {
        public static void Run()
        {
            Console.WriteLine("Provide the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num >= 0)
            {
                sum += num;
                num--;

            }
            Console.WriteLine(sum);
        }
    }
}
