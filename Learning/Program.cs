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
        case 9:
            Topic9.Run();
            break;
        case 10:
            Topic10.Run();
            break;
        case 11:
            Topic11.Run();
            break;
        case 12:
            Topic12.Run();
            break;
        case 13:
            Topic13.Run();
            break;
        case 14:
            Topic14.Run();
            break;
        case 15:
            Topic15.Run();
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
    Console.WriteLine("9 - Topic 9");
    Console.WriteLine("10 - Topic 10");
    Console.WriteLine("11 - Topic 11");
    Console.WriteLine("12 - Topic 12");
    Console.WriteLine("13 - Topic 13");
    Console.WriteLine("14 - Topic 14");
    Console.WriteLine("15 - Topic 15");
    Console.WriteLine("0 - End");

    string input = Console.ReadLine();

    if (short.TryParse(input, out number)) { }
    else
    {
        Console.WriteLine("Failed to convert the string to an integer.");
        number = -1;
    }

}
