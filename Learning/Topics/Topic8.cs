namespace Learning.Topics
{
    public class Topic8
    {
        public static void Run()
        {
            Console.WriteLine("Provide the number of wins:");
            int wins = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Provide the number of ties:");
            int ties = Convert.ToInt32(Console.ReadLine());

            double winsScore = wins;
            double tiesScore = ties * 0.5;
            double score = tiesScore + winsScore;
            Console.WriteLine($"Score: {score} ");
        }
    }
}
