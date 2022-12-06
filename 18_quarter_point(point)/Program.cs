void SearthPoint(int quarter)
{
    switch (quarter)
    {
        case 1:
            Console.WriteLine("Point in x > 0 and y > 0");
            break;
        case 2:
            Console.WriteLine("Point in x < 0 and y > 0");
            break;
        case 3:
            Console.WriteLine("Point in x < 0 and y < 0");
            break;
        case 4:
            Console.WriteLine("Point in x > 0 and y < 0");
            break;
        default:
            Console.WriteLine("No valid is quarter");
            break;
    }
}

Console.Write("Input quarter: ");
int numberQ = int.Parse(Console.ReadLine()!);

SearthPoint(numberQ);
