// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = 5;

CountPositiveNumbersInc(M, out string lineOfNumbers, out int count);
Console.WriteLine($"{lineOfNumbers} -> {count}");


static void CountPositiveNumbersInc(int totalNum, out string lineOfNumbers, out int count)
{
    int newNumber;
    lineOfNumbers = "";
    count = 0;

    for (int i = 1; i <= totalNum; i++)
    {
        newNumber = GetIntFromUser($"Введите число ({i} из {totalNum}): ");
        lineOfNumbers = $"{lineOfNumbers}, {newNumber}";
        if (newNumber > 0) count++;
    }
    lineOfNumbers = lineOfNumbers.Remove(0,2); //Убираем лишнюю запятую и пробел в начале строки
    
    return;
}

static int GetIntFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        
        Console.WriteLine("Ошибка ввода!");
    }
}