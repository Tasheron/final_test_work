int checkN(string text)
{
    if (text == "")
    {
        Console.Write("Вы ничего не ввели. Введите колличество элементов массива: ");
        var n = Console.ReadLine();
        return checkN(n);
    }
    else if (int.TryParse(text, out int n))
    {
        if (n != 0)
        {
            return n;
        }
        else
        {
            Console.Write("Массив не может состоять из 0 элементов. Введите колличество элементов массива: ");
            var N = Console.ReadLine();
            return checkN(N);
        }
    }
    else
    {
        Console.Write("Вы ввели неверное значение. Введите колличество элементов массива: ");
        var N = Console.ReadLine();
        return checkN(N);
    }
}

Console.Write("Введите колличество элементов массива: ");
int n = checkN(Console.ReadLine());

string[] array = new string[n];
string temp = string.Empty;
int count = 0;
int rangeStart = 0;
int rangeEnd = 4;

Console.WriteLine("Введите элементы массива: ");

for (int i = 0; i < n; i++)
{
    Console.Write(i + 1 + ". ");
    temp = Console.ReadLine();
    if (temp.Length > rangeStart && temp.Length < rangeEnd)
    {
        array[count] = temp;
        count++;
    }
}

Array.Resize(ref array, count);

if (array.Length > 0)
{
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(i + 1 + ". " + array[i]);
    }
}
else
{
    Console.WriteLine("Новый массив пуст");
}