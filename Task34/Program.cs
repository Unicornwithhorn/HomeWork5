// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int length)
{
  int[] array = new  int[length];
  for (int i = 0; i < length; i++) array[i] = new Random().Next(100,1000);
  return array;
}

int Count(int[] array)
{
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]%2 == 0) counter++;
  }
  return counter;
}

System.Console.WriteLine("Введите число элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] newarray = CreateArray(n);
Console.WriteLine($"{string.Join(", ", newarray)}");
int counter = Count(newarray);
System.Console.WriteLine(counter);
