// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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
