// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray()
{
int[] array = new int[10];
for (int i = 0; i<10; i++) array[i] = new Random().Next(-100,101); //(-100,100)
return array;
}

int[] NewArray = CreateArray();
Console.WriteLine($"{string.Join(", ", NewArray)}");

int Sum = 0;
for (int i = 1; i<10; i=i+2) Sum = Sum + NewArray[i];
System.Console.WriteLine(Sum);
