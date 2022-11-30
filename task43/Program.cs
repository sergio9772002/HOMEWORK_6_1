/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double inputUserData(string userMessage)
{
    Console.WriteLine(userMessage);
    double userData = Convert.ToDouble(Console.ReadLine());
    return userData;
} 
void IntersecOfStreight(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double coordinateX = (b2 - b1) / (k1 -k2);
        double coordinateY = coordinateX * k1 + b1;
        Console.WriteLine($"точка пересечения прямых ({coordinateX}; {coordinateY})");
    }
    else
    {
        Console.WriteLine("прямые парралельные");
    }
}
double numberb1 = inputUserData("введите b1");
double numberk1 = inputUserData("введите k1");
double numberb2 = inputUserData("введите b2");
double numberk2 = inputUserData("введите k2");
IntersecOfStreight(numberb1, numberk1, numberb2, numberk2);
