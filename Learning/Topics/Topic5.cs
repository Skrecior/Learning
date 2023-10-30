namespace Learning.Topics
{
    public class Topic5
    {
        public static void Run()
        {
            int hours = 24;
            int minutes = 60;
            int seconds = 60;

            int secondsInDay = hours * minutes * seconds;
            Console.WriteLine(secondsInDay * 30);
        }
    }
}
