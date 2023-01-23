/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int getSumOfNumberOfOddIndex(int[] array)
{
  int sumOfNumber = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
    {
      sumOfNumber += array[i];
    }
  }
  return sumOfNumber;
}

void showSum(string messageStart, int sumOfNumber)
{
  Console.Write(messageStart);
  Console.Write(sumOfNumber);
}
int lengthOfArray = getLengthOfArray($"Введите длину массива");
int[] array = generateArray(lengthOfArray, -10, 10);
printArray(array);
int sumOfNumber = getSumOfNumberOfOddIndex(array);
showSum($"Сумма элементов, стоящих на нечётных позициях, равна ", sumOfNumber);
