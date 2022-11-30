// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2 - b1) / (k1 - k2)
// y = k1 * ((b2 - b1) / (k1 - k2)) + b1

Console.WriteLine("Поиск пересечения прямых, заданных формулами: y = k1 * x + b1, y = k2 * x + b2.");

double b1 = GetDoubleFromUser("Введите значение b1: ");
double k1 = GetDoubleFromUser("Введите значение k1: ");
double b2 = GetDoubleFromUser("Введите значение b2: ");
double k2 = GetDoubleFromUser("Введите значение k2: ");

if (k1 == k2)
    Console.WriteLine("Прямые не имеют точек пересечения.");
else
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({FindXofLineIntersection(k1,k2,b1,b2)}; {FindYofLineIntersection(k1,k2,b1,b2)})");


static double FindXofLineIntersection(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

static double FindYofLineIntersection(double k1, double k2, double b1, double b2)
{
    double y = k1 * ((b2 - b1) / (k1- k2)) + b1;
    return y;
}

static double GetDoubleFromUser(string userMsg) //TryParse
{
    while(true)
    {
        Console.Write(userMsg);
        if (double.TryParse(Console.ReadLine(), out double num))
            return num;
        
        Console.WriteLine("Ошибка ввода!");
    }
}