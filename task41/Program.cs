Console.WriteLine("Введите ряд числе через пробел");
var str = Console.ReadLine() ?? "";

int[] arr = Array.ConvertAll(str.Split(' '), int.Parse);

int posSum = 0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0) posSum++;

Console.WriteLine($"Количество чисел больше 0 равно: {posSum}");