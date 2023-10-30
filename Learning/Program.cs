using Learning.Topics;

Console.WriteLine("Hello, please provide the topic number you are interested in.");
short number;
Menu();

while (number != 0)
{
    switch(number)
    {
        case 1:
            Topic1.Run();
            break;
        case 2:
            Topic2.Run();
            break;
        case 3:
            Topic3.Run();
            break;
        case 4:
            Topic4.Run();
            break;
        case 5:
            Topic5.Run();
            break;
        case 6:
            Topic6.Run();
            break;
        case 7:
            Topic7.Run();
            break;
        case 8:
            Topic8.Run();
            break;
        default:
            Console.WriteLine("Provided number is incorrect.");
            break;
    }

    Console.WriteLine();
    Menu();
    
}
Environment.Exit(1);
void Menu()
{
    Console.WriteLine("1 - Topic 1");
    Console.WriteLine("2 - Topic 2");
    Console.WriteLine("3 - Topic 3");
    Console.WriteLine("4 - Topic 4");
    Console.WriteLine("5 - Topic 5");
    Console.WriteLine("6 - Topic 6");
    Console.WriteLine("7 - Topic 7");
    Console.WriteLine("8 - Topic 8");
    Console.WriteLine("0 - End");

    string input = Console.ReadLine();

    if (short.TryParse(input, out number)) { }
    else
    {
        Console.WriteLine("Failed to convert the string to an integer.");
        number = -1;
    }

}
