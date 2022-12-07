// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();



bool palindrome(int num)
{
    int mlt = Convert.ToInt32(Math.Floor(Math.Log10(num)));
    int numCheck = num, stop = mlt / 2;

    while (stop >= 0)
    {
        if (numCheck % 10 == Convert.ToInt32(numCheck / Math.Pow(10, mlt)))
        {
            numCheck = Convert.ToInt32(numCheck % Math.Pow(10, mlt)) / 10;
            stop--;
            mlt -= 2;
        }
        else
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(palindrome(14212));

