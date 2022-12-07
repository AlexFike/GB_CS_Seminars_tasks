// Напишите программу, которая, используя генератор случайных чисел, 
// будет подбрасывать монетку до тех пор, пока не выпадет три раза подряд одинаковое значение, 
// т.е. либо Орел-Орел-Орел, либо Решка-Решка-Решка. 
// Результат каждого броска программа должна выводить при каждом броске. 
// В конце выполнения программа должна вывести количество сделанных бросков. 
// Использовать массивы и строки нельзя, только циклы и ветвления


void HeadsTails()
{
    int first, second, third, count = 3;

    first = new Random().Next(0, 2); ;
    Console.Write(first + " ");
    second = new Random().Next(0, 2); ;
    Console.Write(second + " ");
    third = new Random().Next(0, 2); ;
    Console.Write(third + " ");

    while (true)
    {
        if (third == second && first == third) break;
        else
        {
            first = second;
            second = third;
            third = new Random().Next(0, 2);
            count++;
            Console.Write(third + " ");
        }
    }
    Console.Write($"Number of throws = {count}");
}

HeadsTails();
