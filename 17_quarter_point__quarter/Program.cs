int SearchQuarter(int x, int y)
{
    switch ((x, y))
    {
        case ( > 0, > 0):
            return 1;
        case ( <0, > 0):
            return 2;
        case ( < 0, < 0):
            return 3;
        case ( > 0, < 0):
            return 4;
        default:
            return 0;
    }
}


Console.Write("Input point X: ");
int numberX = int.Parse(Console.ReadLine()!);

Console.Write("Input point Y: ");
int numberY = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Point in quarter => {SearchQuarter(numberX,numberY)}");

