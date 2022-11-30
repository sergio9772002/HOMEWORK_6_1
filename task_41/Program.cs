/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int[] arrayNElements(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}
int sumOfPositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            sum++; 
        }
    }
    return sum;
}
Console.WriteLine("Введите числа");
int[] enterArray = arrayNElements(5);
printArray(enterArray);
int sumOfPosNumbers = sumOfPositiveNumbers(enterArray);
Console.WriteLine($"Количество элементов в массиве больше нуля {sumOfPosNumbers}");
