string[] color = { "Красный", "Оранжевый", "Желтый", "Зеленый", "Голубой", "Синий", "Фиолетовый" };

Console.WriteLine("Вам предоставлено семь цветов: ");

for (int i = 0; i < color.Length; i++)
{
    if (i < color.Length - 1)
        Console.Write($"{i + 1}. {color[i]}, ");
    else
        Console.WriteLine($"{i + 1}. {color[i]}");
}

string count;
Console.WriteLine("Введите числом сколько цветов из представленных вам нравятся: ");
count = Console.ReadLine();
if (string.IsNullOrEmpty(count))
{
    Console.WriteLine("Вам не нравятся ни один из предоставленных цветов :( ");
    return;
}
int numb;
numb = Convert.ToInt32(count);
if (numb == 0)
        Console.WriteLine("Вам не нравятся ни один из предоставленных цветов :( ");
else
{
    while (numb <= 0 || numb > 7)
    {
        Console.WriteLine("Введено число не соответствующее количеству предоставленных цветов." );
        Console.WriteLine("Введите числом сколько цветов из представленных вам нравятся: ");
        numb = Convert.ToInt32(Console.ReadLine());
    }

    string[] userColor = new string[numb];
    Console.WriteLine("Через ENTER укажите числа соответствующие данным цветам");
    int like;
    for (int j = 0; j < userColor.Length; j++)
    {
        like = Convert.ToInt32(Console.ReadLine());
        while (like <= 0 || like > 7)
        {
            Console.WriteLine("Введено число не соответствующее предоставленному цвету. Укажите числа соответствующие данным цветам: ");
            like = Convert.ToInt32(Console.ReadLine());
        }
        userColor[j] = color[like - 1];
    }

    Console.WriteLine("Выбранные вами цвета: ");
    for (int k = 0; k < userColor.Length; k++)
    {
        if (k < userColor.Length - 1)
            Console.Write($"{userColor[k]}, ");
        else
            Console.WriteLine(userColor[k]);
    }
}

