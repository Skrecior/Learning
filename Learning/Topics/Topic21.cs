namespace Learning.Topics
{
    public class Topic21
    {
        public static void Run()
        {
            Console.WriteLine("Provide width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide length:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Area(width, length));
        }
        private static int Area(int width, int length)
        {
            int result = width * length;
            return result;
        }
    }
}
