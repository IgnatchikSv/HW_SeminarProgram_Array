/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();
int getLengthOfArray(string message)
{
  Console.ForegroundColor = ConsoleColor.DarkCyan;
  Console.WriteLine(message);
  Console.ResetColor();
  int lengthOfArray = int.Parse(Console.ReadLine()!);
  return lengthOfArray;
}

int[] generateArray(int length, int start, int end)
{
  int[] result = new int[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(start, end + 1);
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

int getCountOfEvenNumber(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count += 1;
    }
  }
  return count;
}

void showCount(string messageStart, int count)
{
  Console.ForegroundColor = ConsoleColor.DarkCyan;
  Console.Write(messageStart);
  Console.ResetColor();
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.Write(count);
  Console.ResetColor();
}
int lengthOfArray = getLengthOfArray($"Введите длину массива");
int[] array = generateArray(lengthOfArray, 100, 999);
printArray(array);
int count = getCountOfEvenNumber(array);
showCount($"Количество четных чисел в массива равно ", count);
