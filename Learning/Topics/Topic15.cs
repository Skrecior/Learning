namespace Learning.Topics
{
    public class Topic15
    {
        public static void Run()
        {
            Console.WriteLine("Provide the time:");
            int hour = Convert.ToInt32(Console.ReadLine());
            string output = hour <= 12 ? "AM" : "PM";
            Console.WriteLine(output);
        }
    }
}
