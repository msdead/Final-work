# Итоговая проверочная работа

## Описание решения

Для начала мы задали массив строк.
```
string[] numbers = { "Ноль", "Один", "Два", "Три", "Четыре", "Пять"};
```
В данном примере используются строки чисел от нуля до пяти.

Далее показываем пользователю массив который мы задали.
```
for (int i = 0; i < numbers.Length; i++)
{
    if (i < numbers.Length - 1)
        Console.Write($"{numbers[i]}, ");
    else
        Console.WriteLine(numbers[i]);
}
```
Далее мы приступаем к созданию нового массива.
```
string[] newNumbers = new string[numbers.Length];
```
Также создаем пару переменных для дальнейших вычислений.
```
int count = 0;
int numb = 0;
```
Далее создаем оператор для чтения нашего основного массива.
```
for (int j = 0; j < numbers.Length; j++)
```
Т.К. в условии нашей задачи нас просят создать массив состоящий из строк содержащие в себе не более трёх символов, мы помещаем оператор для чтения строк основного массива.
```
for (int l = 0; l < numbers[j].Length; l++)
```
Данный оператор считает нам количество символов в строке и записывает результат в переменную `count`.

Когда оператор по прочтению строки заканчивает свою работу, программа переходит к следующему пункту. 
```
if(count <= 3)
```
Данный оператор, определяет исходя из данных `count` предыдущего оператора, сколько символов было в проверяемой строке. И если в строке было три или меньше символов, программа записывала данную строку в новый массив.
```
newNumbers[numb] = numbers[j];
```
И в этом же операторе, в новом массиве, переводим запись с рабочей (первой) строки на следующую.
```
numb++;
```
После этого программа сбрасывает счетчик `count` к нулю, и начинает проверять следующую строку основного массива.

Когда функция по проверке строк основного массива закончит свою работу, это будет означать что программа сформировала нам новый массив. Но так как длинна нового массива была равна длине основного массива, то получается что в новом массиве могли остаться пустые строки. И для того чтобы наш новый массив не имел данных пустых строк мы использовали метод `Array.Resize`
```
Array.Resize(ref newNumbers, numb);
```
Данный метод берет наш массив и оставляет размер который мы указываем. В данном случае используется переменная `numb`, т.к. именно данная переменная отвечала за подсчёт нужных нам строк в новом массиве.

Ну и последним действием выводим результат пользователю.
```
Console.WriteLine("Ответ: ");
for (int k = 0; k < newNumbers.Length; k++)
{
    if (k < newNumbers.Length - 1)
        Console.Write($"{newNumbers[k]}, ");
    else
        Console.WriteLine(newNumbers[k]);
}
```

# Конец

#  Блок схема

![Blockscheme](БлокСхема.jpg)
