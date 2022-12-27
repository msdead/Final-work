string[] numbers = { "Ноль", "Один", "Два", "Три", "Четыре", "Пять"};
Console.WriteLine("Дано: ");
for (int i = 0; i < numbers.Length; i++)
{
    if (i < numbers.Length - 1)
        Console.Write($"{numbers[i]}, ");
    else
        Console.WriteLine(numbers[i]);
}

string[] newNumbers = new string[numbers.Length];
int count = 0;
int numb = 0;
for (int j = 0; j < numbers.Length; j++)
{

    for (int l = 0; l < numbers[j].Length; l++)
    {
        count++;
    }
    
    if(count <= 3)
    {
        newNumbers[numb] = numbers[j];
        numb++;
    }
    count = 0;
}

Array.Resize(ref newNumbers, numb);

Console.WriteLine("Ответ: ");
for (int k = 0; k < newNumbers.Length; k++)
{
    if (k < newNumbers.Length - 1)
        Console.Write($"{newNumbers[k]}, ");
    else
        Console.WriteLine(newNumbers[k]);
}