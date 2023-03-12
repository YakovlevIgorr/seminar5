// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] array = new int[4];
int [] GetRandomArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,100);
    }
    return array;
}

int OddPositionArray(int [] fullArray)
{
    int summArray = 0;
    for(int i = 0; i < fullArray.Length; i++)
    {
        if(i % 2 == 1) summArray +=fullArray[i];
    }
    return summArray;
}

GetRandomArray();
int summOddPosition = OddPositionArray(GetRandomArray());
System.Console.WriteLine($"[{string.Join(",",array)}] -> {summOddPosition}");