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

Console.WriteLine("Введите элементы массива: ");
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write(i + 1 + ". ");
    array[i] = Console.ReadLine();
}

string[] newArray = new string[n];
int j = 0;

for (var i = 0; i < n; i++)
{
    if (array[i].Length < 4 && array[i].Length > 0)
    {
        newArray[j] = array[i];
        j++;
    }
}

Array.Resize(ref newArray, j);

if (newArray.Length > 0)
{
    Console.WriteLine("Новый массив: ");
    for (var i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine(i + 1 + ". " + newArray[i]);
    }
}
else
{
    Console.WriteLine("Новый массив пуст");
}