namespace Learning.Topics
{
    public class Topic20
    {
        public static void Run()
        {
            Console.WriteLine("Provide the length in feet:");
            double feet = Convert.ToDouble(Console.ReadLine());
            Converter(feet);
        }
        private static void Converter(double value)
        {
            value *= 12;
            Console.WriteLine(value);
        }
    }
}
