// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задача 38");
Console.WriteLine();
double[] arrayVechNumbers = new double[10];
Console.WriteLine("Массив вещественных чисел: ");
  for (int i = 0; i < arrayVechNumbers.Length; i++ )
  {
    arrayVechNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayVechNumbers[i] + " ");
  }
double maxNumber = arrayVechNumbers[0];
double minNumber = arrayVechNumbers[0];
  for (int i = 1; i < arrayVechNumbers.Length; i++)
  {
    if (maxNumber < arrayVechNumbers[i])
    {
      maxNumber = arrayVechNumbers[i];
    }
        if (minNumber > arrayVechNumbers[i])
    {
      minNumber = arrayVechNumbers[i];
    }
  }
Console.WriteLine();
double decision = maxNumber - minNumber;
Console.WriteLine($"Разница между между максимальным значением ({maxNumber}) и минимальным ({minNumber}) элементами массива: {decision}.");
