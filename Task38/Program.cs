// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int a, int b)
{
double[] massive = new double[8];
for (int i = 0; i< massive.Length; i++) massive[i] = Math.Round(new Random().NextDouble()*(b-a) + a, 2);
return massive;
}

double Difference(double[] array)
{
  double min = array[0];
  double max = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
  }
  double dif = max - min;
return dif;
}

System.Console.WriteLine("Введите минимальное возможное значение элемента массива");
int MinPossible = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите максимальное возможное значение элемента массива");
int MaxPossible = int.Parse(Console.ReadLine()!);

double[] array = CreateArray(MinPossible,MaxPossible);
System.Console.WriteLine($"{string.Join(", ", array)}");
System.Console.WriteLine("Разница между максимальным и минимальным элементов массива составляет {0}", Difference(array));