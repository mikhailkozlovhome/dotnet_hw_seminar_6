
// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt (string msg)
{
    int value;
    System.Console.Write($"{msg} -> ");
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Введенно неверное значение!");
    Environment.Exit(999);
    return 0;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] InputArray (int arrLength)
{
    int[] array = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = InputInt($"Введите {i+1}-е число");
    }
    return array;
}

int NumOfPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int numOfNum = InputInt("Введите количество чисел, которые собираетесь вводить");
int [] myArray = InputArray(numOfNum);
printArray(myArray);
System.Console.WriteLine($"Вы ввели {NumOfPositiveNum(myArray)} положительных числа");

