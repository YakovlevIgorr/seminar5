// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, к
// оторая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[5];
int [] GetRandomArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,1000);
    }
    return array;
}

int EvenNumbers(int[] fullArray)
{
    int count = 0;
    for(int k = 0; k < fullArray.Length; k++)
    if(fullArray[k] % 2 == 0) count++;
    return count;
}

GetRandomArray();
int countSumm = EvenNumbers(GetRandomArray());
System.Console.WriteLine($"[{string.Join(",",array)}] -> {countSumm}");