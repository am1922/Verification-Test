string[] array = {"Hello", "2", "world", ":-)"};

string[] FindThree(string[] array)
{
    int n = 3;

    var result = new string[array.Length];
    int realSize = 0;

    foreach (var value in array)
    {
        if (value.Length <= n)
        {
            result[realSize] = value;
            realSize++;
        }
    }

    string.Join(" ", result, 0, realSize);
    return result;
}

void ShowArray (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine ();
}

ShowArray(FindThree(array));
