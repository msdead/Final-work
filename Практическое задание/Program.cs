string[] color =
{
    "1. Красный",
    "2. Оранжевый",
    "3. Желтый",
    "4. Зеленый",
    "5. Голубой",
    "6. Синий",
    "7. Фиолетовый"
};

Console.WriteLine("Вам предоставлено семь цветов: ");

for (int i = 0; i < color.Length; i++)
{
    if (i < color.Length - 1)
        Console.Write($"{color[i]}, ");
    else
        Console.WriteLine(color[i]);
}


int count;
Console.WriteLine("Укажите числом сколько цветов из представленных вам нравятся");
count = Convert.ToInt32(Console.ReadLine());
string[] userColor = new string[count];
Console.WriteLine("Через ENTER укажите цифры соответствующие данным цветам");
int like;
for (int j = 0; j < userColor.Length; j++)
{
    like = Convert.ToInt32(Console.ReadLine());
    userColor[j] = color[like-1];
}

Console.WriteLine("Выбранные вами цвета: ");
for (int k = 0; k < userColor.Length; k++)
{
    if (k < userColor.Length - 1)
        Console.Write($"{userColor[k]}, ");
    else
        Console.WriteLine(userColor[k]);
}