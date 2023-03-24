// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником.
// В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки.
// Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить,
// сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках.
// Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100).
// Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – натуральное число от 1 до 31.
// Все элементы массива разделены пробелом.

// В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые Вася получил тройки,
// а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки.
// В третьей строке нужно вывести «YES», если Вася может рассчитывать на четверку и «NO» в противном случае.
// В каждой строчке числа следует выводить в том же порядке, в котором они идут во входных данных.
// При выводе числа отделяются пробелом.
Console.Clear();

int[] input()
{
int N = new Random().Next(1,101);
int[] array = new int[N];
for (int i = 0; i < N; i++) array[i] = new Random().Next(1,32);
return array;
}

int[] honest(int[] array)
{
int[] newarray = new int[array.Length];
int j = -1;
for (int i = 0; i < array.Length; i++)
{
  if (array[i]%2 == 0)
  {
    j++;
    newarray[j] = array[i];
  }
}
int[] honestarray = new int[j];
for (int i = 0; i < j; i++) honestarray[i] = newarray[i];

return honestarray;
}

int[] odd(int[] array)
{
int[] newarray = new int[array.Length];
int j = -1;
for (int i = 0; i < array.Length; i++)
{
  if (array[i]%2 == 1)
  {
    j++;
    newarray[j] = array[i];
  }
}
int[] oddarray = new int[j];
for (int i = 0; i < j; i++) oddarray[i] = newarray[i];

return oddarray;
}

int[] array = input();
System.Console.WriteLine("INPUT");
System.Console.WriteLine(array.Length);
System.Console.WriteLine($"{string.Join(", ", array)}");
System.Console.WriteLine();
System.Console.WriteLine("OUTPUT");
System.Console.WriteLine($"{string.Join(", ", odd(array))}");
System.Console.WriteLine();
System.Console.WriteLine($"{string.Join(", ", honest(array))}");
System.Console.WriteLine();

if (honest(array).Length >= odd(array).Length) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");