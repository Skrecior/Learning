namespace Learning.Topics
{
    public class Topic6
    {
        public static void Run()
        {
            int items = 200;
            int itemInBox = 9;

            int left = items % itemInBox;
            Console.WriteLine(left);
        }
    }
}
