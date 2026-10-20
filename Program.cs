// Шаг 1

// int[] recordBooks = {1042, 1058, 1071, 1093, 1105};
// int target = 1072;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");







// Шаг 2

// int variant = 2;
// bool isPrime = true;

// if (variant < 2)
// {
//     isPrime = false;
// }
// else
// {
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");







// Шаг 3

// int[] pointPerLab = {8, -1, 10, 9, -1, 7};
// int sum = 0;
// int count = 0;

// foreach (int points in pointPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
//     count++;
// }
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Кол-во сданных работ: {count}");








// Шаг 4

int[] groupIds = {101, 104, 107, 104, 110};
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDuplicates = true;
            Console.WriteLine($"Найден дубликат: {groupIds[i]}");
            break;
        }
    }
}
Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : " Все номера уникальны");
