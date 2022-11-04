/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/
Console.Write("Введите длину массива - ");
int N = Convert.ToInt32(Console.ReadLine());
int minN = 100;
int maxN = 1000;
int summ = 0;


int[] array = new int[N];
Random myRandom = new Random();
 
Console.Write("[");
for (int i = 0; i < N; i++)
{
    if(i < N - 1 )
    {
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i] +  ", ");
    }
    else 
    {
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i]);
    }

        if (array[i] % 2 == 0)
    {
        summ++;
    }

}
Console.Write("]" + " - Колличество четных чисел = " + summ);

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.Write("Введите длину массива - ");
int N = Convert.ToInt32(Console.ReadLine());
int minN = -100;
int maxN = 100;
int summ = 0;

int[] array = new int[N];
Random myRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i] + " ");
    if( i % 2 == 1)
    {
         summ += array[i];
    }
}
    Console.Write("Сумма нечентых позиций массива = " + summ);

/*
 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

 Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}