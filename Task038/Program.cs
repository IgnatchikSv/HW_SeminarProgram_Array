/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

int getLengthOfArray(string message)
{
  Console.WriteLine(message);
  int lengthOfArray = int.Parse(Console.ReadLine()!);
  return lengthOfArray;
}

int[] generateArray(int length, int start, int end)
{
  int[] result = new int[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(start,end);
  }
  return result;
}

void printArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}

int getDifferenceofMaxMin(int[] array)
{
  int maxValue = array[0];
  int minValue = array[0]; 
  for (int i = 0; i < array.Length; i++)
  { if (array[i] > maxValue)
    {
      maxValue = array[i];
    }
    if (array[i]< minValue)
    {
      minValue = array[i];
    }
  }
  int difference = maxValue - minValue;
  return difference;
}
int lengthOfArray = getLengthOfArray($"Введите длину массива:");
int[] array = generateArray(lengthOfArray, 0, 10);
printArray(array);
int difference = getDifferenceofMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {difference}");

